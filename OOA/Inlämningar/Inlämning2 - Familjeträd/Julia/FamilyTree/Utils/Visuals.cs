using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FamilyTree.Utils
{
    internal class Visuals
    {
        //-----------------Visuals------------------
        public static void HPLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                           _ __                                 ");
            Delay();
            Console.WriteLine("          ___                             | '  \\                                ");
            Delay();
            Console.WriteLine("     ___  \\ /  ___         ,'\\_           | .-. \\        /|                     ");
            Delay();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     \\ /  | |,'__ \\  ,'\\_  |   \\          | | | |      ,' |_   /|               ");
            Delay();
            Console.WriteLine("   _ | |  | |\\/  \\ \\ |   \\ | |\\_|         | |_| |   _'-. .-','  |_   _          ");
            Delay();
            Console.WriteLine("  // | |  | |____| | | |\\_|| |__    //    |     | ,'_`. | | '-. .-',' `. ,'\\_   ");
            Delay();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  \\\\_| |_,' .-, _  | | |   | |\\ \\  //    .| |\\_/ | / \\ || |   | | / |\\  \\|   \\  ");
            Delay();
            Console.WriteLine("   `-. .-'| |/ / | | | |   | | \\ \\//     |  |    | | | || |   | | | |_\\ || |\\_| ");
            Delay();
            Console.WriteLine("     | |  | || \\_| | | |   /_\\  \\ /      | |`    | | | || |   | | | .---'| |    ");
            Delay();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     | |  | |\\___,_\\ /_\\ _      //       | |     | \\_/ || |   | | | |  /\\| |    ");
            Delay();
            Console.WriteLine("     / _\\ | |           //_____//       .||`      `._,' | |   | | \\ `-' /| |    ");
            Delay();
            Console.WriteLine("          /_\\           `------'        \\ |              `.\\  | |  `._,' /_\\    ");
            Delay();
            Console.WriteLine("                                         \\|                    `.\\              ");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ResetColor();
        }

        public static void Delay()
        {
            Thread.Sleep(TimeSpan.FromSeconds(0.1));
        }

        public static void mainMenu()
        {
            Console.Clear();
            Console.WriteLine("============ WELCOME TO THE POTTER/WEASLEY FAMILY =============\n");
            Console.WriteLine("[1] Create a new person, birth place or death place\n" +
                              "[2] Find a person's mother and change it\n" +
                              "[3] Find a person's father and change it\n" +
                              "[4] Edit a person\n" +
                              "[5] Delete a person\n" +
                              "[6] Show everyone in the family\n" +
                              "[7] Show everyone according to user choice\n" +
                              "[8] Show relationship between people\n" +
                              "[0] Exit");
            Console.WriteLine("\n==============================================================");
        }
    }
}
