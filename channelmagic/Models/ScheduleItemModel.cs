using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChannelMagic.Enums;

namespace ChannelMagic.Models
{
    public class ScheduleItemModel
    {
        public int ScheduleId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MediaId { get; set; }
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public MediaTypeEnum MediaType { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }
    }
}
