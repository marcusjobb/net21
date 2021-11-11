using System;

namespace TheGame_JosefinPersson  
{
    class Menu
    {                                                                                                                   
        public void RunMenu(Player hero, TheGame game, Shop shop)  //menumetoden, instansieras och anropas via programklassen
        {
            while (hero.Level < 10)
            {
                Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                Console.WriteLine("1) Go adventuring!");
                Console.WriteLine("2) Show stats");
                Console.WriteLine("3) Go shopping");
                Console.WriteLine("4) Exit The Game");
                Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");

                string userInputMenu = Console.ReadLine();
                                                                                                                                                                                      
                int menuInputInt = 0;
                int.TryParse(userInputMenu, out menuInputInt);

                if (menuInputInt > 4 || menuInputInt < 0)
                {
                    Console.WriteLine("1-4");
                    Console.ReadKey();
                }

                switch (menuInputInt)
                {
                    case 1:
                        Console.Clear();
                        game.GoAdventuring(hero); 
                        break;
                    case 2:
                        Console.Clear();
                       hero.ShowStats();  
                        break;
                    case 3:
                        Console.Clear();
                        shop.RunShopMenu(hero, game);
                        break;
                    case 4:
                        hero.Level = 10;
                        break;
                    default:
                        Console.WriteLine("Enter a number between 1-4");
                        break;
                }
            }
        }
    }
}
