using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.App
{
    class Colours
    {

        [Flags]
        public enum Rainbow
        {
            Red = 1,
            Orange = 2,
            Yellow = 4,
            Green = 8,
            Blue = 16,
            Indigo = 32,
            Violet = 64
        }
    }
}
