using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static The_Game.PlayerClass;
using static The_Game.HelperClass;
using static The_Game.MonsterClass;
namespace The_Game
{
    class Adventure
    {
        public void AdventureStart()
        {
            monster.Level = player.Level;
            if (player.Level >= 1 && player.Level <= 3)
                GenerateWeakMonster();
            else if (player.Level >= 4 && player.Level <= 7)
                GenerateNormalMonster();
            else
                GenerateStrongMonster();

            Write($"You ran into a level {monster.Level} {monster.Name}");
            Write("Press any key to engage combat");
            Console.ReadKey();
            Console.Clear();
            AdventureFight();
        }
        public static void AdventureFight()
        {
            while (player.HP > 0 && monster.HP > 0)
            {
                Write($"{player.Name} hit {monster.Name} and dealt {player.Strength} damage.");
                monster.HP -= player.Strength;
                Write($"{monster.Name} has {monster.HP} HP left");
                Console.WriteLine();
                Write($"{monster.Name} attacked {player.Name} back and dealt {monster.Strength} damage.");
                player.HP -= monster.Strength;
                Write($"{player.Name} has {player.HP} HP left");
                Console.WriteLine();
                Write("Press any key to continue combat");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void PlayerDead()
        {
            Write($"{player.Name} HP reached 0. Game Over!");
        }
        public void MonsterDead()
        {
            Write($"You defeated the monster and gained {monster.ExpDrop} exp!");
            Console.WriteLine();
            player.Exp += monster.ExpDrop;
            LevelUpCheck();
        }
    }
}
