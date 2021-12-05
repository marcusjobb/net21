using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQL_inlämning.SQLConnection;

namespace SQL_inlämning
{
    internal class Menu
    {
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Vilken information vill du se?");
                Console.WriteLine("1. Hur många länder finns?");
                Console.WriteLine("2. Är alla usernames och passwords unika?");
                Console.WriteLine("3. Hur många är från Norden respektive Skandinavien");
                Console.WriteLine("4. Vilket är det vanligaste landet");
                Console.WriteLine("5. Lista de tio första användarna vars namn börjar på L");
                Console.WriteLine("6. Visa alla användare vars för- och efternamn har samma begynnelsebokstav");
                string input = Console.ReadLine();

                if (input == "1")
                    Input1();
                if (input == "2")
                    Input2();
                if (input == "3")
                    Input3();
                if (input == "4")
                    Input4();
                if (input == "5")
                    Input5();
                if (input == "6")
                    Input6();
                


            }
        }

        private static void Input6()
        {
            Console.Clear();
            SqlConnTwoRow("SELECT first_name, last_name FROM Mackaroo_data WHERE UPPER(LEFT(first_name, 1)) = UPPER(LEFT(last_name, 1))");
        }

        private static void Input5()
        {
            Console.Clear();
            SqlConnOneRow("SELECT top 10 first_name FROM Mackaroo_data WHERE first_name LIKE 'L%'");
        }

        private static void Input4()
        { 
            Console.Clear();
            SqlConnOneRow("SELECT TOP 1 country FROM Mackaroo_data GROUP BY country ORDER BY COUNT(*) DESC");
        }

        private static void Input3()
        {
            Console.Clear();
            Console.Write("Norden : ");
            SqlConnOneRow("SELECT Count(country) FROM Mackaroo_data WHERE country = 'Sweden' OR country = 'Norway' OR country = 'Denmark' OR country = 'Iceland' OR country = 'Finland'");
            Console.Write("Skandinavien : ");
            SqlConnOneRow("SELECT Count(country) FROM Mackaroo_data WHERE country = 'Sweden' OR country = 'Norway' OR country = 'Denmark'");
        }

        private static void Input2()
        {
                Console.Clear();
                SqlConnTwoRow("select Count(DISTINCT username), Count(DISTINCT password) from Mackaroo_data");
        }

        private static void Input1()
        {
                Console.Clear();
                SqlConnOneRow("select Count(DISTINCT country) from Mackaroo_data");
        }
    }
}
