// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace Namnlista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Bruce Wayne",
                "Clark Kent",
                "Oliver x",
                "Peter Parker",
                "Kit Walker"
            };

            // Sortera namnen i listan
            Array.Sort(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
