using System;
using System.Collections.Generic;

namespace Chat_The_F_Up_
{
    class Program
    {
        internal static List<Person> ContactList = new List<Person>();


        private static void Main(string[] args)
        {
            InitContactList();
            Menu();
        }

        private static void InitContactList()
        {
            ContactList.Add(new Person
            {
                Age = 24,
                FirstName = "Ahmed",
                LastName = "Adam",
                Alias = "Salah",
                AvskyMat = "Fläsk",
                EmailAdress = "96ahmada@gafe.molndal.se",
                FavoritDjur = "Tiger",
                FavoritFilmGenre = "Thriller",
                FavoritMat = "Pizza",
                LinkedIn = "Ahmed Adam",
            });
        }

        private static void Menu()
        {
            while (true)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Welcome to Chat the F Up: ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("\n[1]\tContacts \n[2]\tContact Information \n[3]\tRemove User \n[4]\tAdd User \n[n]\tExit Program");

                string Menu = Console.ReadLine();
                string menuChoice = Menu.ToUpper();

                switch (menuChoice)
                {
                    case "1":
                        Contacts();
                        continue;
                    case "2":
                        ContactInfo();
                        continue;
                    case "3":
                        RemovePerson();
                        continue;
                    case "4":
                        AddPerson();
                        continue;
                    case "n":
                    case "N":
                        Console.WriteLine("Thank you for your time");
                        return;

                    default:
                        Console.WriteLine("Invalid choice try again!");
                        continue;
                }
            }
        }

        private static void Contacts()
        {
            foreach (var person in ContactList)
            {
                Console.WriteLine($"{{0}},", person.FirstName);
            }
            Console.WriteLine("Press Enter to exit to menu");
            Console.ReadLine();
            Console.Clear();
        }
        
        private static void ContactInfo()
        {
            Console.Clear();
            foreach (var person in ContactList)
            {
                Console.WriteLine($" FirstName:{{0}}\n LastName: {{1}}\n Age: {{2}}\n Alias: {{3}}\n EmailAdress: {{4}}\n LinkedIn: {{5}}\n Avskymat: {{6}}\n FavoritMat: {{7}}\n FavoritDjur: {{8}}\n FavoritFilmGenre: {{9}}\n"
                    , person.FirstName, person.LastName, person.Age, person.Alias, person.EmailAdress, person.LinkedIn, person.AvskyMat, person.FavoritMat, person.FavoritDjur, person.FavoritFilmGenre);
            }
            Console.ReadLine();
            Console.Clear();
        }
        private static void RemovePerson()
        {
            Console.Clear();

            if (ContactList.Count == 0)
            {
                Console.WriteLine("You have no contacts");
                return;
            }

            for (int i = 0; i < ContactList.Count; i++)
            {
                Console.WriteLine($" {i + 1} {ContactList[i].FirstName}");
            }

            Console.WriteLine("Write the index of the person you want to remove");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    if (!(index > ContactList.Count || index < 0))
                    {
                        var personToRemove = ContactList[index - 1]; //  ContactList[index - 1];
                        if (personToRemove != null)
                        {
                            ContactList.RemoveAt(index - 1); // ContactList.Remove(personToRemove)
                            break;
                        }
                    }
                    Console.Write("Please enter a valid index: ");
                }
            }
            Console.Clear();
        }

        public static void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter FirstName: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter LastName: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out int age))
                {
                    person.Age = age;
                    break;
                }
                Console.Write("Please enter a valid age: ");
            }

            Console.Write("Enter Alias: ");
            person.Alias = Console.ReadLine();

            Console.Write("Enter Emailadress: ");
            person.EmailAdress = Console.ReadLine();

            Console.Write("Enter LinkedIn: ");
            person.LinkedIn = Console.ReadLine();

            Console.Write("Enter AvskyMat: ");
            person.AvskyMat = Console.ReadLine();

            Console.Write("Enter FavoritMat: ");
            person.FavoritMat = Console.ReadLine();

            Console.Write("Enter FavoritDjur: ");
            person.FavoritDjur = Console.ReadLine();

            Console.Write("Enter Favorit Film-Genre: ");
            person.FavoritFilmGenre = Console.ReadLine();
            ContactList.Add(person);
            Console.Clear();
        }
    }
}
