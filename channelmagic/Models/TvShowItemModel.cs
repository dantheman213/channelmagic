using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChannelMagic.Models
{
    public class TvShowItemModel
    {
        public int MediaId { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public TimeSpan Duration { get; set; }
        public int SeriesId { get; set; }
        public int Season { get; set; }
        public int Episode { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string BitRate { get; set; }
        public string FrameSize { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastPlayed { get; set; }
    }
}
