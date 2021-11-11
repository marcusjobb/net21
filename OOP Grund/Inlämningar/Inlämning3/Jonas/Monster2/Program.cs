using System;

//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;

namespace TheGame001
{
    class Program
    {
        static void Main(string[] args)
        {

            //ConsoleHelper.SetCurrentFont("Consolas", 10);
            ConsoleHelper.SetCurrentFont("Terminal", 8);                //Ville ha 8x8
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            bool go_on = true;
            while (go_on)
            {
                Console.Write("Mata in ditt namn: ");
                string input = Console.ReadLine();
                Player player = new Player(input, '0', 0);
                Console.WriteLine(" ♦† þð¤¶µ†○");
                Console.WriteLine(" Välkommen, " + input);
                Console.WriteLine(" Framför dig ser du ett hål i golvet med en brandstång     ");
                Console.WriteLine(" samt en skylt med påskriften \"Minotaurens Labyrint => \"  ");
                Console.WriteLine("   ");
                Console.WriteLine(" Om du hoppar på brandstången finns uppenbarligen ingen återvändo.  ");
                Console.WriteLine("   ");
                while (player.IsAlive && player.XP <10000)
                {
                    int answer = 0;
                    do
                    {
                        Console.WriteLine("Välj:   ");
                        Console.WriteLine("   ");
                        Console.WriteLine("1) Hoppa på brandstången och kliv in i Minotaurens labyrint   ");
                        Console.WriteLine("2) Visa info om dig själv.  ");
                        Console.WriteLine("3) Hjälp, detta är för kusligt - avsluta!   ");
                        Console.WriteLine("   ");
                        int.TryParse(Console.ReadLine(), out answer);
                    } while (answer < 1 || answer > 3);

                    switch (answer)
                    {
                        case 1:
                            Game myNewGame = new Game();
                            myNewGame.NewGame(player);
                            break;
                        case 2:
                            player.Display();
                            break;
                        case 3:
                            go_on = false;
                            player.IsAlive = false;
                            //player.XP = 10000;
                            break;
                        default:
                            break;
                    }

                }
                if (player.XP >= 10000)
                {
                    Console.WriteLine("Du har vunnit");
                    go_on = false;
                }

            }
            Console.WriteLine("Du Har avslutat");
 
            Console.ReadLine();
        }
    }




}





