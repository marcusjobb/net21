using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Helpers;
using static TheGame.Helpers.UserExperience;
using static TheGame.DisplayMethods.Display;

namespace TheGame.GameAssets
{
    public class Splashscreen
    {
        /// <summary>
        /// Simple "splashscreen". Displays the title of the game and some art.
        /// </summary>
        public static void Show()
        {
            Console.CursorVisible = false;
            string splashScreenArt = ArtAssets.splashScreenArt;
            Console.CursorTop = Console.WindowHeight / 4;
            WriteLineColour(ArtAssets.gameLogo, Console.ForegroundColor=ConsoleColor.Yellow);
            // TODO: Fix the position trial and error numbers into proper ones.
            Console.CursorTop = Console.WindowHeight -3;
            Console.CursorLeft = Console.WindowWidth / 2 - 14;
            PressEnterToContinue();
            WriteLineColour(splashScreenArt, Console.ForegroundColor = ConsoleColor.Yellow);
            System.Threading.Thread.Sleep(550);
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}
