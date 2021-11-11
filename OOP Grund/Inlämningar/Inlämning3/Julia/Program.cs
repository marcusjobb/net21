using System;
using System.Collections.Generic;

namespace TheGame
{
    class Program
    {
        public static Player player = new Player();
        static void Main(string[] args)
        {
            Run();
            
        }

        static void Run()
        {

            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("||    Welcome to The Game!    ||");
            Console.WriteLine("================================");
            
            //Get player name
            Console.WriteLine("Enter your name:");
            Monster.player.name = Console.ReadLine(); 
                
            while(true)
            {
                
                Console.Clear();
                Console.WriteLine("Welcome " + Monster.player.name + ". Press one of the following numbers: ");
            
                //Menu
                Console.WriteLine("1. Go adventuring\n" +
                                  "2. Show details about your character\n" +
                                  "3. Go to shop\n" +
                                  "4. Exit game"); 
                Console.WriteLine("=========================================");
                                    
                if(Monster.player.level >= 10) //reached level 10 and won the game
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations!!! You are now level 10 and have won the game!");
                    Console.WriteLine("We hope you had fun playing this game. Press ENTER to exit the game.");
                    Console.ReadLine();
                    break;
                }
                
                
                try
                {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear ();
                
                                
                    switch (input)
                    {
                        //Go adventuring
                        case 1:
                            Monster.RandomEncounter();
                            break;

                        //Show details about your character
                        case 2:
                            Console.WriteLine(Monster.player.name + "'s Stats     ");
                            Console.WriteLine("========================");
                            Console.WriteLine("Current Health: " + Monster.player.health + " hp");
                            Console.WriteLine("Coins:   " + Monster.player.coins + " gold coins");
                            Console.WriteLine("Current exp: " + Monster.player.xp + " exp");
                            Console.WriteLine("Current level: " + Monster.player.level);
                            Console.WriteLine("Current strength: " + Monster.player.strengthValue);
                            Console.WriteLine("Current toughness: " + Monster.player.toughnessValue);
                            Console.WriteLine("========================");
                            Console.WriteLine("[Press enter to continue...]");
                            Console.ReadKey();
                            break;

                        //Go to shop
                        case 3:
                            Shop.LoadShop(Monster.player);
                            break;

                        //Exit game
                        case 4:
                            Console.Clear();
                                Console.WriteLine("Good bye " + Monster.player.name + ", it was fun having you!");
                                Console.WriteLine("[Press ENTER to exit the program]");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-4.");
                    Console.WriteLine("[Press ENTER to continue...]");
                    Console.ReadKey();
                }
            }
                

        }
    }
}