﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning3
{
    class Program
    {
        static void Main()
        {
            int value = 0;
            int sum = 0;
            Console.Write("Ange ett värde:");
            string input = Console.ReadLine();
            int.TryParse(input, out value);

            for (int iteration = 0; iteration < value; iteration++)
            {
                sum += value;
            }
            Console.WriteLine("Summan är :" + sum);

        }
    }
}
