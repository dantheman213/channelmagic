using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelMagic.Models
{
    public class ChannelModel
    {
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public List<ScheduleItemModel> ScheduleList { get; set; }
        
    }
}
