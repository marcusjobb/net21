// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_Vecka2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bruce", "Clark", "Vincent" };

            for (int i = 0; i < names.Length; i++)
            {
                for (int l = 0; l < names[i].Length; l++)
                {
                    Console.Write(" " + names[i][l] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
