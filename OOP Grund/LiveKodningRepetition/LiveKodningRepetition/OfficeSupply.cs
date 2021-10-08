// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;

    internal class Supply
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString() => $"{Name} {Price}";
    }

    internal class Papers : Supply // base = supply
    {
        public int Size { get; set; }
    }

    internal class PaperA4 : Papers // base = papers
    {
        public string Label { get; set; }
        public override string ToString() => base.ToString();
    }

    internal class Toner : Supply // base = supply
    {
        public string Color { get; set; }
    }
    internal class CoffeeMachine : Supply// base = supply
    {
        public string Color { get; set; }
        public int Litres { get; set; }
    }

    internal class OfficeSupply
    {
        public OfficeSupply()
        {
        }

        internal void Start()
        {

        }
    }
}