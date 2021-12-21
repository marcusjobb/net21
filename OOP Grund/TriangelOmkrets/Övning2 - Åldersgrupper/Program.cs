// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning2___Åldersgrupper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du");
            string input = Console.ReadLine();
            int.TryParse(input, out var age);
            if (age > 14)
            {
                Console.WriteLine("Du får köra moped");
            }
            if (age > 17)
            {
                Console.WriteLine("Du får köra personbil");
            }
            if (age > 20)
            {
                Console.WriteLine("Du får köra tung lastbil");
            }
            if (age > 24)
            {
                Console.WriteLine("Du får köra buss");
            }
        }
    }
}
