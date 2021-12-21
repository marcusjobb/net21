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
    internal static class MenuCreatePer
    {
        public static void Start()
        {
            CRUD crud = new CRUD();
            Console.Clear();
            Person person = new Person();

            Console.WriteLine("Enter a first name.\n");
            person.Name = ConsoleToString();
            Console.WriteLine("\nEnter a surname.\n");
            person.LastName = ConsoleToString();
            
            crud.Create(person);
            Thread.Sleep(2000);
            MenuMain.Start();
        }
    }
}
