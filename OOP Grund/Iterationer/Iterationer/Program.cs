﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Iterationer
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            while (counter < 10)
            {
                counter++; // Öka räknare med 1

                //if (counter>10)
                //{
                //    break;
                //}

                if (counter == 4)
                {
                    continue;
                }

                Console.WriteLine(counter); // Skriv ut räknaren

            }

        }
    }
}
