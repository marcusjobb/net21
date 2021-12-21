// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Övning_5___Namnlista
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // -------------------------------------------------------------------
            // skapa en lista med 10 namn
            // -------------------------------------------------------------------
            string[] residentEvil = new string[10]
            {
                "Chris Redfield",
                "Jill Valentine",
                "Albert Wesker",
                "Rebecca Chambers",
                "Leon Scott Kennedy",
                "Claire Redfield",
                "Ada Wong",
                "Billy Coen",
                "Jake Muller",
                "Alice",
            };

            // -------------------------------------------------------------------
            // Skriv ut listan
            // -------------------------------------------------------------------
            foreach (var hero in residentEvil)
            {
                Console.WriteLine(hero);
            }

            // -------------------------------------------------------------------
            // Sortera listan
            // -------------------------------------------------------------------
            Array.Sort(residentEvil);

            // -------------------------------------------------------------------
            // tomrad som separator från förra listan som skrev ut
            // -------------------------------------------------------------------
            Console.WriteLine();

            // -------------------------------------------------------------------
            // Skriv ut listan
            // -------------------------------------------------------------------
            foreach (var hero in residentEvil)
            {
                Console.WriteLine(hero);
            }
        }
    }
}