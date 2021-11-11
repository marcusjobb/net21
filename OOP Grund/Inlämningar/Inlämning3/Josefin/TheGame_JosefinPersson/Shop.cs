using System;

namespace TheGame_JosefinPersson
{
    class Shop
    {
        public void RunShopMenu(Player hero, TheGame game)  //menumetoden, instansieras och anropas via programklassen
        {
            bool runShopMenu = true;
            while (runShopMenu)
            {
                Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                Console.WriteLine("                                            Welcome to the Shop!");
                Console.WriteLine("");
                Console.WriteLine("                                              Your gold: " + hero.Gold);
                Console.WriteLine("1) Show stats");
                Console.WriteLine("2) Buy 100 Health points. Cost - 200 gold");
                Console.WriteLine("3) Buy Strength, will add one point. Cost - 300 gold");
                Console.WriteLine("4) Buy Defense, will add one point. Cost - 300 gold");
                Console.WriteLine("5) Exit the Shop and return to the Main Menu");
                Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");

                string userInputShopMenu = Console.ReadLine();
                                                                                                                                                                                      
                int shopInputInt = 0;
                int.TryParse(userInputShopMenu, out shopInputInt);

                if (shopInputInt > 5 || shopInputInt < 0)
                {
                    Console.WriteLine("1-5");
                    Console.ReadKey();                                                                                                                                                
                }

                switch (shopInputInt)
                {
                    case 1:
                        Console.Clear();
                        hero.ShowStats();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You bought 100 Health Points!");
                        hero.Hp += 100;
                        hero.Gold -= 200;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You bought extra Strength! You feel your power rise!!!");
                        hero.Strength++;
                        hero.Gold -= 300;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("You bought extra Defense! You're on your way to be INVINCIBLE!!!");
                        hero.Defense++;
                        hero.Gold -= 300;
                        break;
                    case 5:
                        Console.Clear();
                        runShopMenu = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Enter a number between 1-5");
                        break;
                }
            }
        }
    }
}

