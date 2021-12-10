// -----------------------------------------------------------------------------------------------
//  Factory.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace SimpleFabric.Factories
{

    using SimpleFabric.Interfaces;
    using SimpleFabric.Models;
    internal static class Factory
    {
        public static IThing MakeAThing(string name)
        {
            IThing thing = null;

            thing = GetThing(name);

            return thing;
        }

        public static IThing MakeAnUglyThing(string name)
        {
            IThing thing = null;

            thing = GetThing("Ugly "+ name);

            return thing;
        }

        private static IThing GetThing(string name)
        {
            IThing thing;
            switch (name.Replace(" ", "").ToLower())
            {
                case "teddybear": thing = new Teddybear() { Name = name }; break;
                case "panda": thing = new Teddybear() { Name = name }; break;
                case "doll": thing = new Doll() { Name = name }; break;
                default: thing = new Thing() { Name = name }; break;
            }

            return thing;
        }

    }
}
