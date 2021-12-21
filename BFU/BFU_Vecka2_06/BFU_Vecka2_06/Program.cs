// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace BFU_Vecka2_06
{
    class Program
    {
        class Product
        {
            public string Name;
            public double Price;

            public override string ToString()
            {
                return Name + " - " + Price + "kr";
            }
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Mjölk", Price =14.50},
                new Product { Name = "Bröd", Price = 22.95},
                new Product { Name = "Ost", Price = 89.90}
            };

            double sum = 0;
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
                sum += product.Price;
            }

            Console.WriteLine($"Summan: {Math.Round(sum, 2)}");
            Console.WriteLine($"Geomsnittlig pris: {Math.Round(sum / products.Count, 2)}");
        }
    }
}
