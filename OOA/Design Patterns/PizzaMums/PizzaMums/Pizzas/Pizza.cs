﻿// -----------------------------------------------------------------------------------------------
//  Pizza.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    using PizzaMums.Interfaces;

    internal class Pizza : IPizza
    {
        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public bool IsFolded { get; set; }
        public int Price { get; set; }

        public Pizza()
        {
            Name = "Snålpizza";
            Ingredients = new List<string> { "Tomatsås", "Ost" };
            IsFolded = false;
            Price = 65;
        }
    }
}