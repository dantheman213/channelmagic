using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChannelMagic.Enums;

namespace ChannelMagic.Models
{
    public class MediaStateInfoModel
    {
        public bool Mute { get; set; }
        public int VolumeLevel { get; set; }
        public PlaybackStateEnum PlaybackState { get; set; }

        public MediaStateInfoModel() {
            Mute = false;
            VolumeLevel = 100;
            PlaybackState = PlaybackStateEnum.STOPPED;
        }
    }
}
