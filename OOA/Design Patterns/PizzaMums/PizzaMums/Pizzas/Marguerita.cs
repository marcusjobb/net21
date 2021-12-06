﻿// -----------------------------------------------------------------------------------------------
//  Marguerita.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Marguerita : Pizza
    {
        public Marguerita()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San marzano tomatsås", "Mozzarella toppad med basilika" };
            IsFolded = false;
            Price = 120;
        }
    }
}