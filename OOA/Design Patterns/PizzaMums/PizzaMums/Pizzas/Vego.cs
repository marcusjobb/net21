﻿// -----------------------------------------------------------------------------------------------
//  Vego.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Vego : Pizza
    {
        public Vego()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San marzano tomatsås", "Färsk mozzarella", "Grillad aubergine och zucchini", "Kronärtskocka", "Hyvlad parmesan" };
            IsFolded = false;
            Price = 135;
        }
    }
}