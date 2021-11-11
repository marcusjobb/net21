// -----------------------------------------------------------------------------------------------
//  Item.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
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
