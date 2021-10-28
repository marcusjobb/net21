// -----------------------------------------------------------------------------------------------
//  INameAble.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace InterfaceFiltrering
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface INameAble
    {
        public string Name { get; set; } // Namn är ett krav!
    }

    internal interface IAgeAble
    {
        public int Age { get; set; } // Ålder är ett krav!
    }

    internal interface INameAge:INameAble, IAgeAble
    {

    }
}
