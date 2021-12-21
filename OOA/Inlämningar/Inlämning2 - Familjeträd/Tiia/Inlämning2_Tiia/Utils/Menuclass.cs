using Inlämning2_Tiia.Utils;
using System;

namespace Inlämning2_Tiia
{
    class Menuclass
    {
        public static void Menu()
        {
            Visual.SpoilerAlert();
            
            while (true)
            {
                Visual.MainMenu();
                int menuChoise = UserInput(); 

                switch (menuChoise)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Parents();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Siblings(); 
                        break;
                    case 5:
                        Children(); 
                        break;
                    case 6:
                        Grandparents(); 
                        break;
                    case 7:
                        ListAll();
                        break;
                    case 8:
                        ByLetter();
                        break;
                    case 9:
                        Delete();
                        break;
                    case 10:
                        Console.WriteLine("See you soon!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Enter a number between 1-10.");
                        Console.ReadKey();
                        break;
                }
                PressEnter();
                Console.Clear();
            }
        }

        private static void Delete()
        {
            Console.Clear();
            Header("DELETE A PERSON");

            Write("\nHow fo you want to delete this person?\n");
            Write("[1] - by Id \n[2] - by name\n[3] - back to menu\n ");
            var input = UserInput();

            switch(input)
            {
                case 1:
                    PersonCrud.DisplayAll();
                    Write("Enter id: ");
                    var id = UserInput();
                    PersonCrud.DeleteById(id); 
                    break;
                case 2:
                    PersonCrud.DisplayAll();
                    AskForWholeName(out string firstName, out string lastName);
                    PersonCrud.DeleteByName(firstName, lastName); 
                    break;
                case 3:
                    break;
                default: 
                    Write("Enter 1 or 2"); 
                    break;
            }
        }

        private static void ByLetter()
        {
            Console.Clear();
            Console.Write("LIST BY LETTER\n");
            PersonCrud.ListByLetter();
        }

        private static void ListAll()
        {
            Console.Clear();
            Console.Write("LIST OF ALL THE PERSONS IN THE FAMILY TREE\n");
            PersonCrud.DisplayAll();
        }

        private static void Grandparents()
        {
            Console.Clear();
            HeaderAndName("SHOW GRANDPARENTS\t", out string firstName, out string lastName);
            PersonCrud.ShowGrandparents(firstName, lastName);
        }

        private static void Children()
        {
            Console.Clear();
            HeaderAndName("SHOW CHILDREN\t", out string firstName, out string lastName);
            PersonCrud.ShowChildren(firstName, lastName);
        }

        private static void Siblings()
        {
            Console.Clear();
            HeaderAndName("SHOW SIBLINGS\t",out string firstName, out string lastName);
            PersonCrud.FindSiblings(firstName, lastName);
        }

        private static void Update()
        {
            Console.Clear();
            HeaderAndName("UPDATE INFORMATION OF A PERSON\t", out string firstName, out string lastName);
            
            Write("Enter new first name: ");
            var newFirstName = Console.ReadLine();
            Write("Enter new last name: ");
            var newLastName = Console.ReadLine();
            
            PersonCrud.Update(firstName, lastName, newFirstName, newLastName);
        }

        private static void Parents()
        {
            Console.Clear();
            HeaderAndName("FIND / ADD PARENTS\t", out string firstName, out string lastName);
            PersonCrud.FindParents(firstName, lastName);
        }

        private static void Add()
        {
            Console.Clear();
            HeaderAndName("ADD PERSON\t", out string firstName, out string lastName);
            PersonCrud.FindAndCreate(firstName, lastName);
        }


        //-------------little helpers------------------------------------------------------------------

        private static void HeaderAndName(string header, out string firstName, out string lastName)
        {
            Header(header);
            AskForWholeName(out firstName, out lastName);
        }

        private static void AskForWholeName(out string firstName, out string lastName)
        {
            Write("\nEnter person's first name: ");
            firstName = Console.ReadLine();
            Write("Enter person's last name: ");
            lastName = Console.ReadLine();
        }

        private static void Header(string header)
        {
            Write("\t");
            Write(header);
            Write("\n\t----------------");
        }

        private static void Write(string message)
        {
            Console.Write(message);
        }

        private static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int menuChoise);
            return menuChoise;
        }

        private static void PressEnter()
        {
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }
    }
}


