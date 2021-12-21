// -----------------------------------------------------------------------------------------------
//  Weapon.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{

    internal class Weapon : Item
    {
        internal int Damage { get; set; } = 0;

        internal override int EffectiveValue => Damage;
    }
}
