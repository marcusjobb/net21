﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning2
{
    class Program
    {
        static void Main()
        {
            int value = 0;
            Console.Write("Ange ett värde:");
            string input = Console.ReadLine();
            int.TryParse(input, out value);
            Console.CursorTop = 10; // Rad 10
            do
            {
                Console.CursorLeft = value--; // Kolumn 10
                Console.Write("*");
                System.Threading.Thread.Sleep(100); // Paus
            } while (value > 0);
        }
    }
}
