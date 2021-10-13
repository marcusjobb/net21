using System;
using System.Collections.Generic;

namespace Chat_the_F_up_TiiaTu
{
    class HelperClass
    {
        public static void Menu()
        {
            Console.WriteLine(" _______________________________________");
            Console.WriteLine("|           F - CONTACT LIST            |");
            Console.WriteLine("|    Select a number from the menu      |");
            Console.WriteLine("|---------------------------------------|");
            Console.WriteLine("| [ 1 ] - Add a person                  |");
            Console.WriteLine("| [ 2 ] - Update information            |");
            Console.WriteLine("| [ 3 ] - Delete a person               |");
            Console.WriteLine("| [ 4 ] - Show and sort the list        |");
            Console.WriteLine("| [ 5 ] - Exit                          |");
            Console.WriteLine("|_______________________________________|");

        }
        public static void SecondMenu()
        {
            Console.WriteLine(" _______________________________________");
            Console.WriteLine("|            Sort the list              |");
            Console.WriteLine("|    Select a number from the menu      |");
            Console.WriteLine("|---------------------------------------|");
            Console.WriteLine("| [ 1 ] - Show all                      |");
            Console.WriteLine("| [ 2 ] - List in alphabetical order    |");
            Console.WriteLine("| [ 4 ] - Back to main menu             |");
            Console.WriteLine("|_______________________________________|");
        }


    }
 
}
