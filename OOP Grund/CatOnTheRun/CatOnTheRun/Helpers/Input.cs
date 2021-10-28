// -----------------------------------------------------------------------------------------------
//  Input.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CatOnTheRun.Extensions;

    internal static class Input
    {
        internal static int  GetInt(int min, int max)
        {
            var pos = Console.CursorTop;
            int choice = 0;
            while (choice < min || choice > max)
            {
                ClearLine(pos);
                Console.Write("=> ");
                choice = Console.ReadLine().Toint();
            }
            return choice;
        }

        private static void ClearLine(int pos)
        {
            Console.CursorTop = pos;
            Console.WriteLine(new String(' ', Console.WindowWidth));
            Console.CursorTop = pos;
        }

        internal static void Pause(string message= "[ Press ENTER to continue ]")
        {
            Console.WriteLine();
            var oneLiner = new OneLineMessage(message);
            oneLiner.Show();
            Console.ReadLine();
            oneLiner.Delete();
        }
    }
}
