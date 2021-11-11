using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_3
{
    class Oprations
    {

        public Player player = new();
        public SpecificMonster monster = new();
        public Messages startmessage = new();

        public void startvalue()
        {
            player.Hp = 200; player.Level = 1; player.Exp = 0; player.Power = 35;
             monster.Hp = 200; monster.Exp = 10; monster.Power = 26;
        }

        
        public void Fight()
        {
            Console.Clear();
            startvalue();

            while (player.Level < 10)
            {
                Console.Clear();

                monstersName(player.Level);

                Console.WriteLine("***********************");
                Console.WriteLine($"    {player.Name} vs {monster.Name}      ");
                Console.WriteLine("***********************\n");

                bool Continue = true;

                player.Hp = 200;
                monster.Hp = 200;

                Random FightValue = new();
                

                do
                {
                    int losePlayerhp = FightValue.Next(10, player.Power);
                    int loseMonsterhp = FightValue.Next(10, monster.Power);

                    player.Hp -= loseMonsterhp;
                    monster.Hp -= losePlayerhp;
                    Console.WriteLine($"You hit {monster.Name} and you dealing {losePlayerhp}\n" +
                                      $"{monster.Name} hit you and dealing {loseMonsterhp} ");
                    
                    if (player.Hp <= 0 || monster.Hp <= 0)
                    {
                        Continue = false;
                    }
                    else
                    {
                        Console.WriteLine($"Player blood    = {player.Hp} " +
                                      $"\nMonster blood   = {monster.Hp}");

                        Console.WriteLine("\nPress Enter to continue");
                        Console.ReadLine();
                    }

                } while (Continue);

                if (player.Hp <= 0)
                {
                    startmessage.Ripmessage();
                    Console.WriteLine("Press Enter to back to The menu");
                    Console.ReadLine();
                    menu();
                }
                else
                {
                    Win();
                    Console.WriteLine("***********************");
                    Console.WriteLine($"\n You killed [{monster.Name}] and you have [{player.Exp}] Exp and [{player.Hp}] Hp.\n" +
                                      $" Move to the level: [{player.Level}]");
                }

                Console.WriteLine("\nPress [M] to go to the Menu.\n" +
                        "Press any key to continue fight");
                string input = Console.ReadLine();
                if (input.ToLower() == "m")
                    menu();
            }
            if (player.Level == 10)
            {
                Console.Clear();
                startmessage.WonMessage();
                Console.WriteLine(" You are level 10. \nCongratulations! You won the game.");
                returnToMenu("Press any key to return menu");
            }
        }


        public void Win()
        {
                player.Level += 1;

                player.Exp += monster.Exp;

                player.Power += (player.Exp / 10);

                monster.Exp += 10;

                monster.Power += 2;
        }

        public void monstersName(int level)
        {
            string[] names =  { "Hobgoblin", "skeleton", "Demon", "The Grim reaper" , "The Headless Horseman", "Vampire" , "Mummy" , "Witch"  , "Frankensteins" };

            for (int i=0; i < names.Length; i++)
            {
                monster.Name = names[level-1];
            }
        }


        public void returnToMenu(string Message)
        {
            Console.WriteLine(Message);
            Console.ReadLine();
            menu();
        }


        public void Titel()
        {
            startmessage.startmessage();
        }
        public void welcome()
        {
            Titel();
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            player.Name = name;
        }


        public void details() //Ta bort player power och monster information.
        {
            Console.Clear();
            if (player.Level <= 0) { startvalue(); }


            Console.WriteLine($"Player Level ={player.Level} \nPlayer EXP= {player.Exp} \nPlayer power ={player.Power}");
            returnToMenu("Press any key to return to the Menu.");
        }


        public void returnGmae()
        {
            Console.Clear();
            if (player.Level <= 1)
            {
                returnToMenu("You don't start any game yet\n" +
                    "Press any key to return the Menu and start a new game.");
            }
            if (player.Level == 10)
            {
                returnToMenu("You won the game.\n" +
                    "Press any key to return the Menu and start a new game.");
            }

        }

        public void menu()
        {
            Console.Clear();
            Titel();
            Console.WriteLine($" Hi {player.Name}, Are you ready to fight?\n Press [1] to start a new fight or [3] to return to the fight");
            Console.WriteLine("\n[1] Go Adventuring" );
            Console.WriteLine("[2] Show details about your character");
            Console.WriteLine("[3] Return to the game");
            Console.WriteLine("[4] Exit game");
            string input = Console.ReadLine();
            int.TryParse(input, out int number);

            while (number < 1 || number > 4)
            {
               
                Console.Write("Du har valt fel. Välj tjänst nummer igen:");
                string inputB = Console.ReadLine();
                int.TryParse(inputB, out number);
            }

            switch (number)
            {
                case 1: Fight(); break;
                case 2: details();break;
                case 3: returnGmae();break;
                default: Environment.Exit(0); break;
            }
        }
    }
}
