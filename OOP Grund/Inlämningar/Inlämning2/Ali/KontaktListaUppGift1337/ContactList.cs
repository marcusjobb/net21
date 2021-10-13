using System;
using System.Collections.Generic;
using System.Reflection;

namespace KontaktListaUppGift1337
{
    internal class ContactList
    {
        private string Input = "";
        private string Input2 = "";
        private string Remove = "";
        private bool SomethingHappened = false;
        private int Count = 0;
        private readonly List<Person> Persons = new List<Person>();
        private readonly PropertyInfo[] Properties = typeof(Person).GetProperties();
        private readonly Person newPerson = new Person();

        internal void ExistingContacts2()
        {
            Person NewPerson = new Person
            {
                Name = "Kim",
                LastName = "Ned",
                Alias = "KN",
                Email = "KimNed1994@hotmail.com",
                BirthDay = Convert.ToDateTime("1992-10-01"),
                Ghosted = true
            };
            Persons.Add(NewPerson);
        }

        internal void ExistingContacts()
        {
            Person newPerson = new Person
            {
                Name = "Emergency",
                LastName = "Number",
                Alias = "SOS",
                Email = "kundsupport112@sosalarm.se",
                BirthDay = Convert.ToDateTime("1200-01-01"),
                Blocked = true
            };
            Persons.Add(newPerson);
        }

        internal void AddNewPerson()
        {
            Console.Clear();
            Person newPerson = new Person();
            PropertyInfo[] Properties = typeof(Person).GetProperties();
            MenyDesign("Do you want to add basic information or everything? (Enter basic or everything as your answer)");
            Input = Console.ReadLine();

            if (Input.ToUpper() == "BASIC")
            {
                Console.Clear();
                if (Input.ToUpper() == "BASIC")
                {
                    Console.Write("Enter Firstname: ");
                    newPerson.Name = Console.ReadLine();
                    newPerson.Name = CapitalizeFirstLetter(newPerson.Name);
                    Console.Write("Enter Lastname: ");
                    newPerson.LastName = Console.ReadLine();
                    newPerson.LastName = CapitalizeFirstLetter(newPerson.LastName);
                    Console.Write("Enter Alias: ");
                    newPerson.Alias = Console.ReadLine();
                    newPerson.Alias = CapitalizeFirstLetter(newPerson.Alias);

                    Input2 = "2020-01-01";
                    while (Input2 == "2020-01-01")
                    {
                        Console.WriteLine("Please enter your date of birth in the format of YYYY-MM-DD.");
                        try
                        {
                            newPerson.BirthDay = Convert.ToDateTime(Console.ReadLine());
                            Input2 = newPerson.BirthDay.ToString();
                        }
                        catch (FormatException)
                        {
                            Input2 = "2020-01-01";
                            if (Input2 == "2020-01-01")
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong format, try again");
                            }
                        }
                    }
                }
                else if (Input.ToUpper() == "EVERYTHING")
                {
                    for (int i = 0; i < Properties.Length; i++)
                    {
                        Console.Write("Enter " + Properties[i].Name + ": ");
                        Input = Console.ReadLine();
                        Input = CapitalizeFirstLetter(Input);
                        if (Properties[i].Name == "Blocked" || Properties[i].Name == "Ghosted")
                        {
                            Properties[i].SetValue(newPerson, Convert.ToBoolean(Input));
                        }
                        else
                        {
                            Properties[i].SetValue(newPerson, Input);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Fel");
                }
            }
            else
            {
                Console.WriteLine("WRONG INPUT");
            }

            Persons.Add(newPerson);
            PressAnything();
        }

        internal void UpdateExistingPerson()

        {
            Console.Clear();
            PrintContactsFristandLastName();
            InputFirstAndLastName();

            for (int i = 0; i < Persons.Count; i++)
            {
                Console.WriteLine();

                if (Persons[i].Name.Equals(Input) && Persons[i].LastName.Equals(Input2))
                {
                    foreach (PropertyInfo prop in Properties)
                    {
                        Persons[i].Age = DateTime.Today.Year - Persons[i].BirthDay.Year;
                        Console.WriteLine(prop.Name + ": " + prop.GetValue(Persons[i]));
                    }
                    Console.WriteLine();
                    Console.Write("Enter what you want to change (Case sensitive) : ");
                    InputCapitalLetter();
                    Input2 = "2020-01-01";
                    if (Input.ToUpper() == "BIRTHDAY")

                    {
                        while (Input2 == "2020-01-01")
                        {
                            Console.WriteLine("Please enter your date of birth in the format of YYYY-MM-DD.");
                            Input2 = Console.ReadLine();
                            try
                            {
                                Input = "BirthDay";
                                Persons[i].GetType().GetProperty(Input).SetValue(Persons[i], Convert.ToDateTime(Input2));
                            }
                            catch (FormatException)
                            {
                                Input2 = "2020-01-01";
                                if (Input2 == "2020-01-01")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wrong format, try again");
                                }
                            }
                        }

                        SomethingHappened = true;
                    }
                    else
                    {
                        Console.Write("Enter what you want to change it to: ");
                        Input2CapitalLetter();
                    }

                    if (Input.ToUpper() == "BLOCKED")
                    {
                        SomethingHappened = true;
                        try
                        {
                            Persons[i].GetType().GetProperty(Input).SetValue(Persons[i], Convert.ToBoolean(Input2));
                        }
                        catch (SystemException)
                        {
                            Input2 = "false";
                            SomethingHappened = false;
                        }
                    }
                    else if (Input.ToUpper() == "GHOSTED")
                    {
                        SomethingHappened = true;
                        try
                        {
                            Persons[i].GetType().GetProperty(Input).SetValue(Persons[i], Convert.ToBoolean(Input2));
                        }
                        catch (SystemException)
                        {
                            Input2 = "false";
                            SomethingHappened = false;
                        }
                    }
                    else if (Persons[i].GetType().GetProperty(Input) == null)
                    {
                        Input = "Steam";

                        Persons[i].GetType().GetProperty(Input).SetValue(Persons[i], Input2);

                        Console.WriteLine("");
                        Console.WriteLine(Input + " Updated to " + Input2);
                        SomethingHappened = true;
                    }
                    else
                    {
                        if (!(SomethingHappened = true))
                        {
                            Persons[i].GetType().GetProperty(Input).SetValue(Persons[i], Input2);
                            SomethingHappened = true;
                        }
                    }
                }
            }

            UpdatedTo();

            WrongInput();
            PressAnything();
        }

