using System;
using System.Collections.Generic;

namespace TheGame
{
    public class Shop
    {

        public static void LoadShop(Player p)
        {
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int defP; 
            int attP;
            
            while(true)
            {
                //prices for amulet
                defP = 100;
                attP = 100;
                
                Console.Clear();
                Console.WriteLine("================Welcome to the Shop!================");
                Console.WriteLine("1. Attack Amulet (+ 5 strength)         " + attP + " gold coins\n" +
                                  "2. Defense Amulet (+ 2 toughness)       " + defP + " gold coins\n" +
                                  "3. Return to main menu"); 
                Console.WriteLine("\n");
                Console.WriteLine(p.name + "'s Stats     ");
                Console.WriteLine("========================");
                Console.WriteLine("Current Health: " + p.health + " hp");
                Console.WriteLine("Coins:           " + p.coins + " gold coins");
                Console.WriteLine("Strength: " + p.strengthValue);
                Console.WriteLine("Toughness: " + p.toughnessValue);
                Console.WriteLine("===================================================");
                
                
                //Wait for input
                
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear ();
                
                                
                if(input == 1)
                    //Buy attack amulet
                    TryBuy("attA", attP, p);

                else if(input == 2)
                    //Buy defense amulet
                    TryBuy("defA", defP, p);

                else if(input == 3)    
                    //Back to main menu
                    return;

                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1-3.");
                    Console.WriteLine("[Press enter to continue...]");
                    Console.ReadKey();
                    continue;
                }
        
            }
        }

        static void TryBuy(string item, int cost, Player p)
        {
            if(p.coins >= cost)
            {
                if (item == "defA")
                    p.toughnessValue = p.toughnessValue + 2;
                else if (item == "attA")
                    p.strengthValue = p.strengthValue + 5;

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("You don't have enough gold!");
                Console.ReadKey();
            }
        }

    }
}