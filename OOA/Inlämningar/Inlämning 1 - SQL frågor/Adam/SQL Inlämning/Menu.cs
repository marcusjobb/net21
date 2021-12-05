using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Inlämning
{
    class Menu
    {
        public static void run()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) How many countries are represented?");
                Console.WriteLine("2) Are all usernames and passwords unique");
                Console.WriteLine("3) How many are from the north respectively from scandinavia?");
                Console.WriteLine("4) Whats the most common country in this database?");
                Console.WriteLine("5) List the top 10 users whose name starts with L");
                Console.WriteLine("6) List all the users whose firstname and lastname starts with same letter");
                Console.WriteLine("7) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Request.GetDistinctCountries();
                        return true;
                    case "2":
                        Request.GetDistinctPasswordsAndUsername();
                        return true;
                    case "3":
                        Request.GetFromTheNorthAndScandinavia();
                        return true;

                    case "4":
                        Request.GetFromTheNorthAndScandinavia();
                        return true;

                    case "5":
                        Request.GetTopTenUsers();
                        return true;

                    case "6":
                        Request.GetUserWithSameLetter();
                        return true;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        return false;


                    default:
                        return true;
                        
                }
            }
        }
    }
}
