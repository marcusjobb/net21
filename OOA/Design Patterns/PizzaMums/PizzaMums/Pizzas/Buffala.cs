﻿// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Buffala : Pizza
    {
        public Buffala()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San marzano tomatsås", "Buffelmozarella DOP", "Körsbärstomater", "Basilika", "Olivolja extra vergine." };
            IsFolded = false;
            Price = 149;
        }
    }
}