using System;
using ChatUpNameList.DTO;
using ChatUpNameList.Helper;

namespace ChatUpNameList.App
{
    internal class ContactList
    {
        // Position for inputs
        private const int CursorPos = 18;
        // The helper
        private readonly ContactHelper contacts = new();
        
        /// <summary>
        /// The main menu
        /// </summary>
        internal void Menu()
        {
            bool repeat = true;
            while (repeat)
            {
                ShowMainHeader();
                Console.WriteLine("1 - List contacts");
                Console.WriteLine("2 - List contacts by first letter");
                Console.WriteLine("3 - Create contact");
                Console.WriteLine("4 - Read contact");
                Console.WriteLine("5 - Update contact");
                Console.WriteLine("6 - Delete contact");
                Console.WriteLine("7 - List ghosted");
                Console.WriteLine("8 - List blocked");
                Console.WriteLine("9 - Exit");
                int choice = 0;
                while (choice < 1 || choice > 9)
                {
                    Console.Write("Your choice: ");
                    var input = Console.ReadLine();
                    _ = int.TryParse(input, out choice);
                }

                switch (choice)
                {
                    case 1: ListContacts(); break;
                    case 2: ListContactsByFirstLetter(); break;
                    case 3: CreateContact(); break;
                    case 4: ReadContact(); break;
                    case 5: UpdateContact(); break;
                    case 6: DeleteContact(); break;
                    case 7: ListContactsGhosted(); break;
                    case 8: ListContactsBlocked(); break;
                    default:
                        repeat = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Lists only blocked contacts
        /// </summary>
        private void ListContactsBlocked()
        {
            ShowMainHeader();
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts.Fetch(i);
                if (contact.IsBlocked)
                {
                    PrintPerson(contact);
                }
            }
            Pause();
        }

        /// <summary>
        /// Prints listview version of a person
        /// </summary>
        /// <param name="contact"></param>
        private static void PrintPerson(Person contact)
        {
            Console.Write(contact.Name + " " + contact.Lastname + " aka " + contact.Alias);
            if (contact.DateOfBirth!=default)
                Console.Write(", born on " + contact.DateOfBirth.ToLongDateString());
            if (contact.IsGhosted || contact.IsBlocked)
            {
                Console.Write("  [");
                Console.ForegroundColor = ConsoleColor.Red;
                if (contact.IsGhosted) Console.Write(" Ghosted ");
                if (contact.IsBlocked) Console.Write(" Blocked ");
                Console.ResetColor();
                Console.Write("]");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Lists only ghosted contacts
        /// </summary>
        private void ListContactsGhosted()
        {
            ShowMainHeader();
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts.Fetch(i);
                if (contact.IsGhosted)
                {
                    PrintPerson(contact);
                }
            }
            Pause();
        }
        /// <summary>
        /// Lists only contacts that starts with...
        /// </summary>
        private void ListContactsByFirstLetter()
        {
            ShowMainHeader();
            Console.WriteLine("What first letter are you looking for?");
            var input = Console.ReadLine();

            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts.Fetch(i);
                if (contact.Alias.ToLower().StartsWith(input.ToLower()))
                {
                    PrintPerson(contact);
                }
            }
            Pause();
        }

        /// <summary>
        /// Update a contact
        /// </summary>
        private void UpdateContact()
        {
            ShowMainHeader();
            Console.WriteLine("What alias do you want to edit?");
            var input = Console.ReadLine();
            if (input == null) input = "";
            var found = contacts.Find(input);
            if (found == null)
            {
                Console.WriteLine("Nothing found");
                Pause();
                return;
            }
            else
            {
                ShowMainHeader();
                Console.WriteLine("Fill in the you want to change, use space to clear the field");
                PrintColumnView(found);
                var newPerson = new Person
                {
                    Name = GetPositionedInput(found.Name),
                    Lastname = GetPositionedInput(found.Lastname),
                    Alias = GetPositionedInput(found.Alias),
                    DateOfBirth = GetPositionedDateTime(found.DateOfBirth),
                    Email = GetPositionedInput(found.Email),
                    Webpage = GetPositionedInput(found.Webpage),
                    LinkedIn = GetPositionedInput(found.LinkedIn),
                    Facebook = GetPositionedInput(found.Facebook),
                    Instagram = GetPositionedInput(found.Instagram),
                    Twitter = GetPositionedInput(found.Twitter),
                    Github = GetPositionedInput(found.Github),
                    FavFood = GetPositionedInput(found.FavFood),
                    HateFood = GetPositionedInput(found.HateFood),
                    Animal = GetPositionedInput(found.Animal),
                    MovieGenre = GetPositionedInput(found.MovieGenre),
                    IsGhosted = GetPositionedBool(found.IsGhosted),
                    IsBlocked = GetPositionedBool(found.IsBlocked)
                };
                contacts.Update(found, newPerson);
                contacts.BubbleSort();
            }
        }

        /// <summary>
        /// Generates dummy data
        /// </summary>
        internal void Seed()
        {
            contacts.Add(new Person { Name = "Marcus", Lastname = "Medina", Alias = "Marmed", Email = "marcus.medina@codic.se", Github = "https://github.com/marcusjobb/", Webpage = "http://marcusmedina.pro", MovieGenre = "Horror", Animal = "Cat" });
            contacts.Add(new Person { Name = "James", Lastname = "Sunderland", Alias = "James", IsGhosted = true, Animal = "Teddybear", Webpage = "https://silenthill.fandom.com/wiki/James_Sunderland" });
            contacts.Add(new Person { Name = "Cheryl", Lastname = "Mason", Alias = "Heather Morris", Animal = "Robbie the rabbit", Webpage = "https://silenthill.fandom.com/wiki/Heather_Mason" });
            contacts.BubbleSort();
        }

        /// <summary>
        /// Searches for a given contact to delete
        /// </summary>
        private void DeleteContact()
        {
            ShowMainHeader();
            Console.WriteLine("What alias do you want to delete?");
            var input = Console.ReadLine();
            if (input == null) input = "";
            var found = contacts.Find(input);
            if (found == null)
            {
                Console.WriteLine("Nothing found");
                Pause();
                return;
            }
            else
            {
                contacts.Delete(found);
            }
        }

        /// <summary>
        /// Creates a contact
        /// </summary>
        private void CreateContact()
        {
            ShowMainHeader();
            Console.WriteLine("Fill in the data");
            PrintColumnView();
            var newPerson = new Person
            {
                Name = GetPositionedInput(),
                Lastname = GetPositionedInput(),
                Alias = GetPositionedInput(),
                DateOfBirth = GetPositionedDateTime(),
                Email = GetPositionedInput(),
                Webpage = GetPositionedInput(),
                LinkedIn = GetPositionedInput(),
                Facebook = GetPositionedInput(),
                Instagram = GetPositionedInput(),
                Twitter = GetPositionedInput(),
                Github = GetPositionedInput(),
                FavFood = GetPositionedInput(),
                HateFood = GetPositionedInput(),
                Animal = GetPositionedInput(),
                MovieGenre = GetPositionedInput(),
                IsGhosted = GetPositionedBool(false),
                IsBlocked = GetPositionedBool(false)
            };
            contacts.Add(newPerson);
            contacts.BubbleSort();
        }

        /// <summary>
        /// Creates a fancy input
        /// </summary>
        /// <param name="date">The date from the original field, or just empty</param>
        /// <returns>A date</returns>
        private static DateTime GetPositionedDateTime(DateTime date = default)
        {
            if (date == default)
            {
                Console.CursorLeft = CursorPos;
                Console.Write("yyyy-mm-dd                               ");
            }
            Console.CursorLeft = CursorPos;
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                if (date == default) return new DateTime();
                return date;
            }
            DateTime.TryParse(input, out date);
            return date;
        }

        /// <summary>
        /// Creates a fancy input
        /// </summary>
        /// <param name="data">The text from the original field, or just empty</param>
        /// <returns>The text entered or the default value</returns>
        private static string GetPositionedInput(string data = "")
        {
            Console.CursorLeft = CursorPos;
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(data)) data = "";
            if (string.IsNullOrEmpty(input)) input = data;
            return input.Trim();
        }

