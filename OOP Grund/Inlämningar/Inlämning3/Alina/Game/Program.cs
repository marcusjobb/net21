using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("- Welcome To The Game! -");
            Console.WriteLine("-------------------------");

            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            var fighter = new Fighter(name);
            var shop = new Shop();
            
            while (true)
            {
                PrintMeny();
                Choices choice;
                while (!Enum.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(Choices), choice))
                {
                    Console.WriteLine(" Enter a right number");
                }
                switch (choice)
                {
                    case Choices.GoAdventure:
                        GoAdventure(fighter);
                        break;

                    case Choices.GoShoping:
                        GoShoping(shop, fighter);
                        break;

                    case Choices.PrintPlayerInfo:
                        fighter.PrintInfo();
                        break;

                    case Choices.Exit:
                        Environment.Exit(0);
                        return;
                }

                if (fighter.Level == 10)
                {
                    Console.WriteLine("You've won!");
                    return;
                }
            }
        }

        static void PrintMeny()
        {
            Console.WriteLine("-----Meny-------------");
            Console.WriteLine("1. Go Adventure ");
            Console.WriteLine("2. Go Shopping");
            Console.WriteLine("3. Print player info");
            Console.WriteLine("4. Exit ");
            Console.WriteLine("----------------------");
        }

       

        static void GoAdventure(Fighter fighter)
        {
            var random = new Random();
            var chance = random.Next(1, 100);
            if (chance < 11)
            {
                Console.WriteLine("Grass");
            }
            else
            {
                Console.WriteLine("Oh, no! Monster is here. Begin to fight!");

                var monster = Monster.CreateRandomMonster();

                var playerLevelBeforeFight = fighter.Level;

                while (fighter.IsAlive && monster.IsAlive)
                {
                    Console.WriteLine($"You hit the monster {monster.Name}, dealing {fighter.Attack} damage");
                    monster.HP -= fighter.Attack + fighter.Strength;
                    if (monster.IsAlive)
                    {
                        Console.WriteLine($"{monster.Name} attacks you, dealing {monster.Attack} damage");
                        fighter.HP -= Math.Abs(monster.Attack - fighter.Defense);
                    }

                    Console.ReadLine();
                }

                if (!fighter.IsAlive)
                {
                    Console.WriteLine("You died!");
                    return;
                }

                if (!monster.IsAlive)
                {
                    Console.WriteLine($"You have slained {monster.Name}!");
                    Console.WriteLine($"You gain {monster.GoldPieces} gold pieces and {monster.XP} XP");
                    fighter.HP = fighter.MaxHP;
                    fighter.GoldPieces += monster.GoldPieces;
                    fighter.XP += monster.XP;
                    if (fighter.Level != playerLevelBeforeFight)
                    {
                        Console.WriteLine($"You leveled up, you are now level {fighter.Level}");
                    }
                }
            } 
        }


        static void GoShoping(Shop shop, Fighter fighter)
        {
            var shopItems = shop.GetItems();

            if (!shopItems.Any())
            {
                Console.WriteLine("The shop is currently out of items!");
                return;
            }

            Console.WriteLine(" What do you want to buy today? Write a number, thank you! ");
            for (int i = 0; i < shopItems.Count; ++i)
            {
                var item = shopItems[i];

                Console.WriteLine($"{i + 1}. {item.Name} {item.Price} gold pieces");
            }

            int choice = int.Parse(Console.ReadLine());

            if (shop.CanBuy(choice, fighter.GoldPieces))
            {
                var item = shop.Buy(choice);

                fighter.GoldPieces -= item.Price;

                Console.WriteLine($"You bought the {item.Name}");

                fighter.Items.Add(item);
            }
            else
            {
                Console.WriteLine("You can't afford it!");
            }
        }

        static void Exit()
        {
            Console.Write("Do you want to continue playing ? (yes/no)");
            while (true)
            {
                string answer = Console.ReadLine().Trim();
                if (answer == "yes")
                {
                    break;
                }
                else if (answer == "no")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please only enter yes or no!");
                }
            }

        }

        public enum Choices
        {
            GoAdventure = 1,
            GoShoping,
            PrintPlayerInfo,
            Exit
        }
    }
}
