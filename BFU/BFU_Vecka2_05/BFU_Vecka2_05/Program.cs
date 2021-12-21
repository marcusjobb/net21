// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_Vecka2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //a.Skapa två stycken lika långa arrayer. Den första ska innehålla namnet på olika produkter
            //i en användares inköpslista (t.ex ”Mjölk”, ”Bröd”, ”Ost”), och den andra ska innehålla
            //priserna för motsvarande produkt (t.ex. 14.50, 22.95, 89,90).

            string[] products = { "Mjölk", "Bröd", "Ost" };
            double[] prices = { 14.50, 22.95, 89.00 };
            double sum = 0;
            //b. Skapa en loop som skriver ut namnet varje produkt på vår inköpslista.
            //c. Lägg i loopen så att även priset skrivs ut efter namnet.
            for (int prod = 0; prod < products.Length; prod++)
            {
                Console.WriteLine(products[prod] + "\t\t" + prices[prod]);
                sum += prices[prod];
            }
            //d. Skriv ut den sammanlagda kostnaden för alla produkter i våra listor.
            Console.WriteLine($"Summa: {sum}");
            //e. Skriv även ut genomsnittspriset för alla produkter i listan (avrunda gärna till två
            //decimaler).
            Console.WriteLine($"Genomsnittspris: {sum / products.Length}");

        }
    }
}
