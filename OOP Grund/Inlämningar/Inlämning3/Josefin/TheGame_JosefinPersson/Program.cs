using System;
using System.Threading; // Thread.Sleep();

namespace TheGame_JosefinPersson
{
    class Program                      
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
            Console.WriteLine("                                              Welcome to THE GAME!");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("                         You must go on an adventure to defeat the monsters of this world.");
            Console.WriteLine("          There are three types of monsters to defeat, they will drop gold and experience points when killed."); 
            Console.WriteLine("                        You can visit the Shop to buy extra health points, strength or defense.");
            Console.WriteLine("                                 When you reach level 10, you win THE GAME!!! ");
            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.WriteLine("                               Let's begin our adventure. Please tell me your name...");
            Console.WriteLine("");
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");

            string userInputName = Console.ReadLine();    
            
            //skapa spelarobjekt i början av spelet, fråga efter spelarens namn
            Player hero = new Player();
            hero.Name = userInputName;
            Console.WriteLine("                                           Nice to meet you " + hero.Name + "!");
            Thread.Sleep(1000);
            Console.WriteLine("                                   Chose an alternative from the menu to begin: ");

            //instansiera The Game
            TheGame game = new TheGame();

            //instansiera shop
            Shop shop = new Shop();                                                          

            // anropa huvudmenyn
            Menu menu = new Menu(); // skapa en meny av Menu-klassen
            menu.RunMenu(hero, game, shop);

            shop.RunShopMenu(hero, game);
        }
    }
}
