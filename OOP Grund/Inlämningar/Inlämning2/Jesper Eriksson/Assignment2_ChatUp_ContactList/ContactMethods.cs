using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatUp_ContactList.Extensions;
using ChatUp_ContactList.HelperMethods;
using static ChatUp_ContactList.HelperMethods.StringHelpers;
using static ChatUp_ContactList.HelperMethods.UserExperience;
using static ChatUp_ContactList.HelperMethods.DisplayHelper;

namespace ChatUp_ContactList
{
    internal static class ContactMethods
    {
        #region Add a contact
        /// <summary>
        /// Creates a new Person object, using the constructor and optional properties. Stores the created object in the People list.
        /// </summary>
        /// <param name="People"></param>
        internal static void AddPerson(List<Person> People)
        {
            MenuHeader("Add a person to the contact list. ");
            var newPerson = GetNewPersonProtecteds();
            var addOptionals = QuestionAndAnswer("\nIf you would like to add optional information to the contact, press \"Y\". Otherwise, press enter.");
            if (addOptionals.ToUpper() == "Y")
            {
                GetPersonOptionalInformation(newPerson);
            }
            People.Add(newPerson);
            Console.WriteLine($"Succesfully added contact \"{newPerson.Name}\".");
            PressKeyToContinue();
        }

        // Method which returns the constructor for the mandatory Person object properties.
        private static Person GetNewPersonProtecteds()
        {
            Console.WriteLine("\nName | Surename | Date of birth | Alias | Email | Favourite food | Least favourite food\n");
            return new Person(
            ReceiveValidatedInput.PlainText("Name: "),
            ReceiveValidatedInput.PlainText("Surename: "),
            ReceiveValidatedInput.DateOfBirth("Date of birth | YYYY/MM/DD: "),
            ReceiveValidatedInput.StringNotEmpty("Alias: "),
            ReceiveValidatedInput.Email("Email: "),
            ReceiveValidatedInput.StringNotEmpty("Favourite food: "),
            ReceiveValidatedInput.StringNotEmpty("Least favourite food: ")
            );
        }

        // Method which allows the user to input the optional properties for the Person object.
        private static void GetPersonOptionalInformation(Person newPerson)
        {
            Console.Clear();
            MenuHeader("Add optional information");
            Console.WriteLine("\nFavourite Animal | Favourite Movie Genre  | Twitter | Instagram | Facebook | LinkedIn | GitHub ");
            Console.WriteLine("\nLeave empty to skip.\n");
            newPerson.FavouriteAnimal = QuestionAndAnswerSameLine("Favourite animal: ").CapitalisedNTrimmed();
            newPerson.FavouriteMoviegenre = QuestionAndAnswerSameLine("Favourite movie genre: ").CapitalisedNTrimmed();
            newPerson.SocialsTwitter = QuestionAndAnswerSameLine("Twitter: ");
            newPerson.SocialsInstagram = QuestionAndAnswerSameLine("Instagram: ");
            newPerson.SocialsFacebook = QuestionAndAnswerSameLine("Facebook: ");
            newPerson.SocialsLinkedin = QuestionAndAnswerSameLine("LinkedIn: ");
            newPerson.SocialsGithub = QuestionAndAnswerSameLine("GitHub: ");
        }
        #endregion
        //  ------------------------------------------------------------------------------------
        #region Remove and Edit
        /// <summary>
        /// Lets the user choose a specifik Person object to remove from the People list.
        /// </summary>

        internal static void RemovePerson()
        {
            bool deleteUser = false;
            Console.Clear();
            MenuHeader("Remove a Contact");
            Console.WriteLine("\nWho would you like to remove? Select the corresponding ID.\n");
            int selectedIndex = DisplayContactsSelectIndex("Enter the ID to remove.\nID:");
            if (selectedIndex > 0)
            {
                var deleteUserInput = QuestionAndAnswer("\nAre you sure you wish to delete the selected contact? Press \"Y\" for YES or \"N\" for NO. ");
                if (deleteUserInput.ToUpper() == "Y")
                {
                    deleteUser = true;
                }
                else if (deleteUserInput.ToUpper() == "N")
                {
                    Console.WriteLine("The user has not been deleted");
                    PressKeyToContinue();
                }
                else
                {
                    Console.WriteLine("No valid input selected. Returning to Menu");
                    PressKeyToContinue();
                }
                if (deleteUser)
                {
                    Contacts.People.RemoveAt(selectedIndex - 1);
                    //Console.Clear();
                    Console.WriteLine("The selected contact has been deleted.");
                    PressKeyToContinue();
                }
            }
        }
        //  ------------------------------------------------------------------------------------

