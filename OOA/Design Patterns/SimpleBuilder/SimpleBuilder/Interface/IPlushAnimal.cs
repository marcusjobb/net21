// -----------------------------------------------------------------------------------------------
//  IAnimal.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SimpleBuilder.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SimpleBuilder.Models;
    internal interface IPlushAnimal
    {
        Legs[] Legs { get; set; }
        Arms[] Arms { get; set; }
        Head Head { get; set; }
        Torso Torso { get; set; }
        string Color { get; set; }
        string Name { get; set; }

    }
}
