// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

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