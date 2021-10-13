using System;
using System.Threading;
using System.Collections.Generic;

namespace Chat_the_F_up_TiiaTu
{
    class ContactList
    {
        public static List<Person> nameList = new()
        {
            new Person { Name = "Kalle", LastName = "Berg", Age = 23, Alias = "kllbrg", Email = "kalle.berg@gmail.com", FavoriteActor = "Angelina Jolie", FavoriteAnimal = "Horse" },
            new Person { Name = "Minna", LastName = "Nilsson", Age = 30, Alias = "minski", Email = "minna.nilsson@gmail.com", FavoriteFilmGenre = "Skräk" }
        };

        public static void CheckAction(int menuChoise) //metod för att läsa av användarens val i menun
        {
            if (menuChoise > 0 && menuChoise < 6)
            {
                switch (menuChoise)
                {
                    case 1:
                        AddPerson();
                        break;
                    case 2:
                        UpdatePerson();
                        break;
                    case 3:
                        DeletePerson();
                        break;
                    case 4:
                        Console.Clear();
                        HelperClass.SecondMenu();
                        ChooseSecondMenu();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        private static void ChooseSecondMenu() //öppnar andra andra menun
        {
            Console.Write("Enter number: \n");
            int.TryParse(Console.ReadLine(), out int secondMenuChoise);

            switch (secondMenuChoise)
            {
                case 1: ShowList(); break;
                case 2: SortList(); break;
                default:
                    break;
            }
            Console.Clear();
        }

        private static void SortList() //kraschar :(
        {
            //nameList.Sort(); 
           
        }

    private static void ShowList() //visar listan 
    {
        foreach (Person item in nameList)
        {
            Console.WriteLine($"{item.Name} {item.LastName}\t| [{item.Alias}]\t| ({item.Age})\t| {item.FavoriteFood}\t| {item.Email}\t| {item.YuckyFood}\t| {item.FavoriteAnimal}");
        }
        Console.WriteLine("\nPress any key to continue ");
        Console.ReadLine();
    }

    public static void AddPerson() // metod för att lägga till en person
    {
        Person newPerson = new();
        nameList.Add(newPerson);

        Console.Write("Name: ");
        newPerson.Name = Console.ReadLine();

        Console.Write("Last name: ");
        newPerson.LastName = Console.ReadLine();

        Console.Write("Alias: ");
        newPerson.Alias = Console.ReadLine().ToLower();

        Console.Write("Age: ");
        int.TryParse(Console.ReadLine(), out int age);
        newPerson.Age = age;

        Console.Write("Favorite food: ");
        newPerson.FavoriteFood = Console.ReadLine();

        Console.WriteLine("Do you want to write in more info? (Y/N)");

        string input = Console.ReadLine().ToUpper();
        if (input == "Y")
        {
            Console.Write("Email: ");
            newPerson.Email = Console.ReadLine();
            Console.Write("LinkedIn: ");
            newPerson.LinkedIn = Console.ReadLine();
            Console.Write("Facebook: ");
            newPerson.Facebook = Console.ReadLine();
            Console.Write("Instagram: ");
            newPerson.Instagram = Console.ReadLine();
            Console.Write("Twitter: ");
            newPerson.Twitter = Console.ReadLine();
            Console.Write("GitHub: ");
            newPerson.GitHub = Console.ReadLine();
            Console.Write("Food I hate: ");
            newPerson.YuckyFood = Console.ReadLine();
            Console.Write("Favorite animal: ");
            newPerson.FavoriteAnimal = Console.ReadLine();
            Console.Write("Favorite film genre: ");
            newPerson.FavoriteFilmGenre = Console.ReadLine();
            Console.Write("Favorite Actor: ");
            newPerson.FavoriteActor = Console.ReadLine();
        }
        else if (input == "N")
        {
            Console.Clear();
            return;
        }

        Console.WriteLine("\nNew person added succesfully!");
        Thread.Sleep(500);
        Console.Clear();
    }

    public static void DeletePerson() //metod för att ta bort en person
    {
        ShowList();
        Console.Write("Enter the alias of the person you want to delete: ");

        string givenAlias = Console.ReadLine();

        foreach (var item in nameList)
        {
            if (item.Alias == givenAlias)
            {
                nameList.Remove(item);
                Console.WriteLine("Person deleted succesfully!");
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
        }
        Console.WriteLine("Incorrect input");
        Thread.Sleep(1000);
        Console.Clear();
        return;
    }

    private static void UpdatePerson() // metod för att uppdatera en person
    {
        ShowList();
        Console.Write("Enter the alias of the person you want to update: ");

        string givenAlias = Console.ReadLine();

        foreach (var item in nameList)
        {
            if (item.Alias == givenAlias)
            {
                Console.WriteLine(item.Name);
                Console.Write("\nEnter new name: ");
                string newName = Console.ReadLine();
                item.Name = newName;
                Console.WriteLine("Updated information");
                Console.WriteLine($"{item.Name} {item.LastName}");
                Console.ReadLine();
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }
        }
        Console.WriteLine("Incorrect input");
        Thread.Sleep(1000);
        Console.Clear();
        return;
    }
}
}

