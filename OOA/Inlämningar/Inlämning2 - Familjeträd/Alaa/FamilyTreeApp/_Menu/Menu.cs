using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeApp._Menu
{
    class Menu
    {
        
        public static void startMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("=================================================");
            Console.WriteLine(" ....           W E L C O M E  T 0          .... ");
            Console.WriteLine(" ....  F A M I L Y  T R E E  P R O G R A M  .... ");
            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");
            Console.WriteLine(" ....        THIS IS A TRIAL VERSION        .... ");
            Console.WriteLine(" . YOU CAN ONLY SEE AND CREATE FAMILY TREE FOR:  ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ....  <<<<((     HARERY POTTER      ))>>>  .... ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" ....           TRY IT FOR FREE             .... ");
            Console.WriteLine(" ....        YOU CAN BUY IT LATER !!        .... ");
            Console.WriteLine("=================================================");
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
            Console.WriteLine(" 2)) ....     Show Family RelationShip      .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....          Edit your List            ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ....     Add A Person To The List       ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 5)) ....   Delete A Person From The List      ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 6)) ...              E X I T                 ...");
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Please Enter your Choice");
        }

        public static void showDetailsMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(".......   <<<<  S H O W   M E N U  >>>>   .......");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 1)) ....     Show All Members Family       .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) .. Reverse Order Of Members  By Last Name  ..");
            Console.WriteLine("     ....    Take Only ( Max 10 ) Members    ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....      Show All Persons Whose        ....");
            Console.WriteLine("     ....        Their Last Name is :        ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ....      Show All Persons Whose        ....");
            Console.WriteLine("     ....       Their First Name Is :        ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 5)) ....     Persons Whose First Name       ....");
            Console.WriteLine("     ....   Begins With a Specific Letter    ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 6)) ....      Persons Whose Last Name       ....");
            Console.WriteLine("     ....   Begins With a Specific Letter    ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 7)) ..  Person Whose Have The Same Gender     ..");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 8)) ....      Show All Persons Whose        ....");
            Console.WriteLine("     ....            Are Died                ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 9)) ..   Persons Whose Are More Than Fifty    ..");
            Console.WriteLine("     ....    Years Old And Still Alive       ....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 10)) ...      Go Back To The Main Menu      ...");
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Please Enter your Choice");
        }

        public static void FamilyRelationMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("<<   F A M I L Y  R E A L A T I O N S H I P    >>");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 1)) ....    Father For a Family Member     .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 2)) ....    Mother For a Family Member     .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 3)) ....    Spouse For a Family Member     .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 4)) ....    Children For a Family Member   .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 5)) ....    Sipling For a Family Member    .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 6)) .... GrandFather For a Family Member   .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 7)) .... GrandMother For a Family Member   .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 8)) ....     Aunt For a Family Member      .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 9)) ....     Uncle For a Family Member     .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 10)) ....    Cousin For a Family Member    .....");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(" 11)) ...      Go Back To The Main Menu      ...");
            Console.WriteLine("_________________________________________________\n");
            Console.WriteLine("Please Enter your Choice");
        }
    }
}
