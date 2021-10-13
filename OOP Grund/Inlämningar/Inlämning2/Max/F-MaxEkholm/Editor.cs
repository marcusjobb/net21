using System;

namespace F
{
    class Editor
    {
        public static void EditPersonal(int index, ConsoleKeyInfo command)
        {
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Write("New nickname: ");
                    PersonClass.ContactList[index].Nickname = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("New first name: ");
                    PersonClass.ContactList[index].FirstName = Console.ReadLine();
                    break;
                case ConsoleKey.D3:
                    Console.Write("New last name: ");
                    PersonClass.ContactList[index].LastName = Console.ReadLine();
                    break;
                case ConsoleKey.D4:
                    Console.Write("New birthday (DD/MM/YYYY): ");
                    PersonClass.ContactList[index].Birthday = Adder.AddBirthday();
                    break;
                case ConsoleKey.D5:
                    Console.Write("New email: ");
                    PersonClass.ContactList[index].LastName = Console.ReadLine();
                    break;
            }
        }

        public static void EditSocial(int index, ConsoleKeyInfo command)
        {
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Write("New LinkedIn alias: ");
                    PersonClass.ContactList[index].LinkedIn = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("New Facebook alias: ");
                    PersonClass.ContactList[index].Facebook = Console.ReadLine();
                    break;
                case ConsoleKey.D3:
                    Console.Write("New Instagram alias: ");
                    PersonClass.ContactList[index].Instagram = Console.ReadLine();
                    break;
                case ConsoleKey.D4:
                    Console.Write("New Twitter alias: ");
                    PersonClass.ContactList[index].Twitter = Console.ReadLine();
                    break;
                case ConsoleKey.D5:
                    Console.Write("New GitHub alias: ");
                    PersonClass.ContactList[index].Github = Console.ReadLine();
                    break;
            }
        }
        public static void EditFood(int index, ConsoleKeyInfo command)
        {
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    Console.Write("New most liked food: ");
                    PersonClass.ContactList[index].LikeFood = Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Console.Write("New least liked food: ");
                    PersonClass.ContactList[index].HateFood = Console.ReadLine();
                    break;
            }
        }

        public static void DeleteContact(int index)
        {
            Console.Clear();
            Console.WriteLine($"Do you want to delete {PersonClass.ContactList[index].Nickname} from your contacts?");

            var command = Menus.YesNoQuestion();
            switch (command.Key)
            {
                case ConsoleKey.Enter:
                    PersonClass.ContactList.Remove(PersonClass.ContactList[index]);
                    Console.WriteLine($"Contact has been deleted. Press any key to continue");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        }

        public static void GhostBlockToggler(int index, ConsoleKeyInfo command)
        {
            var ghosted = PersonClass.ContactList[index].IsGhosted;
            var blocked = PersonClass.ContactList[index].IsBlocked;

            switch (command.Key)
            {
                case ConsoleKey.D1:
                    PersonClass.ContactList[index].IsGhosted = !ghosted;
                    break;

                case ConsoleKey.D2:
                    PersonClass.ContactList[index].IsBlocked = !blocked;
                    break;
            }
        }
    }
}
