﻿// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Carpaccio : Pizza
    {
        public Carpaccio()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San Marzano Tomatsås", "Fior Di Latte", "Marinerad Oxfilé", "Pesto", "Rucola", "Hyvlad Parmesan" };
            IsFolded = false;
            Price = 149;
        }
    }
}