// -----------------------------------------------------------------------------------------------
//  MenuDisplayer.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CatOnTheRun.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class NiceText
    {
        public static void Title(string text)
        {
            Console.WriteLine("...::: " + text+ " :::...");
            Console.WriteLine();
        }

        internal static void ShowStory(string title, string story)
        {
            Title(title);
            Console.WriteLine(story);
        }
    }
}
