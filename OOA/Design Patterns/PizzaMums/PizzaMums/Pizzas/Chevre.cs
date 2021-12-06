// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Chevre : Pizza
    {
        public Chevre()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> { "San Marzano Tomatsås", "Fior Di Latte", "Getost", "Lufttorkad Skinka (Alternativ Päron) Rucola", "Valnötter", "Honung" };
            IsFolded = false;
            Price = 149;
        }
    }
}