        internal void ShowInfoOfContact()
        {
            Console.Clear();
            PrintContactsFristandLastName();
            InputFirstAndLastName();

            for (int i = 0; i < Persons.Count; i++)
            {
                Console.WriteLine();

                if (Persons[i].Name.Contains(Input) && Persons[i].LastName.Contains(Input2))
                {
                    foreach (PropertyInfo prop in Properties)
                    {
                        if (prop.GetValue(Persons[i]) != null)
                        {
                            Persons[i].Age = DateTime.Today.Year - Persons[i].BirthDay.Year;
                            Console.WriteLine(prop.Name + ": " + prop.GetValue(Persons[i]));
                        }
                    }
                    SomethingHappened = true;
                }
            }
            WrongInput();
            PressAnything();
        }

        internal void PrintPerson()
        {
            Console.Clear();
            Console.WriteLine("Do you want to list everyone or with a filter(Filter by firstletter, blocked or ghosted users and birthday this month)");
            Console.Write("Enter \"filter\" or \"everyone\": ");
            Input = Console.ReadLine();

            if (Input.ToUpper() == "EVERYONE" || Input.ToUpper() == "ALL" || Input.ToUpper() == "EVERYONE")
            {
                PrintContactsFristandLastName();

                SomethingHappened = true;
            }
            else if (Input.ToUpper() == "FILTER")
            {
                Console.Clear();
                Console.WriteLine("Filter by the first letter, blocked, ghosted or birthday this month");
                Console.WriteLine("");
                Console.Write("Enter \"firstletter\" or \"blocked\" or \"ghosted\" or \"birthday\" to choose the filter you want: ");
                InputCapitalLetter();
                if (Input.ToUpper() == "FIRSTLETTER")
                {
                    Console.Write("Write the first letter you want to filter names by: ");
                    Input = Console.ReadLine();
                    Input = Input.ToUpper();

                    for (int i = 0; i < Persons.Count; i++)
                    {
                        if (Persons[i].Name.StartsWith(Input))
                        {
                            Count++;
                            Console.WriteLine("Contact: " + Count);
                            Persons[i].Age = DateTime.Today.Year - Persons[i].BirthDay.Year;
                            Console.WriteLine("\t" + Persons[i].Name + " " + Persons[i].LastName);
                            Console.WriteLine();
                        }

                        SomethingHappened = true;
                    }
                }
                else if (Input.ToUpper() == "GHOSTED")
                {
                    for (int i = 0; i < Persons.Count; i++)
                    {
                        if (Persons[i].Ghosted.ToString() == "True")
                        {
                            Console.Clear();
                            Console.WriteLine("These people are ghosted.");
                            Console.WriteLine("");
                            MenyDesign("Firstname: " + Persons[i].Name + " " + "Lastname: " + Persons[i].LastName);
                            SomethingHappened = true;
                        }
                    }
                }
                else if (Input.ToUpper() == "BLOCKED")
                {
                    for (int i = 0; i < Persons.Count; i++)
                    {
                        if (Persons[i].Blocked.ToString() == "True")
                        {
                            Console.Clear();
                            Console.WriteLine("These people are blocked.");
                            Console.WriteLine("");
                            MenyDesign("Firstname: " + Persons[i].Name + " " + "Lastname: " + Persons[i].LastName);
                            SomethingHappened = true;
                        }
                    }
                }
                else if (Input.ToUpper() == "BIRTHDAY")
                {
                    for (int i = 0; i < Persons.Count; i++)
                    {
                        if (Persons[i].BirthDay.Month == DateTime.Now.Month)
                        {
                            Console.Clear();
                            Console.WriteLine("These people have a birthday this month.");
                            Console.WriteLine("");
                            MenyDesign("Firstname: " + Persons[i].Name + " " + "Lastname: " + Persons[i].LastName);
                            SomethingHappened = true;
                        }
                    }
                }
                else if (Input.ToUpper() == "EXIT")
                {
                    SomethingHappened = true;
                }
                else
                {
                }
            }

            WrongInput();
            PressAnything();
        }

