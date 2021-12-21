// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_Vecka2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                { 0,0,0,1,0,0,0 },
                { 0,1,1,0,1,1,0 },
                { 0,0,0,1,0,0,0 },
                { 0,0,0,1,0,0,0 },
            };
            for (int y = 0; y <= array.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= array.GetUpperBound(1); x++)
                {
                    if (array[y, x] == 0)
                        Console.Write('.');
                    else
                        Console.Write('*');
                }
                Console.WriteLine();
            }

        }
    }
}
