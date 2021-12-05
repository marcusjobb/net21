using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Assignment1.Database;
using SQL_Assignment1.Queries;
using SQL_Assignment1.Menus;
using static SQL_Assignment1.Helpers.DisplayHelper;
using static SQL_Assignment1.Helpers.UserExperience;

namespace SQL_Assignment1
{
    public class DBMenu
    {
        // Initializes the whole program by calling on different classes and methods, lastly starts the menu. The menu is the "main" program in this project so it felt okay to let the menu class set up all the different things.
        internal static void Run()
        {
            SetColours();
            Intro.SetUpMessage();
            InitializeNewDB.CreateTables();
            InitializeNewDB.PopulateTableFromSQLFile();
            MainMenu();
        }

        internal static void MainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                PrintBox(" > Original yet quirky database name < ");
                Console.WriteLine("[1] - View all unique countries.");
                Console.WriteLine("[2] - Check unique usernames and passwords.");
                Console.WriteLine("[3] - Unique users in The Nordics / in Scandinavia.");
                Console.WriteLine("[4] - View the most common country.");
                Console.WriteLine("[5] - View top 10 users whose last name starts with \"L\".");
                Console.WriteLine("[6] - View all users whose first- and last name starts with the same letter.");
                Console.WriteLine("[7] - Exit");
                int.TryParse(Console.ReadLine(), out int menuchoice);
                switch (menuchoice)
                {
                    case 1:
                        ClearAndPresent("Viewing all unique countries");
                        Query.GetDifferentCountries();
                        PressEnterToContinue();
                        break;
                    case 2:
                        ClearAndPresent("Viewing unique usernames and passwords");
                        Query.CheckUniqueUsernamePassword();
                        PressEnterToContinue();
                        break;
                    case 3:
                        ClearAndPresent("Viewing unique users in The Nordics and in Scandinavia");
                        Query.GetNordicVSScandinavia();
                        PressEnterToContinue();
                        break;
                    case 4:
                        ClearAndPresent("Viewing the most common country.");
                        Query.GetMostCommonCountry();
                        PressEnterToContinue();
                        break;
                    case 5:
                        ClearAndPresent("Viewing top 10 users whose last name starts with \"L\".");
                        Query.GetTopTenUsersStartingWithL();
                        PressEnterToContinue();
                        break;
                    case 6:
                        ClearAndPresent("Viewing users whose first- and last name starts with the same letter.");
                        Query.GetSameFirstnameLastnameLetter();
                        PressEnterToContinue();
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("Exiting");
                        AnimatedText("...", 75);
                        PressKeyToContinue();
                        showMenu = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
