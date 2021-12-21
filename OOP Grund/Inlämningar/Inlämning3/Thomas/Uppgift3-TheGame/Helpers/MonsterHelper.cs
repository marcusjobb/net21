// -----------------------------------------------------------------------------------------------
//  MonsterHelper.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.Helpers
{
    using System;

    internal static class MonsterHelper
    {
        private static Random rng = new();
        internal static void RandomizeMonster(Monster mob)
        {
            string[] prefix =
            {
                "Rampaging", "Sneaking", "Oddly-looking", "Holy", "Wandering","Skulking","Marauding","Crusading",
                "Exploring","Maze-mapping","Pious","Crazy","Angry","Sad-looking"
            };
            string[] className =
            {
                "Rogue", "Warrior","Paladin","Wizard","Priest","Tourist","Elf","Halfling","Dwarf","Vampire","Ranger",
                "Sous-chef","Janitor","Pizza delivery guy","Cleric","Druid"
            };
            string[] suffix =
            {
                "the Mad","the Holy","the Berserker","the Chosen One","the Crazy","the Monster Slayer","the Strong",
                "the Cowardly","the Farsighted", "the Silent Hunter","who forgets the Beer","the Mighty"
            };
            string[] name =
            {
                "Artemis","Bertram", "Charlene","Devon","Elric","Froro","Gandulf","Hemingway","Ivan","Joar","Kallé","Lama",
                "Morrow","Nisse","Oliphant","Petrus","Quentin","Romeo","Sierra","Tord","Ulvar","Vanilj","Whodunnit","Xerxes",
                "Yrrol","Zentharim"
            };

            mob.Name = name[rng.Next(0, name.Length)];
            mob.Prefix = prefix[rng.Next(0, prefix.Length)];
            mob.Class = className[rng.Next(0, className.Length)];
            mob.Suffix = suffix[rng.Next(0, suffix.Length)];
        }
    }
}
