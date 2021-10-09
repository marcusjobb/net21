﻿// -----------------------------------------------------------------------------------------------
//  WeirdForLoops.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace LiveKodningRepetition
{
    internal class WeirdForLoops
    {
        internal WeirdForLoops()
        {
        }

        internal void Start()
        {
            // For x = 1 to 10
            // Next

            //Console.WriteLine();
            //int x = 0;
            //for (; ; )
            //{
            //    if (x > 9) break;
            //    Console.Write($"{x} ");
            //}
            //Console.WriteLine();
            //int y= 5;
            //for(; y<10; x++) // evig loop för att x räknas, inte y
            //{
            //    Console.Write($"{y} ");
            //}

            bool check = true;
            int counter = 0;
            for (; check;)
            {
                if (counter++ > 10) check = false;
                Console.Write($"{counter} ");
            }

            Console.WriteLine("\n\n\n\n\n\n");

        }
    }
}