        /// <summary>
        /// Method which lets the user pick a valid contact inside the contact list. The chosen contact can then be edited with the help of a menu.
        /// Allows the user to set new properties in the Person constructor. Allows the user to add or edit the optional Person properties, and also lets the user flag or unflag a contact.
        /// </summary>
        internal static void EditPerson()
        {
            Console.Clear();
            MenuHeader("Edit Contact");
            int selectedIndex = DisplayContactsSelectIndex("Enter the contact ID you would like to edit.\n");
            if (selectedIndex > 0)
            {
                Console.WriteLine("What would you like to edit:\n");
                Console.WriteLine("[1] - Replace protected information, such as name, email, date of birth.");
                Console.WriteLine("[2] - Edit or add optional properties, such as social media links.");
                Console.WriteLine("[3] - Flag the user.");
                int.TryParse(Console.ReadLine(), out int menuChoice);
                // Contacts.People[selectedIndex -1] is the currently selected contact, retrieved from the DisplayContactsSelectIndex method. The user has selected the proper index plus 1, so the user can choose from the index starting from 1 instead of 0.
                // but here we want the actual index, so we remove 1 from the users choice.
                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        MenuHeader("You are currently editing:");
                        Console.WriteLine(Contacts.People[selectedIndex - 1].ToString());
                        Contacts.People[selectedIndex - 1] = GetNewPersonProtecteds(); // A "new" constructor for the Person object overwrites the previous properties, in this way the user gets to replace/edit the properties for a person.
                        Console.WriteLine("\nContact has been succesfully updated.");
                        PressKeyToContinue();
                        break;
                    case 2:
                        GetPersonOptionalInformation(Contacts.People[selectedIndex - 1]); // The user gets to edit or add the optional properties for the current selected index.
                        Console.WriteLine("\nContact has been succesfully updated.");
                        PressKeyToContinue();
                        break;
                    case 3:
                        FlagSelectedUser(selectedIndex);
                        break;
                    default:
                        Console.WriteLine("Returning to menu..");
                        PressKeyToContinue();
                        break;
                }
            }
        }
        #endregion
        //  ------------------------------------------------------------------------------------

        // Method which allows the user to flag a selected contact.
        private static void FlagSelectedUser(int selectedIndex)
        {
            Console.Clear();
            MenuHeader("Flag a Contact");
            Console.WriteLine("\nFlag the current contact. Which flag would you like to change?\n");
            Console.WriteLine("[1] - Change flag status of Ghosted.");
            Console.WriteLine("[2] - Change flag status of Blocked.");
            Console.WriteLine("\nCurrent flag status: ");
            Console.WriteLine($"Ghosted: {Contacts.People[selectedIndex - 1].IsGhosted} | Blocked: {Contacts.People[selectedIndex - 1].IsBlocked} ");
            var userInput = Console.ReadLine().ToInt();
            if (userInput == 1)
            {
                // If the selected person already is blocked or ghosted, the value gets flipped. This way the flag choice acts as a toggle, which seemed appropriate.
                if (Contacts.People[selectedIndex - 1].IsGhosted == true)
                    Contacts.People[selectedIndex - 1].IsGhosted = false;
                else
                    Contacts.People[selectedIndex - 1].IsGhosted = true;
                Console.WriteLine($"Contacts ghosted flag has been updated to {Contacts.People[selectedIndex - 1].IsGhosted}.");
                PressKeyToContinue();
            }
            else if (userInput == 2)
            {
                if (Contacts.People[selectedIndex - 1].IsBlocked == true)
                    Contacts.People[selectedIndex - 1].IsBlocked = false;
                else
                    Contacts.People[selectedIndex - 1].IsBlocked = true;
                Console.WriteLine($"Contacts blocked flag has been updated to {Contacts.People[selectedIndex - 1].IsBlocked}.");
                PressKeyToContinue();
            }
            else
            {
                Console.WriteLine("Returning to menu..");
                PressKeyToContinue();
            }
        }
        //  ------------------------------------------------------------------------------------

        #region Display users and Index
        /// <summary>
        /// Lets the user see basic information about each contact added. The user can then select the index of a person to view the full contact information. 
        /// This way, if the contact list has a lot of entries, the user wont have to scroll around in the console as much.
        /// Also returns an int of the selected index, so this method can be reused for other methods which depend on an index.
        /// </summary>
        internal static int DisplayContactsSelectIndex(string message)
        {
            // If the method can't retrieve a valid index, it will return -1 as a value instead of a proper index position. We can therefore assume that if the value is 0 or above, this method must have found 
            // and stored a valid index. Can be used as a conditional. 
            int selectedIndex = -1;
            if (Contacts.People.Count == 0)
            {
                Console.WriteLine("There are no contacts added");
                PressKeyToContinue();
            }
            else
            {
                DisplayPeopleWithIndex();
                Console.WriteLine(message);
                selectedIndex = PeopleChooseIndex();
                return selectedIndex; // Returns valid index.
            }
            return selectedIndex; // Returns the invalid index.
        }
        //  ------------------------------------------------------------------------------------

