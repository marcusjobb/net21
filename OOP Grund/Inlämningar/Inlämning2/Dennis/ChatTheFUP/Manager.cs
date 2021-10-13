using System;
using System.Collections.Generic;

namespace ChatTheFUp
{
    partial class Program
    {
        class Manager
        {
            public List<Person> people;

            public Manager()
            {
                
                people = new List<Person>()
                {
                    //hård-kodat namn att starta med.
                    new Person ("DENNIS", "BYBERG", 27, "dennis.byberg@hotmail.com", "dennisbyberg","steak tartare","cat")
                };
                printMenu();
            }
            public void printMenu()
            {
                // Huvudmeny.
                Console.WriteLine("+------------------------+");
                Console.WriteLine("|     CHAT THE F UP!     |");
                Console.WriteLine("+------------------------+");
                Console.WriteLine("|1 - View all persons    |");
                Console.WriteLine("|2 - Add person          |");
                Console.WriteLine("|3 - Edit person         |");
                Console.WriteLine("|4 - Search person       |");
                Console.WriteLine("|5 - Remove person       |");
                Console.WriteLine("|6 - Exit the program    |");
                Console.WriteLine("+------------------------+");
                Console.Write("Enter your menu option: ");

                bool tryParse = int.TryParse(Console.ReadLine(), out int menuOption);

                if (tryParse)
                {
                    // Meny-alternativ.
                    if (menuOption == 1)
                    {
                        ViewAll();
                    }
                    else if (menuOption == 2)
                    {
                        AddPerson();
                    }
                    else if (menuOption == 3)
                    {
                        EditPerson();
                    }
                    else if (menuOption == 4)
                    {
                        SearchPerson();
                    }
                    else if (menuOption == 5)
                    {
                        RemovePerson();
                    }
                    if (menuOption >= 1 && menuOption <= 5)
                    {
                        printMenu();
                    }
                    else if (menuOption < 1 || menuOption > 6)
                    {
                        ErrorMessage("\nInvalid menu choise. ");
                        printMenu();
                    }
                }
            }
            public void ViewAll()
            {
                StartOption("    VIEW ALL PERSONS    ");

                if (people.Count == 0)
                    Console.WriteLine("No users registred. \n");
                else
                    PrintAllUsers();

                FinishOption();
            }

            public void AddPerson()
            {
                StartOption("       ADD PERSON       ");

                try
                {
                    Person person = returnPerson();

                    if (person != null)
                    {
                        people.Add(person);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPERSON SUCCESFULLY ADDED!");
                        Console.ForegroundColor = ConsoleColor.White;
                        FinishOption();
                    }
                    else
                    {
                        ErrorMessage("Invalid input. ");
                        AddPerson();
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Invalid input. ");
                    AddPerson();
                }
            }
            public void EditPerson()
            {
                StartOption("       EDIT PERSON      ");

                if (people.Count == 0)
                {
                    Console.WriteLine("No users to edit. ");
                    Console.ReadLine();
                    Console.Clear();
                    printMenu();
                }
                else
                {
                    PrintAllUsers();

                    try
                    {
                        Console.Write("Input the number of the user you want to edit: ");
                        int indexNumber = Convert.ToInt32(Console.ReadLine());
                        indexNumber--;

                        if (indexNumber >= 0 && indexNumber <= people.Count - 1)
                        {
                            try
                            {
                                Person person = returnPerson();

                                if (person != null)
                                {
                                    people[indexNumber] = person;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPERSON SUCCESSFULLY EDITED!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    FinishOption();
                                }
                                else
                                {
                                    ErrorMessage("Something went wrong.");
                                    printMenu();
                                }
                            }
                            catch (Exception)
                            {
                                ErrorMessage("Something went wrong.");
                                EditPerson();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid number input. ");
                            EditPerson();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Something went wrong. ");
                        EditPerson();
                    }
                }
            }
            public void SearchPerson()
            {
                StartOption("     SEARCH PERSON      ");

                if (people.Count == 0)
                {
                    Console.WriteLine("No users in the system. ");
                }
                else
                {
                    Console.Write("Enter firstname here: ");
                    string nameInput = Console.ReadLine().ToUpper();

                    bool userFound = false;

                    if (!string.IsNullOrEmpty(nameInput))
                    {
                        for (int i = 0; i < people.Count; i++)
                        {
                            if (people[i].firstName.ToUpper().Contains(nameInput))
                            {
                                Console.WriteLine(people[i].returnDetails());
                                userFound = true;
                            }
                        }

                        if (!userFound)
                        {
                            Console.Clear();
                            StartOption("     SEARCH PERSON      ");
                            Console.WriteLine("User not found. (VIEW ALL PERSONS) to see which persons are in the list");
                            Console.ReadLine();
                            Console.Clear();
                            printMenu();
                        }

                        FinishOption();
                    }
                    else
                    {
                        ErrorMessage("Invalid name input. ");
                        SearchPerson();
                    }
                }
            }

            public void RemovePerson()
            {
                StartOption("     REMOVE PERSON      ");

                if (people.Count == 0)
                {
                    Console.WriteLine("No users in the system. ");
                }
                else
                {
                    PrintAllUsers();

                    Console.Write("Enter the person number you want to remove: ");
                    bool tryParse = int.TryParse(Console.ReadLine(), out int index);
                    index--;

                    if (index >= 0 && index <= people.Count - 1)
                    {
                        people.RemoveAt(index);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPERSON SUCCESSFULLY REMOVED!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        FinishOption();
                    }
                    else
                    {
                        ErrorMessage("\nInvalid input. ");
                        RemovePerson();
                    }
                }
            }

            public void StartOption(string message)
            {
                Console.Clear();
                Console.WriteLine("+------------------------+");
                Console.WriteLine("|" + message + "|");
                Console.WriteLine("+------------------------+");
            }

            public void FinishOption()
            {
                Console.WriteLine("Press <ENTER> to return to the menu.");
                Console.ReadLine();
                Console.Clear();
            }

            public void ErrorMessage(string message)
            {
                Console.WriteLine(message + "Press <ENTER> to try again");
                Console.ReadLine();
                Console.Clear();
            }

            public void PrintAllUsers()
            {
                for (int i = 0; i < people.Count; i++)
                {
                    Console.WriteLine(i + 1 + ") " + people[i].returnDetails());
                }
            }

            public Person returnPerson()
            {
                Console.Write("Firstname: ");
                string firstName = Console.ReadLine().ToUpper();

                Console.Write("Lastname: ");
                string lastName = Console.ReadLine().ToUpper();

                Console.Write("Age: ");
                int.TryParse(Console.ReadLine(), out int age);

                Console.Write("E-mail: ");
                string eMail = Console.ReadLine();

                Console.Write("Username at social medias: ");
                string userName = Console.ReadLine();

                Console.Write("Favorite food: ");
                string favFood = Console.ReadLine();

                Console.Write("Favorite animal: ");
                string favAnimal = Console.ReadLine();

                if (!string.IsNullOrEmpty(firstName))
                {
                    if (age >= 0 && age <= 100)
                    {
                        return new Person(firstName, lastName, age, eMail, userName, favFood, favAnimal);
                    }
                    else
                    {
                        ErrorMessage("\nInvalid age input. ");
                    }
                }
                else
                {
                    ErrorMessage("\nInvalid firstname input. ");
                }
                return null;
            }
        }
    }
}