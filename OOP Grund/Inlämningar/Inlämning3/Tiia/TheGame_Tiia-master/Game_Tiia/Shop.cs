using System;
using System.Threading;

namespace Game_Tiia
{
    internal class Shop
    {
        internal static void ShopItems(Player player)
        {
            Menu.ShopHeader();
            Console.WriteLine("Welcome to the shop! Pick the item you want to purchase ");
            Console.WriteLine($"You have {player.Gold} gold.\n");
            Menu.ShopMenu();
            
            int menuChoise = UserInput();

            switch (menuChoise)
            {
                case 1: AttackAmulet(player); break;
                case 2: DefenceAmulet(player); break;
                case 3: BuyGold(player); break;
                case 4: break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        private static void BuyGold(Player player)
        {
            int amountGoldSold = 25;
            int expCost = 50;
            
            player.Gold += amountGoldSold;
            player.Exp -= expCost;
            
            Console.WriteLine("You bought 25 gold");
        }

        private static void AttackAmulet(Player player)
        {
            if (player.Gold >= 50)
            {
                player.Strenght += 5;
                player.Gold -= 50;
            }
            else
            {
                Console.WriteLine("Nice try! You don't have enough gold.. ");
                Bargain(player);
            }
        }
        private static void DefenceAmulet(Player player)
        {
            if (player.Gold >= 50)
            {
                player.Toughness += 2;
                player.Gold -= 50;
            }
            else
            {
                Console.WriteLine("Oops! Looks like you don't have enough gold my friend");            
            }
        }

        private static void Bargain(Player player)
        {
            Console.WriteLine("Would you like to bargain? y/n");
            var bargainOrNot= Console.ReadLine().ToLower();
            
            if (bargainOrNot=="y")
            {
                Console.WriteLine("If you are willing to give up 25 exp points, you can get the amulet with 25 gold. \nDeal? y/n ");
                var dealOrNot = Console.ReadLine().ToLower();
                
                if (dealOrNot=="y")
                {
                    Console.WriteLine("You bought an Attack Amulet (cost: 25 exp and 25 gold)");
                    player.Exp -= 25;
                    player.Gold -= 25;
                }
                else if (dealOrNot=="n")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(250);
                    }                   
                    Console.WriteLine("Okay we might have something special for you... You get the Amulet for 10 gold, BUT \nyou have to also give 40 of your exp.");
                    Console.WriteLine("This is your last change, do we have a deal? y/n");

                    var lastDeal = Console.ReadLine().ToLower();
                    if(lastDeal=="y")
                    {
                        Console.WriteLine("You bought an Attack Amulet (cost: 40 exp and 10 gold)");
                        player.Exp -= 40;
                        player.Gold -= 10;
                    }
                    else if (lastDeal=="n")
                    {
                        Console.WriteLine("Sorry we have nothing else to offer, goodbye!");
                        Thread.Sleep(500);
                        Console.Clear();
                        return;
                    }
                }
            }
            else if (bargainOrNot=="n")
            {
                return;
            }
        }

        private static int UserInput()
        {
            int menuChoise = 0;
            Visual.ChangeToCyan();
            var input = int.TryParse(Console.ReadLine(), out menuChoise);
            Console.ResetColor();
            return menuChoise;
        }
    }
}
