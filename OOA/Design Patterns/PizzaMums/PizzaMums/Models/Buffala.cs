// -----------------------------------------------------------------------------------------------
//  Buffala.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Intrinsics.Arm;
    using System.Text;
    using System.Threading.Tasks;

    internal class Buffala : Pizza
    {
        public Buffala()
        {
            Ingredients = new List<string> { "San marzano tomatsås", "Buffelmozarella DOP", "Körsbärstomater", "Basilika", "Olivolja extra vergine." };
            IsFolded = false;
            Name = "Buffala";
            Price = 149;
        }
    }
}
