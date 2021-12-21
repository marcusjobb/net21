// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace RandomExempel
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Slumpgenerator");

                for (int i = 0; i < 10; i++)
                {
                    int slump = random.Next(0, 100);
                    Console.WriteLine(slump);
                }
                Console.ReadLine(); // Paus

            }
        }
    }
}