        /// <summary>
        /// Creates a fancy input
        /// </summary>
        /// <param name="data">The value from the original field, or just false</param>
        /// <returns>a boolean</returns>
        private static bool GetPositionedBool(bool data)
        {
            Console.CursorLeft = CursorPos;
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) input = data.ToString();
            input = input.ToLower().Trim();
            bool retVal = false;
            if (input[0] == 'y' || input[0] == 't') retVal = true;
            return retVal;
        }
        /// <summary>
        /// Prints a person or an empty template for a person
        /// </summary>
        /// <param name="person"></param>
        private static void PrintColumnView(Person person = null)
        {
            var pos = Console.CursorTop;
            if (person == null) person = new Person();
            person.Print();
            Console.CursorTop = pos;
        }

        /// <summary>
        /// The main header
        /// </summary>
        private void ShowMainHeader()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("- Welcome to the contact list                      -");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"There are {contacts.Count} in the list.");
            Console.WriteLine();
        }

        /// <summary>
        /// The pause function
        /// </summary>
        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("-                           Press Enter to proceed -");
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
        }
        /// <summary>
        /// Search for a contact
        /// </summary>
        private void ReadContact()
        {
            ShowMainHeader();
            Console.WriteLine("What alias are you looking for?");
            var input = Console.ReadLine();
            if (input == null) input = "";
            var found = contacts.Find(input);
            if (found == null)
            {
                Console.WriteLine("Nothing found");
            }
            else
            {
                found.Print();
            }
            Pause();
        }

        /// <summary>
        /// List all contacts
        /// </summary>
        private void ListContacts()
        {
            ShowMainHeader();
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts.Fetch(i);
                PrintPerson(contact);
            }
            Pause();
        }
    }
}