        internal void DeletePerson()
        {
            do
            {
                Console.Clear();
                PrintContactsFristandLastName();
                Console.Write("Do you want to delete a contact? (Y/N) ");
                Remove = Console.ReadLine();
                if (Remove.ToUpper() == "YES" || Remove.ToUpper() == "Y")
                {
                    Console.WriteLine();
                    InputFirstAndLastName();
                    for (int i = 0; i < Persons.Count; i++)
                    {
                        {
                            if (Persons[i].Name.Equals(Input) && Persons[i].LastName.Equals(Input2))
                            {
                                Persons.Remove(Persons[i]);
                                Console.WriteLine("");
                                Console.WriteLine("Deleted contact " + Input + " " + Input2);
                                SomethingHappened = true;
                                PressAnything();
                            }
                        }
                    }
                    if (SomethingHappened == false && Remove.ToUpper() == "YES" || Remove.ToUpper() == "Y")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Wrong input try again");
                        PressAnything();
                    }
                    SomethingHappened = false;
                }
                else if (Remove.ToUpper() == "NO" || Remove.ToUpper() == "N")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Did you enter the wrong menu?");
                    PressAnything();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    Remove = "YES";
                    PressAnything();
                }
            }
            while (SomethingHappened == false && Remove.ToUpper() == "YES");
        }

        private void PrintContactsAvailableProperties()
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                Count++;
                Console.WriteLine("Contact: " + Count);
                foreach (PropertyInfo prop in Properties)
                {
                    if (prop.GetValue(Persons[i]) != null)
                    {
                        Console.WriteLine("\t" + prop.Name + ": " + prop.GetValue(Persons[i]));
                    }
                }
            }
        }

        private static void PressAnything()
        {
            Console.WriteLine();
            Console.WriteLine("Press something to continue");
            Console.ReadKey();
            Console.Clear();
        }

        private void InputFirstAndLastName()
        {
            Console.Write("Enter firstname: ");
            Input = Console.ReadLine();
            Input = CapitalizeFirstLetter(Input);
            Console.Write("Enter lastname: ");
            Input2 = Console.ReadLine();
            Input2 = CapitalizeFirstLetter(Input2);
        }

        private void PrintContactsFristandLastName()
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                Count++;
                Console.WriteLine("Contact: " + Count);
                Persons[i].Age = DateTime.Today.Year - Persons[i].BirthDay.Year;
                Console.WriteLine("\t" + Persons[i].Name + " " + Persons[i].LastName);

                Console.WriteLine();
            }
            Count = 0;
        }

        internal void Menu()
        {
            MenyDesign("To Add a new contact to your list enter 1 ");
            MenyDesign("To Access information about a contact enter 2");
            MenyDesign("To update a certain contact enter 3");
            MenyDesign("To delete a contact enter 4");
            MenyDesign("To list everyone in your contacts enter 5");
        }

        public string CapitalizeFirstLetter(string str)
        {
            if (str == null)
            {
                return null;
            }

            if (str.Length > 1)
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }

            return str.ToUpper();
        }

        private static void MenyDesign(string Text)
        {
            Console.WriteLine("____________________________________________________________________________________________________");

            Console.WriteLine("");
            Console.WriteLine("          " + Text);
            Console.WriteLine("____________________________________________________________________________________________________");
        }

        private void Input2CapitalLetter()
        {
            Input2 = Console.ReadLine();
            Input2 = CapitalizeFirstLetter(Input2);
        }

        private void WrongInput()
        {
            if (SomethingHappened == false)
            {
                Console.WriteLine("Wrong input try again");
            }
            SomethingHappened = false;
        }

        private void UpdatedTo()
        {
            if (SomethingHappened == true)
            {
                MenyDesign(Input + " Updated to " + Input2);
            }
        }

        private void InputCapitalLetter()
        {
            Input = Console.ReadLine();
            Input = CapitalizeFirstLetter(Input);
        }
    }
}