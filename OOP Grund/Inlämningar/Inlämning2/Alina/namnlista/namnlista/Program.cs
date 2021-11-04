using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace namnlista
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactList = new ContactList();

            while (true)
            {
                contactList.PrintMenu();
                ContactList.Choices choice;
                while (!Enum.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(ContactList.Choices), choice))
                {
                    Console.WriteLine("Please enter a valid choice");
                }

                switch (choice)
                {
                    case ContactList.Choices.AddPerson:
                        contactList.CreatePerson();
                        break;
                    case ContactList.Choices.UpdatePerson:
                        Console.WriteLine("Please add the name you wish to update: ");
                        var nameToUpdate = Console.ReadLine();
                        Console.WriteLine("Please write the name you want to update to: ");
                        var newName = Console.ReadLine();

                        contactList.UpdatePersonName(nameToUpdate, newName);
                        break;
                    case ContactList.Choices.DeletePerson:
                        Console.WriteLine("Enter name to delete from list: ");
                        var nameToDelete = Console.ReadLine();
                        contactList.DeletePersonByName(nameToDelete);
                        break;
                    
                    case ContactList.Choices.ListAllPersons: 
                        contactList.ListAllPersons();
                        break;

                    case ContactList.Choices.Exit:
                        return;
                }
            }
        }

        class Person
        {
            public string Name { get; set; }
            public string Lastname { get; set; }
            public string Mail { get; set; }
            public string Facebook { get; set; }
            public string Instagram { get; set; }
            public string Twitter { get; set; }
            public string FavoriteFood { get; set; }
            public string FavoriteFilm { get; set; }
            public DateTime DateOfBirth { get; set; }
            public bool IsGhosted { get; set; } = false;
            public bool IsBlocked { get; set; } = false;

            public Person(
                string Name,
                string Lastname,
                string Mail,
                string Facebook,
                string Instagram,
                string Twitter,
                string FavoriteFood,
                string FavoriteFilm,
                DateTime DateOfBirth
            )
            {
                this.Name = Name;
                this.Lastname = Lastname;
                this.Mail = Mail;
                this.Facebook = Facebook;
                this.Instagram = Instagram;
                this.Twitter = Twitter;
                this.FavoriteFood = FavoriteFood;
                this.FavoriteFilm = FavoriteFilm;
                this.DateOfBirth = DateOfBirth;
            }

            

            public void PrintInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Lastname: " + Lastname);
                Console.WriteLine("Mail: " + Mail);
                Console.WriteLine("Facebook: " + Facebook);
                Console.WriteLine("Instagram: " + Instagram);
                Console.WriteLine("Twitter: " + Twitter);
                Console.WriteLine("FavoriteFood: " + FavoriteFood);
                Console.WriteLine("FavoriteFilm: " + FavoriteFilm);
                Console.WriteLine("DateOfBirth: " + DateOfBirth.ToString("yyyy-MM-dd"));
                if (IsGhosted)
                {
                    Console.WriteLine("You're ghosted!");
                }
                if (IsBlocked)
                {
                    Console.WriteLine("You're blocked!");
                }
            }

        }

        class ContactList
        {
            private readonly List<Person> People = new();
            

            public ContactList()
            {
               
                People.AddRange(new Person[]
                    {
                    new Person("Isaac", "Asimov", "isaac@asimov.org", "fb", "insta", "twit", "Meatballs", "The day earth stood still", new DateTime(1920, 1, 2)),
                    new Person("Ernest", "Hemingway", "ernest@hemingway.org", "fb", "insta", "twit", "Bull steak", "Running with bulls", new DateTime(1899, 7, 21))
                    });

               

            }
        

            public void CreatePerson()
            {
                Console.WriteLine("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Lastname: ");
                var lastName = Console.ReadLine();
                Console.WriteLine("Mail: ");
                var mail = Console.ReadLine();
                Console.WriteLine("Facebook: ");
                var facebook = Console.ReadLine();
                Console.WriteLine("Instagram: ");
                var instagram = Console.ReadLine();
                Console.WriteLine("Twitter: ");
                var twitter = Console.ReadLine();
                Console.WriteLine("FavoriteFood: ");
                var favoriteFood = Console.ReadLine();
                Console.WriteLine("FavoriteFilm: ");
                var favoriteFilm = Console.ReadLine();
                Console.WriteLine("DateOfBirth (YYYY-MM-DD): ");
                DateTime dateOfBirth;
                while (!DateTime.TryParse(
                    Console.ReadLine(),
                    out dateOfBirth))
                {
                    Console.WriteLine("Invalid format on date of birth!");
                }

                People.Add(new Person(
                        name,
                        lastName,
                        mail,
                        facebook,
                        instagram,
                        twitter,
                        favoriteFood,
                        favoriteFilm,
                        dateOfBirth
                ));

            }

            public void ListAllPersons() 
            {
                Console.WriteLine("------ People --------");
                foreach (var person in People)
                {
                    person.PrintInfo();
                    Console.WriteLine("----------------");
                }

            }

            public void PrintInfoForPerson(string Name)
                 => People.Find(x => x.Name == Name)?.PrintInfo(); 

            public void UpdatePersonName(string name, string newName)
            {
                var person = People.Find(x => x.Name == name); 
                if (person != null)
                {
                    person.Name = newName;
                } else
                {
                    Console.WriteLine("There was no person with name " + name);
                }
            }

            public void DeletePersonByName(string name)
            {
                var index = People.FindIndex(x => x.Name == name); 

                if (index != -1)
                {
                    People.RemoveAt(index);
                } else
                {
                    Console.WriteLine("There is no person with name " + name);
                }
                
            }

            

            public void PrintMenu()
            {
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. Update person name");
                Console.WriteLine("3. Delete person");
                Console.WriteLine("4. List people");
                Console.WriteLine("5. Exit");
                
            }

            public enum Choices 
            {
                AddPerson = 1,
                UpdatePerson,
                DeletePerson,
                ListAllPersons,
                Exit
            }
        }
    }

}
