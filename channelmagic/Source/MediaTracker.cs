using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChannelMagic.Models;

using TagLib;

namespace ChannelMagic.Source
{
    public static class MediaTracker
    {

        public static void addTvShowMedia(string mediaPath) {

            List<string> files = App.findMediaFilesInDirectory(mediaPath);

            if (files != null && files.Count > 0) {

                foreach (string file in files) {

                    if (!Database.checkTvShowMediaPathExists(file)) {
                        addTvShowItem(file);                    
                    }

                }

                ChannelManager.mediaTvShowItems = Database.getTvShowsList();
            }
        }

        public static void addTvShowItem(string path) {
            
            TvShowItemModel item = new TvShowItemModel();

            int startIndex = path.LastIndexOf('\\') + 1;
            item.FileName = path.Substring(startIndex, (path.LastIndexOf('.') - startIndex));
            item.FileExtension = path.Substring(path.LastIndexOf('.') + 1);
            item.DateAdded = DateTime.Now;
            item.FilePath = path;

            TvMetaDataModel metadata = parseTvMediaFileName(item.FileName);

            item.Season = metadata.Season;
            item.Episode = metadata.Episode;

            try {

                TagLib.File.Create(path);
                TagLib.File tagFile = TagLib.File.Create(path);


                item.Duration = tagFile.Properties.Duration;
                item.FileType = tagFile.Properties.Description;
                item.FrameSize = String.Format("{0}x{1}", tagFile.Properties.VideoWidth, tagFile.Properties.VideoHeight);
                item.BitRate = tagFile.Properties.BitsPerSample.ToString();
            } catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }


            Database.addTvShowItem(item);
        }

        private static TvMetaDataModel parseTvMediaFileName(string filename) {
            TvMetaDataModel metadata = new TvMetaDataModel();

            try {


                string filenameLower = filename.ToLower();
                string filenameFormatted = filename.ToLower();
                filenameFormatted = filenameFormatted.Replace(" ", "").Replace("-", "").Replace(".", "").Replace("_", "").Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "");

                // find season number
                bool bFoundSeason = false;
                int seasonIndex = -1;

                // check for seasons in format: S05
                while (!bFoundSeason) {
                    seasonIndex = filenameLower.IndexOf('s', ((seasonIndex > -1) ? seasonIndex + 1 : 0));

                    if (seasonIndex == -1)
                        break;

                    string seasonStr = ((filenameLower.Length >= seasonIndex + 3) ? filenameLower.Substring(seasonIndex + 1, 2) : "");
                    if (isStringNumeric(seasonStr)) {
                        metadata.Season = Convert.ToInt32(seasonStr);
                        bFoundSeason = true;
                    }
                }

                // check for seasons in format: S5
                seasonIndex = -1;
                while (!bFoundSeason) {
                    seasonIndex = filenameLower.IndexOf('s', ((seasonIndex > -1) ? seasonIndex + 1 : 0));

                    if (seasonIndex == -1)
                        break;

                    string seasonStr = ((filenameLower.Length >= seasonIndex + 2) ? filenameLower.Substring(seasonIndex + 1, 1) : "");
                    if (isStringNumeric(seasonStr)) {
                        metadata.Season = Convert.ToInt32(seasonStr);
                        bFoundSeason = true;
                    }
                }

                if (!bFoundSeason) {
                    seasonIndex = filenameFormatted.IndexOf("season");

                    if (seasonIndex > -1) {
                        seasonIndex += 6;

                        // check format season 06
                        string seasonStr = filenameFormatted.Substring(seasonIndex, 2);
                        if (isStringNumeric(seasonStr)) {
                            metadata.Season = Convert.ToInt32(seasonStr);
                            bFoundSeason = true;
                        }

                        if (!bFoundSeason) {
                            // check format season 6

                            seasonStr = filenameFormatted.Substring(seasonIndex, 1);

                            if (isStringNumeric(seasonStr)) {
                                metadata.Season = Convert.ToInt32(seasonStr);
                                bFoundSeason = true;
                            }
                        }
                    }
                }


                // check for episode in format: E05
                bool bFoundEpisode = false;
                int episodeIndex = -1;
                while (!bFoundEpisode) {
                    episodeIndex = filenameLower.IndexOf('e', ((episodeIndex > -1) ? episodeIndex + 1 : 0));

                    if (episodeIndex == -1)
                        break;

                    string episodeStr = ((filenameLower.Length >= episodeIndex + 3) ? filenameLower.Substring(episodeIndex + 1, 2) : "");
                    if (isStringNumeric(episodeStr)) {
                        metadata.Episode = Convert.ToInt32(episodeStr);
                        bFoundEpisode = true;
                    }
                }

                // check for episode in format: E5
                episodeIndex = -1;
                while (!bFoundEpisode) {
                    episodeIndex = filenameLower.IndexOf('e', ((episodeIndex > -1) ? episodeIndex + 1 : 0));

                    if (episodeIndex == -1)
                        break;

                    string episodeStr = ((filenameLower.Length >= episodeIndex + 2) ? filenameLower.Substring(episodeIndex + 1, 1) : "");
                    if (isStringNumeric(episodeStr)) {
                        metadata.Episode = Convert.ToInt32(episodeStr);
                        bFoundEpisode = true;
                    }
                }

                if (!bFoundEpisode) {
                    episodeIndex = filenameFormatted.IndexOf("episode");

                    if (episodeIndex > -1) {
                        episodeIndex += 7;

                        // check format episode 06
                        string episodeStr = filenameFormatted.Substring(episodeIndex, 2);
                        if (isStringNumeric(episodeStr)) {
                            metadata.Episode = Convert.ToInt32(episodeStr);
                            bFoundEpisode = true;
                        }

                        if (!bFoundEpisode) {
                            // check format episode 6

                            episodeStr = filenameFormatted.Substring(episodeIndex, 1);

                            if (isStringNumeric(episodeStr)) {
                                metadata.Episode = Convert.ToInt32(episodeStr);
                                bFoundEpisode = true;
                            }
                        }
                    }
                }



                if (!bFoundSeason && !bFoundEpisode) {
                    // Unable to retreive season and episode 

                    // checking for season/episode format 0213

                    for (int i = 0; i < filenameLower.Length; i++) {
                        if (i + 4 <= filenameLower.Length) {
                            string sub = filenameLower.Substring(i, 4);
                            if (isStringNumeric(sub)) {
                                metadata.Season = Convert.ToInt32(sub.Substring(0, 2));
                                metadata.Episode = Convert.ToInt32(sub.Substring(2, 2));

                                bFoundSeason = true;
                                bFoundEpisode = true;
                                break;
                            }
                        } else {
                            break;
                        }
                    }




                    // checking for season/episode format 213
                    for (int i = 0; i < filenameLower.Length; i++) {
                        if (i + 3 <= filenameLower.Length) {
                            string sub = filenameLower.Substring(i, 3);
                            if (isStringNumeric(sub)) {
                                metadata.Season = Convert.ToInt32(sub.Substring(0, 1));
                                metadata.Episode = Convert.ToInt32(sub.Substring(1, 2));

                                bFoundSeason = true;
                                bFoundEpisode = true;
                                break;
                            }
                        } else {
                            break;
                        }
                    }


                }

            } catch (Exception ex) {

            }

            return metadata;
        }

        private static bool isStringNumeric(string str) {

            if (String.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++) {

                if(!Char.IsNumber(Convert.ToChar(str.Substring(i, 1)))) {
                    return false;
                }

            }

            return true;
        }
    }
}
