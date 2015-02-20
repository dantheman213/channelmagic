using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelMagic.Models
{
    public class MovieItemModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public TimeSpan Duration { get; set; }
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
