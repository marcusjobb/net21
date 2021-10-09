// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace Initianls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();

            string initial = $"{name[0]}";



            // Tom Marvolo Riddle

            int space = 0;
            while (space >= 0)
            {
                space = name.IndexOf(' ', space);
                if (space > 0)
                {
                    space++;
                    initial += name[space];
                }
            }
            Console.WriteLine(initial);
        }
    }
}
