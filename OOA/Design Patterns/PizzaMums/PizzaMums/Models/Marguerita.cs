﻿// -----------------------------------------------------------------------------------------------
//  Marguerita.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PizzaMums.Interfaces;

    internal class Marguerita : Pizza
    {
        public Marguerita()
        {
            Ingredients = new List<string> { "San marzano tomatsås", "Mozzarella toppad med basilika" };
            IsFolded = false;
            Name = "Margarita";
            Price = 120;
        }
    }
}
