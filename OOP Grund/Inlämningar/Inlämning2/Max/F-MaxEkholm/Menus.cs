using System;

namespace F
{
    class Menus
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Press the key that corresponds with the index of your choise:" +
                    "\n(1) Add Contact" +
                    "\n(2) View Contacts" +
                    "\n(3) Edit Contacts");

                var command = Console.ReadKey();
                switch (command.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Adder.AddContact();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        ContactMenu();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        EditMenu();
                        break;
                    default:
                        Console.Clear();
                        MainMenu();
                        break;
                }
            }
        }

        public static void ContactMenu()
        {
            Writer.WriteAllContacts();

            Console.WriteLine("Press the key that corresponds with the index of your choise:" +
                $"\n(1) View more info" +
                $"\n(2) Filter by symbol" +
                $"\n(3) View ghosted" +
                $"\n(4) View blocked" +
                $"\n(5) Edit contacts" +
                $"\n(esc) Return to main menu");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Menus.ViewMoreMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Menus.FilterSymbolMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Writer.WriteFilterGhosted();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Writer.WriteFilterBlocked();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Menus.EditMenu();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    ContactMenu();
                    break;
            }
        }

        public static void ViewMoreMenu()
        {
            Writer.WriteAllContacts();

            Console.Write("Type in the index number of the contact you want to view and press enter: ");
            int index = Checker.ValidIndexChecker();
            Console.Clear();
            Console.WriteLine($"-----Viewing {PersonClass.ContactList[index].Nickname}-----");

            Writer.WriteMoreInfo(index);
        }

        public static void EditMenu()
        {
            
            Writer.WriteAllContacts();
            Console.Write("Type in the index number of the contact you want to edit and press enter: ");

            int index = Checker.ValidIndexChecker();

            Console.Clear();
            Console.WriteLine($"Editing contact: {PersonClass.ContactList[index].Nickname}");
            Console.WriteLine("");

            Console.WriteLine("Please press a command key: " +
                    "\n(1) Edit personal info" +
                    "\n(2) Edit social media aliases" +
                    "\n(3) Edit liked and disliked food" +
                    "\n(4) Ghost or block" +
                    "\n(5) Delete contact" +
                    "\n(esc) Return to main menu");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Menus.EditPersonalMenu(index);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Menus.EditSocialMenu(index);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Menus.EditFoodMenu(index);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Menus.GhostBlockMenu(index);
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Editor.DeleteContact(index);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    EditMenu();
                    break;
            }
        }

        public static void EditPersonalMenu(int index)
        {
            Console.WriteLine($"What name do you want to edit?" +
                $"\nPress the key that corresponds with the index of your choise:"+
                $"\n(1)   Nickname: {PersonClass.ContactList[index].Nickname} " +
                $"\n(2) First name: {PersonClass.ContactList[index].FirstName}" +
                $"\n(3)  Last name: {PersonClass.ContactList[index].LastName}" +
                $"\n(4)   Birthday: {PersonClass.ContactList[index].Birthday.ToShortDateString()}" +
                $"\n(5)      Email: {PersonClass.ContactList[index].Email}" +
                $"\n(esc) Return to main menu");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Editor.EditPersonal(index, command);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Editor.EditPersonal(index, command);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Editor.EditPersonal(index, command);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Editor.EditPersonal(index, command);
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Editor.EditPersonal(index, command);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    EditPersonalMenu(index);
                    break;
            }
        }

        public static void EditSocialMenu(int index)
        {
            Console.Clear();
            Console.WriteLine($"What social media alias do you want to edit?" +
                $"\nPress the key that corresponds with the index of your choise:" +
                $"\n(1) LinkedIn: {PersonClass.ContactList[index].LinkedIn} " +
                $"\n(2) Facebook: {PersonClass.ContactList[index].Facebook}" +
                $"\n(3) Instagram: {PersonClass.ContactList[index].Instagram}" +
                $"\n(4) Twitter: {PersonClass.ContactList[index].Twitter}" +
                $"\n(5) GitHub: {PersonClass.ContactList[index].Github}" +
                $"\n(esc) Return to main menu");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Editor.EditSocial(index, command);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Editor.EditSocial(index, command);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Editor.EditSocial(index, command);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Editor.EditSocial(index, command);
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Editor.EditSocial(index, command);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    EditSocialMenu(index);
                    break;
            }
        }
        
        public static void EditFoodMenu (int index)
        {
            Console.Clear();
            Console.WriteLine($"What food do you want to edit?" +
                $"\nPress the key that corresponds with the index of your choise:" +
                $"\n(1) Most liked food: {PersonClass.ContactList[index].LikeFood} " +
                $"\n(2) Least liked food: {PersonClass.ContactList[index].HateFood}" +
                $"\n(esc) Return to main menu");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Editor.EditFood(index, command);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Editor.EditFood(index, command);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    EditFoodMenu(index);
                    break;
            }           
        }

        public static void GhostBlockMenu(int index)
        {
            Console.Clear();
            Console.WriteLine($"Ghost or block {PersonClass.ContactList[index].Nickname} by pressing the corresponding index key." +
                $"\nGhosting or blocking a contact that already is ghosted or blocked will unghost or unblock them." +
                $"\n(1) {Checker.IsGhostedChecker(index)}" +
                $"\n(2) {Checker.IsBlockedChecker(index)}" +
                $"\n(esc) Return to main menu");

            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Editor.GhostBlockToggler(index, command);
                    GhostBlockMenu(index);
                    break;
                case ConsoleKey.D2:
                    Editor.GhostBlockToggler(index, command);
                    GhostBlockMenu(index);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    GhostBlockMenu(index);
                    break;
            }
        }

        public static void FilterSymbolMenu ()
        {
            Writer.WriteAllContacts();
            Console.Write("Type the first symbol of the contact you want to see: ");
            string symbol = Console.ReadLine();
            Console.Clear();
            Writer.WriteSymbolFilter(symbol);
        }

        public static ConsoleKeyInfo YesNoQuestion()
        {
            Console.WriteLine("Yes? (Enter)");
            Console.WriteLine("No?  (Any other key)");

            ConsoleKeyInfo command = Console.ReadKey();
            return command;
        }
    }
}
