// -----------------------------------------------------------------------------------------------
//  Equipment.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{
    using System.Collections.Generic;

    internal static class Equipment
    {
        #region Weapons
        internal static Weapon Fists = new()
        {
            Name = "Fists",
            Damage = 0,
            Price = 0,
            FlavourTexts = new string[4]
            {
                "punch for",
                "hit the enemy where it really hurts for",
                "tickle the enemy for",
                "punch a big hole in the air for"
            }
        };
        internal static Weapon Stick = new()
        {
            Name = "Stick",
            Damage = 5,
            Price = 5,
            FlavourTexts = new string[4]
            {
                "thwack the enemy with your stick for",
                "poke the enemy in the eye with your stick, painfully doing",
                "poke the enemy ineffectually with you stick, scratching it for",
                "hit the ground beside the enemy with your stick for a total of"
            }
        };
        internal static Weapon Dagger = new()
        {
            Name = "Dagger",
            Damage = 10,
            Price = 50,
            FlavourTexts = new string[4]
            {
                "stick the enemy with your dagger for",
                "stab the enemy in its vunerables with your dagger, doing",
                "scratch the enemy with your dagger for",
                "drop your dagger to the ground, doing"
            }
        };
        internal static Weapon Sword = new()
        {
            Name = "Sword",
            Damage = 15,
            Price = 100,
            FlavourTexts = new string[4]
            {
                "swing your sword and hit for",
                "strike a flurry of blows with your sword, inflicting",
                "grimace as your sword glances off the enemy, doing",
                "try to juggle your sword, managing to do"
            }
        };
        internal static Weapon GreatAxe = new()
        {
            Name = "Great Axe",
            Damage = 20,
            Price = 200,
            FlavourTexts = new string[4]
            {
                "swing your great axe and hit for",
                "make a mighty swing with your great axe and brutally hit for",
                "barely manage to connect with your great axe, doing",
                "manage to miss your toe with your great axe, inflicting"
            }
        };
        internal static Weapon MagicSword = new()
        {
            Name = "Magic Sword of Doom",
            Damage = 40,
            Price = 500,
            FlavourTexts = new string[4]
            {
                "swing your glowing sword and hit, doing",
                "strike a migthy blow, your sword crackling with energy, and hit, inflicting",
                "swing but the light in your sword fades and you hit weakly for",
                "realize that your sword might have a mind of it's own as it twists in your hand and misses, doing"
            },
        };

        internal static List<Weapon> WeaponsList = new() { Stick, Dagger, Sword, GreatAxe, MagicSword };

        #endregion Weapons
        #region Armor
        internal static Armor BirthdaySuit = new()
        {
            Name = "Birthday suit",
            Protection = 0,
            Price = 0,
            FlavourTexts = new string[4]
            {
                "avoid the worst of the hit and dodge",
                "nimbly dodge out of the way and avoid",
                "stumble but manage to block",
                "fall on your face and block"
            }
        };
        internal static Armor Cloth = new()
        {
            Name = "Cloth coverings",
            Protection = 5,
            Price = 5,
            FlavourTexts = new string[4]
            {
                "move out of the way and avoid",
                "tangle the enemy's attack with your cloth and blunts its force with",
                "stumble on a loose piece of cloth but manage to avoid",
                "realize you shouldn't have wrapped yourself as a mummy when you block"
            }
        };
        internal static Armor Leather = new()
        {
            Name = "Leather armor",
            Protection = 10,
            Price = 50,
            FlavourTexts = new string[4]
            {
                "dodge of the way and avoid",
                "sigh in relief as your enemy's attack scrape along your leathers and you block",
                "misjudge your enemy's speed but manage to avoid",
                "fall straight into the incoming attack and block"
            }
        };
        internal static Armor Chainmail = new()
        {
            Name = "Chainmail armor",
            Protection = 15,
            Price = 100,
            FlavourTexts = new string[4]
            {
                 "skillfully block",
                 "critically block",
                 "stumble but manage to block",
                 "trip over your own feet and block"
            }
        };
        internal static Armor Plate = new()
        {
            Name = "Plate armor",
            Protection = 20,
            Price = 200,
            FlavourTexts = new string[4]
            {
                 "utilize your plate armor and let it absorb",
                 "expertly twist out of the way, your plate armor blocking",
                 "are hindered by the weight of your plate armor but it still blocks",
                 "are blinded by your helmet, maybe try putting it on the other way? You avoid"
            }
        };
        internal static Armor PowerArmor = new()
        {
            Name = "Power armor",
            Protection = 40,
            Price = 500,
            FlavourTexts = new string[4]
            {
                 "grin as the mystical energies imbued in your armor block",
                 "laugh at your enemy as a mystic force reaches out and almost halts the incoming attack, blocking",
                 "stumble but still absorb",
                 "feel like you want to cry when the mystical energies in your armor winks out and absorbs"
            }
        };
        internal static List<Armor> ArmorList = new() { Cloth, Leather, Chainmail, Plate, PowerArmor };
        #endregion Armor
        internal static List<Item> EquipmentList = new() { Stick, Dagger, Sword, GreatAxe, MagicSword, Cloth, Leather, Chainmail, Plate, PowerArmor };
        internal static Armor BossArmor = new()
        {
            Name = "Boss armor",
            Protection = 40,
            Price = 500,
            FlavourTexts = new string[4]
            {
                 "expertly parries your blow, blocking",
                 "almost disarms you with and amazing parry, blocking",
                 "looks pained as you find a chink in his defenses, only blocking",
                 "is completly suprised by your attack, avoiding a grand total of"
            }
        };
        internal static Weapon BossWeapon = new()
        {
            Name = "Boss sword",
            Damage = 40,
            Price = 500,
            FlavourTexts = new string[4]
            {
                "grins wickedly as his flaming swords bites into you for",
                "yells triumphantly as he proceeds to carve you up with his flaming sword, inflicting",
                "grimaces as he misjudges his blow and only does",
                "is blinded by your awesomeness and does"
            }
        };
    }
}
