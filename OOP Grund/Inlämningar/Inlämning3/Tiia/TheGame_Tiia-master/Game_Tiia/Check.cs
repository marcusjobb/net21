using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Tiia
{
    class Check //en klass för att kontrollera och visa input och annat från användaren
    {
        public static void CheckLevel(Player player) //spelaren uppnår en ny level när exp=100 och får 200 hp
        {
            if (player.Exp >= 100)
            {
                player.Level++;
                player.Exp = 0;
                player.Hp = 200;
                player.Strenght++;
                Visual.ChangeToCyan();
                Console.Write("\nLEVEL UP! ");
                Console.ResetColor();
                Console.Write("You are now on level ");
                Visual.ChangeToCyan();
                Console.WriteLine($"{player.Level}");
                Console.ResetColor();
                PressEnter();
                Console.Clear();
            }
            else if (player.Level == 10)
            {
                while (true)
                {
                    Visual.ChangeToCyan();
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Thread.Sleep(100);
                    Console.WriteLine("\n*.*.*. Congratulations!! You won The Game!.*.*.*");
                }
            }
        }

        public static void PressEnter()
        {
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void EnterToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n[Press enter to continue]");
            Console.ResetColor();
            Console.ReadKey();
        }

            public static string DoYouWantToContinue()
        {
            Console.Write("\nDo you want to continue the adventure? y/n ");
            var input = Console.ReadLine().ToLower();
            return input;
        }

        public static void ShowHp(Player player, Monster monster) //visar HP på både spelare och monstret
        {
            Console.WriteLine($"\n\t{player.Name}: {player.Hp} hp |VS| {monster.Name}: {monster.Hp} hp ");
            Console.WriteLine("\t═════════════════════════════");

        }

        public static void ShowStats(Player player)
        {
            Visual.BlueLine();
            Console.WriteLine($"Level     : {player.Level}");
            Console.WriteLine($"Exp       : {player.Exp} exp");
            Console.WriteLine($"Hp        : {player.Hp} hp");
            Console.Write($"Gold      : {player.Gold}");
            Visual.BlueLine();
        }

        public static void MonsterKilled(Monster monster)
        {
            Console.Clear();
            monster.Hp = 0;
            Visual.ChangeToMagenta();
            Menu.Victory();

            Console.ResetColor();
            Console.WriteLine($"\nYou killed the monster and gained {monster.ExpGiven} exp.");
        }

        public static void GameOver(Player player)
        {
            Console.Clear();
            Visual.ChangeToCyan();

            Menu.GameOver();
            Console.ResetColor();

            Console.WriteLine("\nYou fought bravely but that wasn't enough... you were KILLED by the monster!");
            Respawn(player);
        }

        private static void Respawn(Player player) //ger en till chans till spelaren, men inte helt gratis ;)
        {
            Console.WriteLine("Do you want to respawn? (cost: all of your gold and exp) y/n");
            var userInput = Console.ReadLine();
            if (userInput == "y")
            {
                player.Gold = 0;
                player.Exp = 0;
            }
            if (userInput == "n")
            {
                return;
            }
        }
    }

}
