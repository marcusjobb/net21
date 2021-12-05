using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_SQL
{
    class Helper
    {
        //----------övriga hjälpmetoder-------------------------------------------------------

        public static int UserChoise()
        {
            int.TryParse(Console.ReadLine(), out int menuChoise);
            return menuChoise;
        }

        public static void Question(string question)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(question);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void BackToMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            Console.WriteLine("[Tryck enter för att gå tillbaka till meny]");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
