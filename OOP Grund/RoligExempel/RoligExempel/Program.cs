// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace RoligExempel
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string message = "Leta efter något positivt varje dag, även om du behöver leta lite extra mycket vissa dagar.";
            Console.WriteLine(message);

            int[] acode = { 50, 3, 84, 76, 11, 84, 2, 9, 76, 23, 61, 20, 87, 4, 50, 1, 56, 13 };
            foreach (var position in acode)
            {
                Console.Write(message[position]);
            }

        }
    }
}
