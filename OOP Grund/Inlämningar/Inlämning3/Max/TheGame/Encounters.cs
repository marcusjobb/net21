using System;
using System.Collections.Generic;

namespace TheGame
{
    class Encounters //Methods for deciding encounters and stats for enemies
    {
        static int EncounterChance()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 101);
            return chance;
        }

        public static void EncounterDecider()
        {
            switch (EncounterChance())
            {
                case <= 10:
                    EncounterGrass();
                    break;
                case > 10:
                    if (Check.Boss() == false) { EncounterSlime(); Menu.BattleMenu(); }
                    else { EncounterKingSlime(); Menu.BattleMenu(); }
                    break;
            }
        }

        static void EncounterGrass()
        {
            switch (EncounterChance())
            {
                case <= 30:
                    Console.WriteLine("You found some gold!");
                    Check.GoldGet();
                    break;
                case > 30:
                    Console.WriteLine("You found nothing.");
                    break;
            }
        }

        public static void EncounterSlime()
        {           
            Slime.stats.LVL = Check.NegativeStat(Player.stats.LVL + Slime.StatRange());
            
            Slime.stats.MaxHP = Check.NegativeStat(Player.stats.MaxHP + Slime.StatRange());

            Slime.stats.HP = Slime.stats.MaxHP;
            
            Slime.stats.ATK = Check.NegativeStat(Player.stats.ATK + Slime.StatRange());

            Slime.stats.DEF = Check.NegativeStat(Player.stats.DEF + Slime.StatRange());

            string text = "│ You encounter a slime!    (°. º) │";
            int length = text.Length;

            Box.Roof(length);
            Pretty.TextWithColor("│ You encounter a ", "Green", "slime", "!    ");
            Pretty.TextWithColor("", "Green", "(°. º)", " │\n");

            Box.Floor(length);
        }

        public static void EncounterKingSlime()
        {
            KingSlime.stats.MaxHP = Slime.stats.MaxHP * 2;
            KingSlime.stats.HP = KingSlime.stats.MaxHP;
            KingSlime.stats.ATK = Slime.stats.ATK * 2;
            KingSlime.stats.DEF = Slime.stats.DEF;


            
                string text = "│ You encounter the King Slime!    (°. º) │";
            int length = text.Length;

            Box.Roof(length);
            Pretty.TextWithColor("│                                    ", "Yellow", "NN","   │\n");
            Pretty.TextWithColor("│ You encounter the ", "Green", "Slime King", "!    ");
            Pretty.TextWithColor("", "Green", "(°. º)", " │\n");

            Box.Floor(length);
        }
    }
}
