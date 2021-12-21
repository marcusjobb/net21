// -----------------------------------------------------------------------------------------------
//  Thing.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SimpleFabric.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SimpleFabric.Interfaces;
    /// <summary>
    /// Random thingy
    /// </summary>
    internal class Thing : IThing
    {
        public string Name { get; set; } = ""; // <-- Tom sträng annars blir det null
    }
    /// <summary>
    /// Bear model
    /// </summary>
    internal class Teddybear : IThing
    {
        public string Name { get; set; } = ""; // <-- Tom sträng annars blir det null
    }
    /// <summary>
    /// Doll model
    /// </summary>
    internal class Doll : IThing
    {
        public string Name { get; set; } = ""; // <-- Tom sträng annars blir det null
    }
}
