using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatUp_ContactList.HelperMethods;
using ChatUp_ContactList.Extensions;
using static ChatUp_ContactList.HelperMethods.DisplayHelper;
using static ChatUp_ContactList.HelperMethods.StringHelpers;
using static ChatUp_ContactList.HelperMethods.UserExperience;
using static ChatUp_ContactList.ContactMethods;

namespace ChatUp_ContactList
{
    public class Contacts
    {
        internal static List<Person> People = new List<Person>();

        #region Menus
        /// <summary>
        /// Displays the main menu and submenus of the Contacts class.
        /// </summary>
        public void Menu()
        {
            Colours();
            bool showMenu = true;
            while (showMenu)
            {
                MainMenuHeader();
                MenuItem("[1] - Add contact");
                MenuItem("[2] - View contacts");
                MenuItem("[3] - Edit and remove");
                MenuItemBottom("[4] - Quit");
                int.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        AddPerson(People);
                        break;
                    case 2:
                        MenuViewContacts();
                        break;
                    case 3:
                        MenuEditRemove();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Shutting down..");
                        ExitScreen();
                        PressKeyToContinue();
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid input");
                        PressKeyToContinue();
                        break;
                }
            }
        }
        // Submenu - View contacts
        private void MenuViewContacts()
        {
            Console.Clear();
            MenuHeader("View Contacts");
            MenuItem("[1] - View all current contacts");
            MenuItem("[2] - View all current contacts by their first letter");
            MenuItem("[3] - View birthdays");
            MenuItemBottom("[4] - View flagged contacts");
            int.TryParse(Console.ReadLine(), out int menuChoice);
            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    MenuHeader("Viewing Contacts");
                    DisplayContactsSelectIndex("Enter the corresponding ID to view full details.");
                    PressKeyToContinue();
                    break;
                case 2:
                    Console.Clear();
                    MenuHeader("Search by Letter");
                    var letterSearch = QuestionAndAnswer("\nEnter the letter to search for: ");
                    SearchForLetter(letterSearch);
                    break;
                case 3:
                    DisplayBirthdays();
                    break;
                case 4:
                    Console.Clear();
                    MenuHeader("Flagged Contacts");
                    DisplayFlaggedContacts();
                    break;
                default:
                    Console.WriteLine("Returning to menu..");
                    PressKeyToContinue();
                    break;
            }
        }
        // Submenu - Edit and Remove
        private void MenuEditRemove()
        {
            Console.Clear();
            MenuHeader("Edit and Remove");
            MenuItem("[1] - Edit a contact");
            MenuItemBottom("[2] - Remove a contact ");
            int.TryParse(Console.ReadLine(), out int menuChoice);
            switch (menuChoice)
            {
                case 1:
                    EditPerson();
                    break;
                case 2:
                    RemovePerson();
                    break;
                default:
                    Console.WriteLine("Returning to menu..");
                    PressKeyToContinue();
                    break;
            }
        }
        #endregion
    }
}
