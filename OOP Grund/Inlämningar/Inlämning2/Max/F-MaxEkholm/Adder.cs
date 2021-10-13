using System;

namespace F
{
    class Adder
    {
        public static void AddContact()
        {
            PersonClass person = new PersonClass();

            Console.Write("Nickname: ");
            person.Nickname = Console.ReadLine();

            Console.Clear();
            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Clear();
            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Continue adding other information such as birthday, email and social media aliases? (You can add these later by going into the edit menu)");
            
            var command = Menus.YesNoQuestion();

            if (command.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.Write("Birthday (DD/MM/YYYY): ");
                person.Birthday = AddBirthday();

                Console.Clear();
                Console.Write("Email: ");
                person.Email = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Add social media aliases?");
                
                command = Menus.YesNoQuestion();

                if (command.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.Write("LinkedIn: ");
                    person.LinkedIn = Console.ReadLine();

                    Console.Clear();
                    Console.Write("Facebook: ");
                    person.Facebook = Console.ReadLine();

                    Console.Clear();
                    Console.Write("Instagram: ");
                    person.Instagram = Console.ReadLine();

                    Console.Clear();
                    Console.Write("Twitter: ");
                    person.Twitter = Console.ReadLine();

                    Console.Clear();
                    Console.Write("Github: ");
                    person.Github = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Add liked/disliked foods, favorite animal and movie genre? (You can add these later by going into the edit menu)");
                    
                    command = Menus.YesNoQuestion();

                    if (command.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Most liked food: ");
                        person.LikeFood = Console.ReadLine();

                        Console.Clear();
                        Console.Write("Least liked food: ");
                        person.HateFood = Console.ReadLine();

                        Console.Clear();
                        Console.Write("Favorite animal: ");
                        person.FavAnimal = Console.ReadLine();

                        Console.Clear();
                        Console.Write("Favorite movie genre: ");
                        person.FavMovGenre = Console.ReadLine();
                    }
                }
            }            
            PersonClass.ContactList.Add(person);

            Console.Clear();
            Console.WriteLine($"{person.Nickname} has been added to your contact list!\n");
        }

        public static DateTime AddBirthday()
        {
            bool acceptedDate = false;
            DateTime birthday = new();
            string input;

            while (acceptedDate == false)
            {
                input = Console.ReadLine();

                if (DateTime.TryParse(input, out birthday))
                {
                    acceptedDate = true;

                }
                else Console.Write("Please enter a valid date: ");
            }
            return birthday;
        }
    }
}
