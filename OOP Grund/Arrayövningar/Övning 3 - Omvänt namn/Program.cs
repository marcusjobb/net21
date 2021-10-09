// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Övning_3___Omvänt_namn
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // -------------------------------------------------------------------
            // Fråga efter namn
            // -------------------------------------------------------------------
            Console.WriteLine("Vad heter du?");
            string input = Console.ReadLine().Trim();
            string reverse = "";

            // -------------------------------------------------------------------
            // loopa bokstäverna baklänges och lägg till i nya strängen
            // -------------------------------------------------------------------
            for (int letters = input.Length - 1; letters >= 0; letters--)
            {
                reverse += input[letters];
            }

            // -------------------------------------------------------------------
            // Skriv ut resultatet
            // -------------------------------------------------------------------
            Console.WriteLine(reverse);
        }
    }
}