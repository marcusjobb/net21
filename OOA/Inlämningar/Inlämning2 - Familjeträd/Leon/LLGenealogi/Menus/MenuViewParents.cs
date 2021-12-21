using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLGenealogi.Models;
using System.Threading;
using static CertifiedIdiot.InputHandler;

namespace LLGenealogi.Menus
{
    internal static class MenuViewParents
    {
        public static void Start()
        {
            CRUD crud = new CRUD();
            Person person = new Person();

            Console.Clear();
            Console.WriteLine("Insert a name to see said persons parents.\n");
            Console.WriteLine("Name: ");
            person = crud.Read(ConsoleToString());
            if(person == null)
            {
                Console.WriteLine("Invalid Person.");
                Thread.Sleep(1000);
                MenuMain.Start();
                return;
            }

            Console.Clear();
            Console.WriteLine("Mother: ");
            try
            {
                Console.WriteLine(crud.Read(person.Mor).Name);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nFather: ");
            try
            {
                Console.WriteLine(crud.Read(person.Far).Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            Console.WriteLine("Enter to continue.");
            Console.ReadKey();

            MenuMain.Start();
        }      
    }
}
