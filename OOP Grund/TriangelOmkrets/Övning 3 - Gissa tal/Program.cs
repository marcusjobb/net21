// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning_3___Gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            int counter = 0;
            bool gameOn = true;

            Console.WriteLine("Datorn tänker på ett tal mellan 0 och 99");
            while (gameOn)
            {
                Console.Write("Din gissning? ");
                string input = Console.ReadLine();
                int.TryParse(input, out int guess);
                counter++;
                if (guess < num)
                {
                    Console.WriteLine("Ditt tal är för litet");
                }
                else if (guess > num)
                {
                    Console.WriteLine("Ditt tal är för stort");
                }
                else
                {
                    Console.WriteLine("Du gissade rätt");
                    break;
                }
            }
            Console.WriteLine($"Du gissade rätt på {counter} försök");
        }
    }
}
