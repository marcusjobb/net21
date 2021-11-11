using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tiia
{
    class Menu
    {
        public static void MainHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t╒═══════════════════════════════╕");
            Console.WriteLine("\t╞          -THE GAME-           ╡ ");
            Console.WriteLine("\t╘═══════════════════════════════╛");
            Console.ResetColor();
        }

        public static void MainMenu()
        {
            Visual.ChangeToCyan();
            Console.Write("\n  [1] ");
            Console.ResetColor();
            Console.WriteLine("Go adventuring");

            Visual.ChangeToCyan();
            Console.Write("  [2] ");
            Console.ResetColor();
            Console.WriteLine("Show details about your character");
            Visual.ChangeToCyan();

            Console.Write("  [3] ");
            Console.ResetColor();
            Console.WriteLine("Go to shop");
            Visual.ChangeToCyan();

            Console.Write("  [4] ");
            Console.ResetColor();
            Console.WriteLine("Exit Game\n");
            Console.Write(">> ");
        }
        internal static void ShopMenu()
        {
            Console.WriteLine(" [1] | Attack Amulet  | + 5 strength  | - 100 gold |");
            Console.WriteLine(" [2] | Defense Amulet | + 2 toughness | - 100 gold |");
            Console.WriteLine(" [3] | Gold           | + 25 gold     | - 50 exp   |");
            Console.WriteLine(" [4] | Exit shop      |");
            Console.Write(">>");
        }
        internal static void FightMenu()
        {
            Visual.ChangeToCyan();
            Console.Write("\n  [1] ");
            Console.ResetColor();
            Console.WriteLine("Stay safe and run away before he sees you!");

            Visual.ChangeToCyan();
            Console.Write("  [2] ");
            Console.ResetColor();
            Console.WriteLine("Try to approach him calmly");
            Visual.ChangeToCyan();

            Console.Write("  [3] ");
            Console.ResetColor();
            Console.WriteLine("Attack the Shaman and steal his gold!");
            Visual.ChangeToCyan();

            Console.Write(">>");

        }


        internal static void StartScreen()
        {
            Console.SetCursorPosition(75, 5);
            Visual.ChangeToMagenta();
            Console.WriteLine();
            Console.WriteLine("     __________   __     __   ________       _________   ________   ___    ___   ________ ");
            Console.WriteLine("    |___    ___| |  |___|  | |   _____|     |  _______| |   __   | |   |  |   | |   _____| ");
            Console.WriteLine("        |  |     |   ___   | |  |___        |  |  ____  |  |__|  | |    ||    | |  |___   ");
            Console.WriteLine("        |  |     |  |   |  | |  |_____      |  |___|  | |   __   | |  | __ |  | |  |_____ ");
            Console.WriteLine("        |__|     |__|   |__| |________|     |_________| |__|  |__| |__|    |__| |________|");
            Visual.ChangeToCyan();
            Console.WriteLine("\n                                [Press any key to Start]");
            Console.ReadKey();
            Console.Clear();
        }

        internal static void ShopHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t╒═══════════════════════════════╕");
            Console.WriteLine("\t╞            -SHOP-             ╡ ");
            Console.WriteLine("\t╘═══════════════════════════════╛");
            Console.ResetColor();
        }

        internal static void Victory()
        {
            Console.WriteLine(@"
╦  ╦╦╔═╗╔╦╗╔═╗╦═╗╦ ╦
╚╗╔╝║║   ║ ║ ║╠╦╝╚╦╝
 ╚╝ ╩╚═╝ ╩ ╚═╝╩╚═ ╩ 
");
        }
        internal static void GameOver()
        {
            Console.WriteLine(@"
   ___   _   __  __ ___    _____   _____ ___ 
  / __| /_\ |  \/  | __|  / _ \ \ / / __| _ \
 | (_ |/ _ \| |\/| | _|  | (_) \ V /| _||   /
  \___/_/ \_\_|  |_|___|  \___/ \_/ |___|_|_\
                                             
");
        }

    }
}
