using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQL_Assignment1.Helpers.DisplayHelper;

namespace SQL_Assignment1.Menus
{
    public class Intro
    {
        /// <summary>
        /// Displays a short semi animated intro. To make it look like some kind of interesting database.
        /// </summary>
        public static void SetUpMessage()
        {
            Console.CursorVisible = false;
            Console.Write("Setting up database");
            AnimatedText("...", 150);
            PauseLine();

            Console.Write("Populating database table");
            AnimatedText("...", 150);
            PauseLine();

            Console.Write("Feeding the server hamster");
            AnimatedText("...", 150);
            PauseLine();
            Console.WriteLine("Done!");
            System.Threading.Thread.Sleep(250);
            Console.Clear();
            Console.CursorVisible = true;
        }

        private static void PauseLine()
        {
            System.Threading.Thread.Sleep(150);
            Console.WriteLine();
        }
    }
}
