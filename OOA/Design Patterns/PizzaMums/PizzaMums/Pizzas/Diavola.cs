// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Xml.Linq;

    internal class Diavola : Pizza
    {
        public Diavola()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San marzano tomatsås", "Fior di latte", "Fänkålssalami", "Chiliolja med lagom hetta." };
            IsFolded = false;
            Price = 149;
        }
    }
}