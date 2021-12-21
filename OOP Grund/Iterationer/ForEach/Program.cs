// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main()
        {
            List<string> name = new()
            {
                "Batman",
                "Robin",
                "Catwoman",
                "The Joker",
            };
            name.Add("Poison ivy");

            Console.WriteLine(name[0]);

            foreach (string hero in name)
            {
                Console.WriteLine(hero);
            }
        }
    }
}
