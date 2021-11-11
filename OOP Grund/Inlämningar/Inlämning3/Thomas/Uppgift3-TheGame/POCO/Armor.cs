// -----------------------------------------------------------------------------------------------
//  Armor.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{

    internal class Armor : Item
    {
        internal int Protection { get; set; } = 0;
        internal override int EffectiveValue => Protection;
    }
}
