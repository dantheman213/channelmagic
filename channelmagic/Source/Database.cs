using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using SQLite;

using ChannelMagic.Models;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace ChannelMagic.Source
{
    public static class Database
    {
        private static string DB_PATH = App.getApplicationPath() + "data.db";
        private static SQLiteConnection db = null;
        public static bool isConnected = false;

        public static void init() {
            string connection = String.Format("Data Source={0}", DB_PATH);
            db = new SQLiteConnection(connection);

            db.Open();
            isConnected = true;
        }

        public static bool checkTvShowMediaPathExists(string path) {

            string escParam = MySQLEscape(path);
            string sql = String.Format("SELECT MediaId, FilePath FROM cm_tvshows WHERE FilePath='{0}'", escParam);

            SQLiteCommand statement = new SQLiteCommand(db);
            statement.CommandText = sql;

            SQLiteDataReader dbReader = statement.ExecuteReader();

            int bRecordCount = 0;
            while (dbReader.Read()) {
                bRecordCount++;
            }

            if (bRecordCount > 0)
                return true;

            return false;
        }

        public static List<TvShowItemModel> getTvShowsList() {
            List<TvShowItemModel> items = new List<TvShowItemModel>();

            // TBD DO ERROR CHECKING AND REPORTING
            string sql = "SELECT * FROM cm_tvshows";

            SQLiteCommand statement = new SQLiteCommand(db);
            statement.CommandText = sql;

            SQLiteDataReader dbReader = statement.ExecuteReader();

            while (dbReader.Read()) {
                TvShowItemModel item = new TvShowItemModel();

                item.MediaId = Convert.ToInt32(dbReader["MediaId"].ToString());
                item.Title = dbReader["Title"].ToString();
                item.Rating = Convert.ToInt32(dbReader["Rating"].ToString());

                string[] durationParts = dbReader["Duration"].ToString().Split(':');
                item.Duration = new TimeSpan(0, Convert.ToInt32(durationParts[0]), Convert.ToInt32(durationParts[1]), Convert.ToInt32(durationParts[2]) );

                item.Season = Convert.ToInt32(dbReader["Season"].ToString());
                item.Episode = Convert.ToInt32(dbReader["Episode"].ToString());

                item.BitRate = dbReader["BitRate"].ToString();
                item.FrameSize = dbReader["FrameSize"].ToString();
                item.FileName = dbReader["FileName"].ToString();
                item.FileExtension = dbReader["FileExtension"].ToString();
                item.FilePath = dbReader["FilePath"].ToString();
                item.FileType = dbReader["FileType"].ToString();
                item.DateAdded = DateTime.Parse(dbReader["DateAdded"].ToString());


                items.Add(item);
            }

            return items;
        }

        public static bool addTvShowItem(TvShowItemModel item) {

            try {

                string mediaDuration = ((item.Duration != null) ? String.Format("{0}:{1}:{2}", item.Duration.Hours.ToString(), item.Duration.Minutes.ToString(), item.Duration.Seconds.ToString()) : "");
                string title = ((!String.IsNullOrEmpty(item.Title)) ? MySQLEscape(item.Title) : "");
                string season = ((item.Season > 0) ? MySQLEscape(item.Season.ToString()) : "0");
                string episode = ((item.Episode > 0) ? MySQLEscape(item.Episode.ToString()) : "0");
                string rating =  ((!String.IsNullOrEmpty(item.Rating.ToString())) ? item.Rating.ToString() : "");
                string bitrate = ((!String.IsNullOrEmpty(item.BitRate)) ? item.BitRate.ToString() : "");
                string framesize = ((!String.IsNullOrEmpty(item.FrameSize)) ? MySQLEscape(item.FrameSize) : "");
                string filename = ((!String.IsNullOrEmpty(item.FileName)) ? MySQLEscape(item.FileName) : "");
                string fileextension = ((!String.IsNullOrEmpty(item.FileExtension)) ? MySQLEscape(item.FileExtension) : "");
                string filepath = ((!String.IsNullOrEmpty(item.FilePath)) ? MySQLEscape(item.FilePath) : "");
                string filetype = ((!String.IsNullOrEmpty(item.FileType)) ? MySQLEscape(item.FileType) : "");
                string dateadded = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

                string sql = String.Format("INSERT INTO cm_tvshows (Title, Season, Episode, Rating, Duration, BitRate, FrameSize, FileName, FileExtension, FilePath, FileType, DateAdded) VALUES ('{0}', {1}, {2}, {3}, '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                    title,
                    season,
                    episode,
                    rating,
                    mediaDuration,
                    bitrate,
                    framesize,
                    filename,
                    fileextension,
                    filepath,
                    filetype,
                    dateadded
                );

                SQLiteCommand statement = new SQLiteCommand(db);
                statement.CommandText = sql;
                statement.ExecuteNonQuery();

                return true;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        private static string MySQLEscape(string str) {
            // TBD ESCAPE ISNT WORKING FOR SINGLE QUOTES IN FILES. E.G. CHECK THAT '70S SHOW

            if (String.IsNullOrEmpty(str))
                return "";


            //return str.Replace("\\", "\\\\").Replace("\0", "\\0").Replace("\n", "\\n").Replace("\r", "\\r").Replace("'", "\'").Replace("\"", "\\\"").Replace("\x1a", "\\Z");
            string ret = str.Replace("\0", "\\0").Replace("\n", "\\n").Replace("\r", "\\r").Replace("'", "''").Replace("\"", "\\\"").Replace("\x1a", "\\Z");
            return ret;
        }


    }
}
