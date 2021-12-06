// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Pizzas
{
    using System.Collections.Generic;

    internal class Parma : Pizza
    {
        public Parma()
        {
            Name = this.GetType().Name;
            Ingredients = new List<string> {"San Marzano Tomatsås","Fior Di Latte","Lufttorkad Skinka","Körsbärstomater","Oliver Och Pesto"};
            IsFolded = false;
            Price = 150;
        }
    }
}