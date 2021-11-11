// -----------------------------------------------------------------------------------------------
//  PrintHelpers.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.Helpers
{
    using System;
    using System.Threading;

    internal static class PrintHelpers
    {
        private static readonly ConsoleColor background = ConsoleColor.Black;
        private static readonly ConsoleColor foreground = ConsoleColor.Gray;
        internal static void DramaticPrint(string msg)
        {
            Console.CursorVisible = false;
            Console.Write(msg);
            for (var i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine();
        }
        internal static void PrintAndHold(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Press any key to continue.");
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }
        internal static void Hold()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }
        internal static void BorderPrint(string msg, bool holdAtEnd = true)
        {
            Console.WriteLine($"╔{new string('═', msg.Length + 2)}╗");
            Console.WriteLine($"║ {msg} ║");
            Console.WriteLine($"╚{new string('═', msg.Length + 2)}╝");
            if (holdAtEnd)
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
        }
        internal static void BorderPrint(string[] msg, bool holdAtEnd = true)
        {
            var width = 0;
            foreach (var line in msg)
            {
                if (line.Length + 2 > width) width = line.Length + 2;
            }
            Console.WriteLine($"╔{new string('═', width + 2)}╗");
            foreach (var line in msg)
            {
                Console.WriteLine($"║ {line.PadRight(width)} ║");
            }
            Console.WriteLine($"╚{new string('═', width + 2)}╝");
            if (holdAtEnd)
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }
        }
        internal static void ThinBorderPrint(string msg)
        {
            //┌┐┘└│─
            Console.WriteLine($"┌{new string('─', msg.Length + 2)}┐");
            Console.WriteLine($"│ {msg} │");
            Console.WriteLine($"└{new string('─', msg.Length + 2)}┘");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }
        internal static void CombatRoundPrint(int round)
        {
            //┌┐└┘─┤├
            Console.WriteLine($"           ┌────────┐");
            Console.WriteLine($"───────────┤Round{round,3}├───────────────────────────────────────────────────");
            Console.WriteLine($"           └────────┘");
        }
        internal static void InvertColors()
        {
            Console.ForegroundColor = background;
            Console.BackgroundColor = foreground;
        }

        internal static void SetColors()
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }
    }
}
