// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_Vecka2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett heltal");
            int.TryParse(Console.ReadLine(), out int number);

            //      räknare    villkor för att köra   förändring
            for (int counterY = 0; counterY < number; counterY++)
            {

                for (int counterX = 0; counterX < number * 2; counterX++)
                {
                    if (counterX % 2 == 0)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }

                Console.WriteLine("*");
            }
        }
    }
}
