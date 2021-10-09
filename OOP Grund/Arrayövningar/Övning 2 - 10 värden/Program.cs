// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Övning_2___10_värden
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // -------------------------------------------------------------------
            // definiera gränsvärden
            // const gör att talen inte går att ändra under programmets gång
            // -------------------------------------------------------------------
            const int MaxNumbers = 10;
            const int MaxValue = 50;
            // Instansiera randomizer
            Random rnd = new();

            // deklarera och instansiera arrayen
            int[] slump = new int[MaxNumbers];

            // -------------------------------------------------------------------
            // Loop för att fylla i arrayen med tal
            // -------------------------------------------------------------------
            for (int genRand = 0; genRand < MaxNumbers; genRand++)
            {
                slump[genRand] = rnd.Next(0, MaxValue); // Slumptal mellan 0 och 49
            }

            // -------------------------------------------------------------------
            // Summera talen
            // -------------------------------------------------------------------
            int sum = 0;
            for (int i = 0; i < MaxNumbers; i++)
            {
                sum += slump[i];
            }

            // -------------------------------------------------------------------
            // Sortera talen
            // -------------------------------------------------------------------
            Array.Sort(slump);

            // -------------------------------------------------------------------
            // Skriv ut talen
            // -------------------------------------------------------------------
            Console.WriteLine("Talen");
            for (int i = 0; i < MaxNumbers; i++)
            {
                Console.Write(slump[i] + " ");
            }
            Console.WriteLine();

            // -------------------------------------------------------------------
            // Skriv ut beräkningar
            // -------------------------------------------------------------------
            Console.WriteLine("Summa : " + sum);
            Console.WriteLine("Medel : " + sum / MaxNumbers);
        }
    }
}