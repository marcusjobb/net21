using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CertifiedIdiot.InputHandler;
using LLGenealogi.Models;

namespace LLGenealogi.Menus
{
    internal static class MenuMain
    {
        public static void Start()
        {
            CRUD crud = new CRUD();
            var person = new Person();

            Console.Clear();
            Console.WriteLine("1) Create person in the Db.\n" +
                "2) Edit a persons information in the Db.\n" +
                "3) Delete a person from the Db.\n" +
                "4) List people under certain criteria.\n" +
                "5) View a persons parents.\n" +
                "6) View a persons siblings.\n" +
                "7) Seed Db");

            switch (ConsoleToInt())
            {
                // Create person.
                case 1:
                    MenuCreatePer.Start();
                    return;

                // Edit a persons information.
                case 2:
                    MenuEditPerInfo.Start();
                    break;

                // Delete a person.
                case 3:
                    Console.Clear();
                    Console.WriteLine("Which person do you wish to delete?");
                    Console.WriteLine("\n First name: ");
                    person = crud.Read(ConsoleToString());
                    crud.Delete(person);
                    Start();
                    break;

                // List people under critera:
                // 1. Name begins on a certain letter.
                // 2. Born a certain year.
                // 3. All
                case 4:
                    MenuListPeople.Start();
                    break;

                // View a persons parents.
                case 5:
                    MenuViewParents.Start();
                    break;

                // View a persons siblings.
                case 6:
                    MenuViewSiblings.Start();
                    break;

                case 7:
                    LLGenealogi.Database.Seed.Start();
                    break;
                default:
                    Console.WriteLine("Error: Invalid menu choice.");
                    break;
            }
        } 
    }
}
