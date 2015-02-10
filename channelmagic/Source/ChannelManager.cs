using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WMPLib;
using AxWMPLib;

using ChannelMagic.Enums;
using ChannelMagic.Models;


namespace ChannelMagic.Source
{
    public static class ChannelManager
    {
        public static AxWindowsMediaPlayer mediaPlayer = null; 
        public static List<TvShowItemModel> mediaTvShowItems = null;
        public static MediaStateInfoModel mediaState = null;
        public static List<ChannelModel> channels = null;

        public static TvShowItemModel currentShow = null;
        public static ScheduleItemModel currentScheduleItem = null;
        public static int currentChannel = 1;

        public static void init() {

            mediaTvShowItems = Database.getTvShowsList();
            mediaState = new MediaStateInfoModel();

            channels = new List<ChannelModel>();
            generateChannelSchedule();
            Console.WriteLine("here");
        }

        private static void generateChannelSchedule() {
            // TBD replace

            if (mediaTvShowItems.Count < 1) {
                return;
            }

            DateTime currentTime = DateTime.Now;
            DateTime nowTime = currentTime;
            string[] networks = { "ABC", "NBC", "FOX", "FX", "UPN", "HBO", "ShoTime", "Cinemax", "Starz", "SciFi" };

            ChannelModel channel = null;
            for (int i = 0; i < 10; i++) {
                channel = new ChannelModel();

                channel.ChannelId = i + 1000;
                channel.ChannelName = networks[i];
                channel.ScheduleList = new List<ScheduleItemModel>();

                for (int k = 0; k < 100; k++) {
                    TvShowItemModel show = getRandomTvShow();

                    if (show.Duration.TotalMinutes > 0 && show.Season > 0 && show.Episode > 0) {
                        ScheduleItemModel item = new ScheduleItemModel();
                        item.MediaId = show.MediaId;
                        item.ChannelId = channel.ChannelId;
                        item.ChannelName = channel.ChannelName;
                        item.MediaType = MediaTypeEnum.TV_SHOW;
                        item.StartTime = nowTime;
                        item.EndTime = nowTime.AddSeconds(show.Duration.TotalSeconds);
                        item.Title = show.FileName;
                        item.SubTitle = String.Format("Season {0} Episode {1}", show.Season, show.Episode);

                        nowTime = nowTime.AddSeconds(show.Duration.TotalSeconds + 1);

                        channel.ScheduleList.Add(item);
                    }

                    nowTime = currentTime;
                }

                channels.Add(channel);
            }
        }

        public static TvShowItemModel getRandomTvShow() {
            int nIndex = App.generateRandomNumber(0, mediaTvShowItems.Count - 1);
            return mediaTvShowItems[nIndex];
        }

        public static void playInitialVideo() {
            ScheduleItemModel item = channels[0].ScheduleList[0];

            currentScheduleItem = item;
            currentShow = mediaTvShowItems.FirstOrDefault(x => x.MediaId == item.MediaId);

            mediaPlayer.URL = currentShow.FilePath;
            playPause();
        }

        public static void changeChannel(string direction) {

            if (direction == "up") {

                if (currentChannel > 1) {
                    currentChannel--;

                    playChannel();
                }
            } else if (direction == "down") {

                if (currentChannel < channels.Count) {
                    currentChannel++;

                    playChannel();
                }
            } 
        }

        public static void playChannel(bool isMediaEnding = false) {

            //if (isMediaEnding)
            //    currentScheduleItem = channels[currentChannel - 1].ScheduleList.FirstOrDefault(x => x.StartTime <= DateTime.Now && x.EndTime > DateTime.Now);
            //else
            //    currentScheduleItem = channels[currentChannel - 1].ScheduleList.FirstOrDefault(x => x.StartTime <= DateTime.Now && x.EndTime > DateTime.Now);

            currentScheduleItem = null;
            DateTime now = DateTime.Now.AddSeconds(1);
            foreach (ScheduleItemModel item in channels[currentChannel - 1].ScheduleList) {

                // Assuming you know d2 > d1
                if (now.Ticks > item.StartTime.Ticks && now.Ticks < item.EndTime.Ticks) {
                    // targetDt is in between d1 and d2
                    currentScheduleItem = item;
                    break;
                }   
            }

             


            currentShow = mediaTvShowItems.FirstOrDefault(x => x.MediaId == currentScheduleItem.MediaId);

            double diff = (DateTime.Now - currentScheduleItem.StartTime).TotalSeconds;

            stop();
            mediaPlayer.URL = currentShow.FilePath;
            mediaPlayer.Ctlcontrols.currentPosition = ((diff < 0) ? 0 : diff);
            playPause();
        }

        public static void playMediaItem() {

            if (mediaTvShowItems != null && mediaTvShowItems.Count > 0) {
                stop();

                if (App.settings.IsFullscreen) {

                }

                TvShowItemModel show = getRandomTvShow();
                mediaPlayer.URL = show.FilePath;
                playPause();
            }
        }

        public static void mute() {

            if (mediaState.Mute) {
                mediaState.Mute = false;

            } else {
                mediaState.Mute = true;
            }

            mediaPlayer.settings.mute = mediaState.Mute;
        }

        public static void stop() {

            mediaState.PlaybackState = PlaybackStateEnum.STOPPED;
            mediaPlayer.Ctlcontrols.stop();
            mediaPlayer.close();
        }

        public static void playPause() {
            if (mediaState.PlaybackState == PlaybackStateEnum.PLAYING) {
                mediaState.PlaybackState = PlaybackStateEnum.PAUSED;

                mediaPlayer.Ctlcontrols.pause();
            } else if (mediaState.PlaybackState == PlaybackStateEnum.PAUSED) {
                mediaState.PlaybackState = PlaybackStateEnum.PLAYING;

                mediaPlayer.Ctlcontrols.play();
            } else if (mediaState.PlaybackState == PlaybackStateEnum.STOPPED) {
                mediaState.PlaybackState = PlaybackStateEnum.PLAYING;

                mediaPlayer.Ctlcontrols.play();
            }

            
            if (mediaState.PlaybackState == PlaybackStateEnum.PLAYING) {
                App.frameMain.showOverlay();
            }
        }
    }
}
