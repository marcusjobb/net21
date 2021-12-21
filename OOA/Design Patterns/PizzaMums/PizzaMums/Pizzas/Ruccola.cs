// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Ruccola : Pizza
    {
        public Ruccola()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San Marzano Tomatsås", "Fior Di Latte", "Lufttorkad Skinka", "Färsk Rucola" };
            IsFolded = false;
            Price = 150;
        }
    }
}