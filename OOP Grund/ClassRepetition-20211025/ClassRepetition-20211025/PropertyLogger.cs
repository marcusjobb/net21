// -----------------------------------------------------------------------------------------------
//  PropertyLogger.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ClassRepetition_20211025
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PropertyLogger
    {
        private string name;

        public string Name
        {
            get => name;
            set { 
                if (name!= value) {
                    Console.WriteLine($"Namn ändrades från {name} till {value}");
                    name = value;
                }
            }
        }
    }
}
