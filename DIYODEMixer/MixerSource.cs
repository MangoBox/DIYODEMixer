using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYODEMixer
{
    internal class MixerSource
    {
        public String sourceName;
        public enum ChannelType
        {
            CHANNEL_1,
            CHANNEL_2,
            CHANNEL_3,
            DISABLED
        }

        public ChannelType channel;

        public MixerSource(String sourceName, ChannelType channel)
        {
            this.sourceName = sourceName;
            this.channel = channel;
        }

        public static ChannelType intToChannel(int channel)
        {
            switch (channel) {
                case 1: return ChannelType.CHANNEL_1;
                case 2: return ChannelType.CHANNEL_2;
                case 3: return ChannelType.CHANNEL_3;
                default: return 0;
            }
        }

    }
}
