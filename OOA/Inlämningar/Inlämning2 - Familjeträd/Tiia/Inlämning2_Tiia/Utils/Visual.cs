using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils
{
    class Visual
    {
        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.ResetColor();

            Console.WriteLine("Welcome to the Targaryen family tree\n");

            Console.WriteLine("   [1] - Create a person\n"+
                                "   [2] - Find parents\n"+
                                "   [3] - Update information\n"+
                                "   [4] - Show siblings\n"+
                                "   [5] - Show children\n"+
                                "   [6] - Show grandparents\n"+
                                "   [7] - List all\n"+
                                "   [8] - List by letter\n"+
                                "   [9] - Delete person\n"+
                                "   [10] - Exit");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.ResetColor();

            Console.Write(">> ");
        }

        public static void SpoilerAlert()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|>>>>>>> SPOILER ALERT <<<<<<<|\n");
            Console.ResetColor();
            Console.WriteLine(@"This family tree you are about to see 
contains spoilers for the series Game of Thrones!");
            Console.WriteLine(" \n[press enter at your own risk]");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
