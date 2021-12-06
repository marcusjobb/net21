// -----------------------------------------------------------------------------------------------
//  Pizza.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
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

    internal class Pizza : IPizza
    {
        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public bool IsFolded { get; set; }
        public int Price { get; set; }
    }
}
