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
