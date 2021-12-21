using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EF_Genealogy.Display.ArtAssets.ASCII;
using EF_Genealogy.Utils.Helpers;

namespace EF_Genealogy.Display
{
    public static class DisplayHelper
    {
        public static void ClearAndSetBackground()
        {
            Console.Clear();
            WriteLineColour(background, ConsoleColor.DarkGray);
            Console.CursorTop = 0;
        }

        public static void SetColours()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Console.WriteLine(); - Now in colour!
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColour"></param>
        /// <param name="backgroundColour"></param>
        public static void WriteLineColour(string text, ConsoleColor foregroundColour = ConsoleColor.Yellow, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        /// <summary>
        /// Console.Write(); - Now in colour!
        /// </summary>
        /// <param name="text"></param>
        /// <param name="foregroundColour"></param>
        /// <param name="backgroundColour"></param>
        public static void WriteColour(string text, ConsoleColor foregroundColour = ConsoleColor.Yellow, ConsoleColor backgroundColour = ConsoleColor.Black)
        {
            Console.ForegroundColor = foregroundColour;
            Console.BackgroundColor = backgroundColour;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
