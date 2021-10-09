// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace ShoppingLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = new string[]
            {
                "Mjölk", "Kattmat", "Bananer"
            };
            double[] prices = new double[]
            {
                17.30, 20, 26.95
            };

            double sum = 0;
            for (int count = 0; count < items.Length; count++)
            {
                Console.WriteLine(items[count] + " " + prices[count] + ":-");
                sum += prices[count];
            }
            Console.WriteLine("Summa: " + sum);
        }
    }
}
