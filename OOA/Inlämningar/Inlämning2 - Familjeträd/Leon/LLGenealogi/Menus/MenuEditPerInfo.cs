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
    internal static class MenuEditPerInfo
    {
        public static void Start()
        {
            Console.Clear();            
            CRUD crud = new CRUD();
            Person person = new Person();
            Person mother = new Person();
            Person father = new Person();

            Console.WriteLine("What person do you wish to edit?\n" +
                "First name: ");
            string nameOfEdit = ConsoleToString();
            if(!crud.ValidPerson(nameOfEdit))
            {
                Console.WriteLine("Invalid person.");
                Thread.Sleep(1000);
                MenuMain.Start();
                return;
            }
            Console.Clear();

            // Edit name
            Console.WriteLine("Edit name?");
            if (YesNoChoice())
            {
                string personName = ConsoleToFullName();

                person.Name = personName.Split(' ').First();
                person.LastName = personName.Split(' ').Last();
                Console.WriteLine(person.Name);
                Console.WriteLine(person.LastName);
            }
            Thread.Sleep(2000);
            Console.Clear();

            // Edit birth
            Console.WriteLine("Edit year of birth?");            
            if (YesNoChoice())
            {
                Console.WriteLine("\nYear of birth: ");
                person.YearOfBirth = ConsoleToInt();
            }
            Console.Clear();

            // Edit mother
            Console.WriteLine("Do you wish to edit mother?");
            if (YesNoChoice())
            {
                Console.WriteLine("Mother: ");
                string strMotherName = ConsoleToFullName();
                if (!crud.ValidPerson(strMotherName.Split(' ').First()))
                {
                    mother.Name = strMotherName.Split(' ').First();
                    mother.LastName = strMotherName.Split(' ').Last();
                    crud.Create(mother);
                    person.Mor = crud.Read(mother.Name).Id;
                    crud.Save();
                }
                else
                {
                    person.Mor = crud.Read(strMotherName.Split(' ').First()).Id;
                }
            }

            // Edit father
            Console.WriteLine("Do you wish to edit Father?");
            if (YesNoChoice())
            {
                Console.WriteLine("Father: ");
                string strFatherName = ConsoleToFullName();
                if (!crud.ValidPerson(strFatherName.Split(' ').First()))
                {
                    father.Name = strFatherName.Split(' ').First();
                    father.LastName = strFatherName.Split(' ').Last();
                    crud.Create(father);
                    person.Far = crud.Read(father.Name.Split(' ').First()).Id;
                    crud.Save();
                }
                else
                {
                    person.Far = crud.Read(strFatherName.Split(' ').First()).Id;
                }
            }

            crud.Update(person, nameOfEdit);
            MenuMain.Start();
        }
    }
}
