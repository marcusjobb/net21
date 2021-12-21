// -----------------------------------------------------------------------------------------------
//  INameAble.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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
