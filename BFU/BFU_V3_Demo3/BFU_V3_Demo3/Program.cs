// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_V3_Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            SägHej();
            SägHej(4);
            SägHej("BFU");

        }

        private static void SägHej(int antal)
        {
            for (int i = 0; i < antal; i++)
            {
                SägHej();
            }
        }

        private static void SägHej()
        {
            Console.WriteLine("Hej!");
        }
        private static void SägHej(string namn)
        {
            Console.WriteLine($"Hej {namn}!");
        }

    }
}
