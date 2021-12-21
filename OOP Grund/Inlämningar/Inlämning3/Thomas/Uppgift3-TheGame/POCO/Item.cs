// -----------------------------------------------------------------------------------------------
//  Item.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{


    internal class Item
    {
        internal string Name { get; set; }
        internal int Price { get; set; }

        internal virtual int EffectiveValue { get; }
        internal string[] FlavourTexts { get; set; } = new string[4];
    }
}
