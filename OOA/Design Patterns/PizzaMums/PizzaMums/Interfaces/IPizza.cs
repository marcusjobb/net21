// -----------------------------------------------------------------------------------------------
//  IPizza.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace PizzaMums.Interfaces
{
    using System.Collections.Generic;

    internal interface IPizza
    {
        List<string> Ingredients { get; set; }
        string Name { get; set; }
        bool IsFolded { get; set; }
        int Price { get; set; }
    }
}