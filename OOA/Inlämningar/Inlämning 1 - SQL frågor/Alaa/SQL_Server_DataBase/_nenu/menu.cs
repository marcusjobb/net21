using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Server_DataBase._nenu
{
    class menu
    {
        public static void startMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("=================================================");
            Console.WriteLine(" ....             W E L C O M E             .... ");
            Console.WriteLine(" ....     B A N K  I N F O R M A T I O N    .... ");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine(" ....          YOUR LIST OF PEOPLE          .... ");
            Console.WriteLine(" ....          CONTAIN 1000 PERSON          .... ");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine(" 1)) ......          Log in               .......");
            Console.WriteLine(" ....         Pleas Enter Your Name         .... ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ........        E X I T            .........");
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
            Console.WriteLine(" 1)) ....     Show Details Informatio       .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ....          Edit your List            ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....     Add A Person To The List       ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ....   Delete A Person From The List      ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 5)) ...              E X I T                 ...");
            Console.WriteLine("_________________________________________________\n");
        }

        public static void showDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(".......   <<<<  S H O W   M E N U  >>>>   .......");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 1)) ....     Show All Person Details       .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ....     Persons Whose First Name       ....");
            Console.WriteLine("     ....   Begins With a Specific Letter    ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....      Persons Whose Last Name       ....");
            Console.WriteLine("     ....   Begins With a Specific Letter    ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ..  Person Whose Have The Same Gender     ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 5)) ..  Show How Many Country In The List     ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 6)) ....           Show If All              ....");
            Console.WriteLine(" ..     Usernames and Passwords Are unique?    ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 7)) How many are from the Scandinavia countries ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 8))  Show Which is the most common country?  ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 9)) ....     Show the first 10 users        ....");
            Console.WriteLine("         whose last name starts with the letter L");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 10)) ....      Show all users whose         ....");
            Console.WriteLine("    first and last names have the same initials  ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 11)) ...      Go Back To The Main Menu      ...");
            Console.WriteLine("_________________________________________________\n");
        }
    }
}
