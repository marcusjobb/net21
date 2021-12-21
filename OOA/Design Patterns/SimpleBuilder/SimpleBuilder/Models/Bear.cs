// -----------------------------------------------------------------------------------------------
//  Bear.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SimpleBuilder.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SimpleBuilder.Interface;

    internal class Bear : IPlushAnimal
    {
        public Bear() { } // Default constructor
        public Bear(Legs[] legs, Arms[] arms, Head head, Torso torso, string name, string color)
        {
            // Jobbig constructor
            Legs = legs;
            Arms = arms;
            Head = head;
            Torso = torso;
            Name = name;
            Color = color;
        }

        public Legs[] Legs { get; set; }
        public Arms[] Arms { get; set; }
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }

    // Bear without ear = B

    internal class Legs
    {
        public string Name { get; set; }
    }
    internal class Arms
    {
        public string Name { get; set; }
    }
    internal class Head
    {
        public string EyeColor { get; set; }
        public string MouthExpression { get; set; }
    }
    internal class Torso
    {
        public string Color { get; set; }
    }
}
