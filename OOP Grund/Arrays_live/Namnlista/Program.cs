// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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
