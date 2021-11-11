using System;
using System.Collections.Generic;

namespace TheGame
{
        public class Monster
    {
        static Random rand = new Random();
        public static Player player = new Player();

        //Encounter monster

        public static void FightMonster()
        {
            int encounter = rand.Next(1, 101);
            
            Console.WriteLine("You walk through the grass when suddenly a shadow crosses your path ...");
            Console.WriteLine("[Press ENTER to continue]");
            Console.ReadKey();

            if (encounter <= 10) //~10% encountering nothing
            {
                Console.Clear();
                Console.WriteLine("You see nothing but swaying grass all around you...");
                Console.WriteLine("[Press enter to continue]");
                Console.ReadKey();
            }
            else if (encounter == 100) // 1% to encounter a specific monster
            {
                Console.Clear();
                Console.WriteLine("[SPECIAL ENCOUNTER]");
                Console.WriteLine("A shiny four-legged feline jumps in front of you!");
                Console.WriteLine("[Press enter to continue]");
                Console.ReadKey();
                SpecificMonster.SpecialEncounter();
            }
            else
            {
                Combat(true, "", 0, 0);
            }
        }

        //Encounter

        public static void RandomEncounter()
        {
            switch(rand.Next(0,1))
            {
                case 0:
                    FightMonster();
                    break;
            }
        }
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            
            if(random)
            {
                n = GetName();
                p = Attack();
                h = mHealth();
            }

            else
            {
                n = "golden cat";
                p = 0;
                h = 10;
            }
            
            while(h>0)
            {
                              
                Console.Clear();
                Console.WriteLine("Uh oh! A wild " + n + " appeared!");
                Console.WriteLine(n + ": " + h + " hp" + "  Your Health: "+player.health);
                string input = Console.ReadLine();


                //Attack code  

                int damage = p - player.toughnessValue;

                if (damage < 0) //avoid negative dmg due to too much subtraction 
                {
                    damage = 0;
                }
                   
                int attack = rand.Next(player.strengthValue, player.strengthValue*2) + rand.Next(1, 4);
                Console.WriteLine("You hit the monster, dealing " + attack + " damage");
                Console.WriteLine("UUuooooaah *slurp*");
                Console.WriteLine("The "+ n + " hits you, dealing " + damage + " damage");
                player.health -= damage; //subtract damage from player's health
                h -= attack; //subtract damage from monster's health
                  
                if (player.health <= 0)
                {
                    //Death Code
                    Console.WriteLine("You were killed by the monster :(");
                    Console.WriteLine("[Press enter to exit...]");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                }

                Console.WriteLine("[Press enter to continue...]");
                Console.ReadKey();
            }

            Console.Clear();
            int c = 0;
            int exp = 0;
            
            if (random == false)
            {
                c = 1000;
                exp = 0;
                player.coins += c;
                player.xp += exp;
            }
            else if(random == true)
            {
                c = GetCoins();
                exp = GetXP();
                player.coins += c;
                player.xp += exp;
            }

            if (CanLevelUp())
                LevelUp();

            else
            {    
                Console.WriteLine("You killed the monster, gaining " + exp + " experience!");
                Console.WriteLine("Your are level " + player.level + ", and you have " + player.xp + " exp and " + player.health + " hp.");
                Console.WriteLine("You also found " + c + " gold coins!");
                Console.WriteLine("[Press enter to continue...]");
                
            }
                           
            Console.ReadKey();

        }
        public static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Giant Slime";
                case 1:
                    return "Giant Wurm";
                case 2:
                    return "Giant Frog";
                case 3:
                    return "Giant Mushroom";
            }
            return "Rat";
        }

        public static int mHealth() //monster health
        {
            return rand.Next(2, 31);
        }

        public static int Attack() //monster power
        {
            return rand.Next(1, 21);
        }

        public static int GetCoins() //monster coins
        {
            return rand.Next(10, 65);
        }

        public static int GetXP() //monster exp
        {
            return rand.Next(15, 71);
        }

        //Leveling setup
        public static int GetLevelUpValue()
        {
            return 10 * player.level + 50;
        }

        public static bool CanLevelUp()
        {
            if (player.xp >= GetLevelUpValue())
                return true;
            else
                return false;
        }

        public static void LevelUp()
        {
            while (CanLevelUp())
            {
                player.xp -= GetLevelUpValue();
                player.level++;
                player.health = 200; //refill
            }
            
            Console.WriteLine("Congratulations! You leveled up! You are now level " + player.level + "!!! You have " + player.xp + " exp and " + player.health + " hp.");
            Console.WriteLine("[Press enter to continue...]");
            Console.ReadLine();
        }

    }

}