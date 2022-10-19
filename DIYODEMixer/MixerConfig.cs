using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYODEMixer
{
    internal class MixerConfig
    {
        //The action that will be completed when an associated mixer button is pressed.
        public enum ButtonAction {
            NONE,
            SWITCH,
            MUTE_TEMP,
            MUTE_TOGGLE,
            REDUCE_50,
            REDUCE_90
        }

        public ButtonAction buttonAction;

        public MixerConfig()
        {

        }



        public static MixerConfig DeserializeConfig(String input)
        {
            return new MixerConfig();
        }

        public static String SerializeConfig()
        {
            return "";
        }
    }
}
