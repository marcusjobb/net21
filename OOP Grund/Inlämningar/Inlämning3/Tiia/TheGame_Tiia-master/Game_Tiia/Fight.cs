using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tiia
{
    class Fight
    {
        public static void AttackMonster(Player player, Monster monster) //Själva slagsmålet
        {
            Randomizer(player, out int damageGiven, out int damageGiven2, out int damageTaken, out int damageTaken2);

            var damageToMonster = damageGiven + player.Strenght; //så att man slipper att skriva funktionen varje gång
            var damageToMonster2 = damageGiven2 + player.Strenght;
            var damageToPlayer = damageTaken - player.Toughness;
            var damageToPlayer2 = damageTaken2 - player.Toughness;

            Check.ShowHp(player, monster);

            while (monster.Hp >= 0)
            {
                Random rnd = new Random();
                var fightScenario = rnd.Next(1, 5);

                switch (fightScenario) //FUNGERAR INTE SOM DET SKA
                {
                    case 1: FightScenario.LongerFight(player, monster, damageGiven, damageGiven2, damageTaken, damageTaken2); break;
                    default: FightScenario.BasicFight(player, monster, damageGiven, damageGiven2, damageTaken, damageTaken2); break;
                }                

                Check.ShowHp(player, monster);

                Check.EnterToContinue();
                Check.CheckLevel(player);
                Console.Clear();
            }
        }

        private static void Randomizer(Player player, out int damageGiven, out int damageGiven2, out int damageTaken, out int damageTaken2)
        {
            Random rnd = new Random();
            damageGiven = rnd.Next(player.Strenght, player.Strenght * 2);
            damageGiven2 = rnd.Next(player.Strenght, player.Strenght * 2);
            damageTaken = rnd.Next(player.Strenght, player.Strenght * 2);
            damageTaken2 = rnd.Next(player.Strenght, player.Strenght * 2);
        }
    }
}

