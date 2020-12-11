using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourHanoi
{
    class Map
    {
        public const int MaxTop = 30;
        public const int MaxLeft = 100;
        public const int BaseLeft = 5;
        public const int BaseRight = 95;
        public const int BaseTop = 18;
        public const int PegTop = 10;
        public const int PegBot = 17;
        public static int[] PegLeft = { 20, 50, 80 };
        public const int SrcLeft = 5;
        public const int SrcTop = 23;
        public const int DstLeft = 35;
        public const int DstTop = 23;
        public const int MsgLeft = 5;
        public const int MsgTop = 25;
        public const int MovesLeft = 5;
        public const int MovesTop = 2;
        public static ConsoleColor[] DiskColors =
        {
            ConsoleColor.Red, 
            ConsoleColor.Green, 
            ConsoleColor.Yellow, 
            ConsoleColor.Cyan, 
            ConsoleColor.Blue,
            ConsoleColor.Magenta,
            ConsoleColor.Gray,
            ConsoleColor.DarkRed
        };
    }
}
