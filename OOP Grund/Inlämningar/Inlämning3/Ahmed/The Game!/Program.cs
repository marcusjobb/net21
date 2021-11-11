using System;
using System.Collections.Generic;

namespace The_Game_
{
    
    class Program
    {
        private static Player player;
        static void Main(string[] args)
        {
            InitPlayer();
            Menu();
        }

        private static void InitPlayer()
        {
            Console.WriteLine("What is your name?");
            player = new Player(Console.ReadLine());
            Console.Clear();
        }

        private static void Menu()
        {
            while (true)
            {
                Console.WriteLine("***********************");
                Console.WriteLine($" *Welcome to the Game* ");
                Console.WriteLine("***********************");
                Console.WriteLine("\n[1]\tGo on adventure \n[2]\tPlayer Information \n[3]\tExit Game ");
                string Menu = Console.ReadLine();
                string menuChoice = Menu.ToUpper();

                switch (menuChoice)
                {
                    case "1":
                        bool result = Adventure();
                        if (result == true)
                        {
                            break;
                        }
                        continue;

                    case "2":
                        PlayerInfo();
                        continue;

                    case "3":
                        Console.WriteLine("Thank you for playing the game");
                        return ;

                    default:
                        Console.WriteLine("Invalid choice try again!");
                        continue;
                        
                }
                
                return;

            }
        }

        private static void PlayerInfo()
        {
            while (true)
            {
                Console.Clear();
                player.Print();
                Console.ReadLine();
                return;
            }
        }

        private static bool Adventure()
        {
            Console.Clear();
            Console.WriteLine("Your hunting a deer when all of a sudden...");
            Continue();
            var monster = GenerateMonster();
            monster.Print();
            Continue();
            bool result = Combat(monster);
            if (result)
            {
                return true;
            }
            player.Hp = 200;      
            return false;
            
        }

        private static bool Combat(Monster monster)
        {
            while (true)
            {
                monster.Hp = monster.Hp - player.Strenght;
                Console.WriteLine($"You attacked the {monster.Name} with a punch and gave him" +
                $" {player.Strenght} in damage. The {monster.Name}s health is now {monster.Hp} hp");

                if (monster.Hp <= 0) 
                {
                    player.Hp = 200;
                    Console.WriteLine($"You have defeated the monster you have gained {monster.Exp} exp");
                    player.Exp += monster.Exp;
                    if (player.Exp >= 100)
                    {
                        player.Level += 1;
                        player.Exp %= 100;
                       return LevelUp();
                    }
                    return false;
                }
                player.Hp = player.Hp - monster.Strenght;
                Console.WriteLine($"{monster.Name} attacked you with a bite and gave you" +
                $" {monster.Strenght} damage. Your health is now {player.Hp} hp");
                
                if (player.Hp <= 0)
                {
                    Console.WriteLine($"Oh no! The {monster.Name}s " +
                        $"last attack was too much you are now dead! ");
                    return false;
                }
                Continue();
                Console.Clear();
            }
        }

        private static bool LevelUp()
        {
            Console.WriteLine($"Congratulations you have now reached level {player.Level}");
            if (player.Level >= 10)
            {
                Console.WriteLine($"Congratulations you are at level {player.Level}" +
                    $" and have conqueared the game!" );
                return true;
            }
            Continue();
            Console.Clear();
            return false;
        }

        private static void Continue()
        {
            Console.WriteLine("[Press enter to continue]");
            Console.ReadLine();
        }

        private static Monster GenerateMonster()
        {
            Monster randomMonster = null;
            Random rand = new Random();
            int index = rand.Next(1, 5);
            switch (index)
            {
                case 1:
                    randomMonster = new Werwolf();
                    break;

                case 2:
                    randomMonster = new Zombie();
                    break;

                case 3:
                    randomMonster = new Vampire();
                    break;

                case 4:
                    randomMonster = new Gremlin();
                    break;

                default: return null;
                    
            }
            return randomMonster;
        }
    }
}
