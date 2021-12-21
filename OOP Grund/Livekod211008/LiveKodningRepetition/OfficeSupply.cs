// -----------------------------------------------------------------------------------------------
//  OfficeSupply.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System.Collections.Generic;

    internal class Supply
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public override string ToString() => $"{Name} {Price}";
    }

    internal class Papers : Supply // base = supply
    {
        public int Size{ get; set; }
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

        internal void Start()
        {
            List<Supply> list = new List<Supply>();
            // Alla Supplies oavsett typ åker in i samma lista
            list.Add(new Papers { Name = "Post-its", Price = 13, Amount = 100 });
            list.Add(new PaperA4 { Name = "A4 packe", Price = 75, Amount = 500 });
            list.Add(new Toner { Name = "Epson svart toner", Price = 575, Amount = 2 });
            list.Add(new CoffeeMachine{ Name = "Phillips 154 Deluxe", Price = 4575, Amount = 3 });
        }
    }
}