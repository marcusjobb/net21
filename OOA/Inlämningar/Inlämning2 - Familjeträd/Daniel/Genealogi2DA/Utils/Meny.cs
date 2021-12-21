using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Genealogi2DA.Utils
{
    public class StarkMenu
    {
        public void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            FamTree famTree = new();
            famTree.Thestarks();
            Crudpeople Crudpeople = new Crudpeople();



            bool start = true;
            for (int a = 5; a >= 0; a--)
            {
                Console.Write("\rStark Family is coming in {0:00}", a);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                             @ @ @ @ @ @ @ @ @ @     ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                 STARK FAMILY");
            Console.WriteLine("");
            Console.WriteLine("                             @ @ @ @ @ @ @ @ @ @     ");
            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.Clear();

            while (start)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("Welcome to Genealogi DA, GoT version");
                Console.WriteLine("************************************");
                Console.WriteLine("1) List all family members");
                Console.WriteLine("2) List siblings");
                Console.WriteLine("3) List children");
                Console.WriteLine("4) List grandparents");
                Console.WriteLine("5) List familymembers birthyear");
                Console.WriteLine("6) List familymember by first letter");
                Console.WriteLine("7) Delete family member");
                Console.WriteLine("8) Edit family member");
                Console.WriteLine("9) Create a brand new family member");
                Console.WriteLine("10) Exit");

                                                
                int.TryParse(Console.ReadLine(), out int menuSelect);

                switch (menuSelect)
                {
                    case 1:
                        Crudpeople.ListAll();
                        Console.Clear();
                        break;
                    case 2:
                        Crudpeople.GetSiblings();
                        Console.Clear();
                        break;
                    case 3:
                        Crudpeople.GetChildren();
                        Console.Clear();
                        break;
                    case 4:
                        Crudpeople.GetGrandParents();
                        Console.Clear();
                        break;

                        case 5:
                        Crudpeople.InputBirthYear();
                        Console.Clear();
                        break;
                        case 6:
                        Crudpeople.InputFirstLetter();
                        Console.Clear();
                        break;
                    
                    case 7:
                        Crudpeople.DeleteMember();
                        Console.Clear();
                        break;
                    case 8:
                        Crudpeople.EditMember();
                        Console.Clear();
                        break;
                    case 9:
                        Crudpeople.Create();
                        Console.Clear();
                        break;
                    case 10:
                        start = false;
                        break;

                    default:
                        Console.WriteLine("Select a number between 1-10.");
                        Console.ReadKey();

                        break;
                }
            }
        }
    }
}
