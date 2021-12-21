using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CertifiedIdiot.InputHandler;
namespace LLGenealogi.Menus
{
    internal static class MenuListPeople
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("1) List by first letter of name.\n" +
                "2) List by year of birth.\n" +
                "3) List all.");

            CRUD crud = new CRUD();            

            switch (ConsoleToInt())
            {
                // By letter
                case 1:
                    
                    Console.WriteLine("Insert a letter: ");
                    string str = ConsoleToString(singleInput: true);
                    var list = crud.listPeople(str);
                    foreach (var p in list)
                    {
                        Console.WriteLine(p.Name + " " + p.LastName);
                    }
                    break;

                // By year
                case 2:
                    Console.WriteLine("Insert year: ");
                    int year = ConsoleToInt();
                    foreach(var p in crud.listPeople(year))
                    {
                        Console.WriteLine(p.Name);
                    }                    
                    break;

                // All
                case 3:
                    foreach(var p in crud.listPeople())
                    {
                        Console.WriteLine(p.Name + " " + p.LastName);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid menu choice.");
                    break;
            }
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadKey();
            Menus.MenuMain.Start();
        }
    }
}
