// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace TriangelOmkrets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            while (true)
            {
                Console.Write("Ange sida A :");
                string sidaA = Console.ReadLine();
                Console.Write("Ange sida B :");
                string sidaB = Console.ReadLine();
                Console.Write("Ange sida C :");
                string sidaC = Console.ReadLine();

                bool funkarA = int.TryParse(sidaA, out a);
                bool funkarB = int.TryParse(sidaB, out b);
                bool funkarC = int.TryParse(sidaC, out c);

                //TODO: Snygga upp koden
                bool positiveA = a >= 0;
                bool positiveB = b >= 0;
                bool positiveC = c >= 0;

                if (funkarA && funkarB && funkarC)
                {
                    if (positiveA && positiveB && positiveC)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Du angav ett negativt tal");
                    }
                }
                else
                {
                    Console.WriteLine("Du angav något annat än siffor");
                }
            }

            int omkrets = a + b + c;
            Console.WriteLine($"Omkretsen är {omkrets}");
        }
    }
}