        /// <summary>
        /// Method meant to let the user pick an index from the People list. If the index cannot be found, it returns 0 instead of the proper index. This method is meant to be used in conjuction with another method,
        /// so the non valid return value doesn't really matter much here, since it's "replaced" in the other method. See DisplayContactsSelectIndex().
        /// </summary>
        /// <returns></returns>
        internal static int PeopleChooseIndex()
        {
            var idMatch = false;
            var idInput = Console.ReadLine().ToInt();
            foreach (var person in Contacts.People)
            {
                if (idInput == Contacts.People.IndexOf(person) + 1)
                {
                    idMatch = true;
                    Console.Clear();
                    MenuHeader($"Now viewing user: {person.Name}.");
                    Console.WriteLine(person.ToString());
                    return idInput;
                }
            }
            if (!idMatch)
            {
                Console.WriteLine("No such ID found.");
                PressKeyToContinue();
            }
            else
            {
                Console.WriteLine("Not a valid input. Returning to menu..");
                PressKeyToContinue();
            }    
            return 0;
        }
        //  ------------------------------------------------------------------------------------
        
        // Method which displays compacted information about the people in the list. The index gets a +1 added, in order to start displaying from 1 rather than 0, for user convenience.
        // In order to retrieve the real value in future methods, subtract 1 instead.
        internal static void DisplayPeopleWithIndex()
        {
            Console.WriteLine("\nThe following contacts have been added:\n");
            Console.WriteLine("\tID\t|\tName \t|\tAlias \t|\tAge\n");
            foreach (var person in Contacts.People)
            {
                Console.WriteLine($"\t[{Contacts.People.IndexOf(person) + 1}]\t| { person.Name} { person.Surename} | Alias: {person.Alias} | Age: {person.Age}\n");
            }
        }
        //  ------------------------------------------------------------------------------------
        #endregion
        /// <summary>
        /// Displays every contact which is flagged as either blocked or ghosted.
        /// </summary>
        internal static void DisplayFlaggedContacts()
        {
            var flaggedFound = false;
            if (Contacts.People.Count == 0)
            {
                Console.WriteLine("There are no contacts added");
                PressKeyToContinue();
            }
            else
            {
                foreach (var person in Contacts.People)
                {
                    if (person.IsBlocked)
                    {
                        flaggedFound = true;
                        Console.WriteLine("\nThe following users are flagged as blocked:\n\n" + person);
                    }
                    if (person.IsGhosted)
                    {
                        flaggedFound = true;
                        Console.WriteLine("\nThe following users are flagged as ghosted:\n\n" + person);
                    }
                }
                if (!flaggedFound)
                    Console.WriteLine("No flagged users found.");
                PressKeyToContinue();
            }
        }
        //  ------------------------------------------------------------------------------------

        /// <summary>
        /// Lets the user search for the first letter in a name, displays the corresponding contacts in full if a match is found.
        /// </summary>
        /// <param name="input"></param>
        internal static void SearchForLetter(string input)
        {
            var matchFound = false;
            Console.Clear();
            MenuHeader("Search by Letter");
            Console.WriteLine("\nFound the following contacts:");
            foreach (var person in Contacts.People)
            {
                if (person.Name.FirstLetter().ToUpper() == input.ToUpper())
                {
                    matchFound = true;
                    
                    Console.WriteLine("\n"+person.ToString() + "\n");
                }
            }
            if (!matchFound)
            {
                Console.WriteLine("No match found.");
            }
            PressKeyToContinue();
        }
        //  ------------------------------------------------------------------------------------

        /// <summary>
        /// Lets the user view if there are any birthdays this current month. If there are, displays the contacts in full.
        /// </summary>
        internal static void DisplayBirthdays()
        {
            Console.Clear();
            MenuHeader("Viewing birthdays.");
            Console.WriteLine("\n\tThe following users have a birthday this month:\n");
            bool birthdayMatch = false;
            foreach (var person in Contacts.People)
            {
                if (person.DateOfBirth.Month == DateTime.Now.Month)
                {
                    birthdayMatch = true;
                    Console.WriteLine(person + "\n");
                }
            }
            if (!birthdayMatch)
            {
                Console.WriteLine("No upcoming birthdays this month.");
            }
            PressKeyToContinue();
        }
        //  ------------------------------------------------------------------------------------
    }
}
