using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFight._mainMenu
{
    class mainMenu
    {
        public static void startMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("=================================================");
            Console.WriteLine(" ....             W E L C O M E             .... ");
            Console.WriteLine(" ....    T O  T H E  F I G H T  G A M E     .... ");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine(" 1)) ......          Log in               .......");
            Console.WriteLine(" ....         Pleas Enter Your Name         .... ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ......          Sign Up              .......");
            Console.WriteLine(" .....        Greate a new Account         ..... ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ........          Exit             .........");
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Please Enter your Choice");
        }

        public static void mainMenuSelection()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(".......    <<<< M A I N   M E N U >>>>    .......");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 1)) ......       Go Adventuring          .......");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ..   Show details about your character    ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ..             Shop System                ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ...      Go Back To The Start Menu       ...");
            Console.WriteLine("_________________________________________________\n");
        }

        public static void detailsMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("....     <<   S H O W   D E T A I L S   >>   ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 1)) ...   your Current Account Information   ...");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ...   YOur Others Accounts Information   ...");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....      Go Back To The Start Menu     ....");
            Console.WriteLine("_________________________________________________\n");
        }

        public static void ShopMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("....      <<   S H O P  S Y S T E M   >>     ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 1)) ....        Buy Strength Amulet         ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ....        Use Strength Amulet         ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....         Buy DefenSe Amulet         ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ....         Use DefenSe Amulet         ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 5)) ........         Exit Shop          ........");
            Console.WriteLine("_________________________________________________\n");
        }
    }
}
