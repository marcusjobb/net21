// -----------------------------------------------------------------------------------------------
//  Vego.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Vego:Pizza
    {
        public Vego()
        {
            Ingredients = new List<string> { "San marzano tomatsås", "Färsk mozzarella", "Grillad aubergine och zucchini", "Kronärtskocka", "Hyvlad parmesan" };
            IsFolded = false;
            Name = "Vego";
            Price = 120;
        }
    }
}
