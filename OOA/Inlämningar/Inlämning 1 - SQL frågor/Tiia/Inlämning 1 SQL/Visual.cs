using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_SQL
{
    class Visual
    {
        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_________________________________");
            Console.WriteLine("      Databas Personlist");
            Console.WriteLine("_________________________________");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine(@" [1.] Hur många olika länder finns representerade?
 [2.] Är alla username och password unika?
 [3.] Hur många är från Norden respektive Skandinavien?
 [4.] Vilket är det vanligaste landet?
 [5.] Lista de 10 första användarna vars efternamn börjar på bokstaven L
 [6.] Visa alla användare vars för- och efternamn har samma begynnelsebokstav 
 [7.] Exit");
            Console.WriteLine();
            Console.Write(">> ");
        }
    }
}

