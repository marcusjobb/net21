using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLGenealogi.Models;
using static CertifiedIdiot.InputHandler;

namespace LLGenealogi.Menus
{
    internal static class MenuViewSiblings
    {
        public static void Start()
        {
            CRUD crud = new CRUD();
            Person person = new Person();

            Console.Clear();
            Console.WriteLine("Insert a name to see said persons siblings.\n");
            Console.WriteLine("Name: ");
            person = crud.Read(ConsoleToString());
            if (person == null)
            {
                Console.WriteLine("Invalid Person.");
                Thread.Sleep(1000);
                MenuMain.Start();
                return;
            }

            Console.Clear();
            Console.WriteLine("Siblings: \n");
            foreach(var p in crud.listPeopleSiblings(person))
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("Enter to continue.");
            Console.ReadKey();

            MenuMain.Start();
        }
    }
}
