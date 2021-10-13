using System;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;

namespace Fdate002
{
    public class Contacts
    {

        int choice;
        public List<Person> contacts = new List<Person>();

        public void Menu(string title, List<(string,string)> options)
        {
            if (choice > options.Count - 1) choice = 0;

            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.CursorVisible = false;

            string add1Space = " ";                                     // behövs för jämna marginaler
            for (int i = 0; i < options.Count; i++)
            {
                if (i > 8) add1Space = "";
                // Lägger till 1 i menyvalen för att det ser snyggare ut.
                if (i == choice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue; 
                    Console.WriteLine("[" + (i + 1) + "] "+ add1Space + options[i].Item1 );  
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("[" + (i + 1) + "] "+ add1Space + options[i].Item1);
                }
            }
        }

        public char LetUserChoose(List<(string,string)> options, bool isChoosePersonMenu)

        {
            if (options.Count == 0) return '!';
            if (choice > options.Count - 1) choice = 0;
            ConsoleKey readKey = Console.ReadKey().Key;
            if (readKey == ConsoleKey.DownArrow)
            {
                choice++;
                choice = choice % options.Count;
                return ' ';
            }

            else if (readKey == ConsoleKey.UpArrow)
            {

                if (choice == 0)
                {
                    choice = options.Count - 1;
                    return ' ';
                }

                else
                {
                    choice--;
                    return ' ';
                }
            }
           
            if (!isChoosePersonMenu && readKey == ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.White;
                return options[choice].Item1[0];
            }

            else if (!isChoosePersonMenu) // Alla tangentnedslag som inte är upp, ned eller enter gör ingenting i
            {                             // meny där man ej väljer en person
                return ' ';
            }

            else if (readKey == ConsoleKey.Enter)
            {
                choice = choice % options.Count;
                DisplayPerson(options[choice].Item2);
                return ' ';
            }

            else if (readKey == ConsoleKey.Delete)
            {
                DeletePerson(options[choice].Item2);
                return ' ';
            }
            else if (readKey == ConsoleKey.Insert)
            {
                EditPerson(options[choice].Item2);
                return ' ';
            }
            else if (readKey == ConsoleKey.End)
            {
                BlockDeblockPerson(options[choice].Item2);
                return ' ';
            }
            else if (readKey == ConsoleKey.PageDown)
            {
                GhostDeghostPerson(options[choice].Item2);
                return ' ';
            }
            else if (readKey == ConsoleKey.Home)
            {
                return '!';
            }
            else if (readKey == ConsoleKey.OemPlus)
            {
                AddPerson();
                return '!';
            }
            else  // Som ovan, alla övriga tangenter gör ingenting.
            {
                return ' ';
            }
        }

        private void AddPerson()
        {
            Console.Clear();
            DateTime dateOfBirth = new DateTime();
            string id = DateTime.Now.ToString("yyyyMMddHHmmssfff");             // ID't förhoppningsvis unikt
            Console.WriteLine("Förnamn? ");
            string first = Console.ReadLine();
            Console.WriteLine("Efternamn? ");
            string last = Console.ReadLine();

            do
            {
                Console.WriteLine("Född? (åååå mm dd)");
            } while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth));

            contacts.Add(new Person { FirstName = first, LastName = last, ID = id, DateOfBirth = dateOfBirth });
        }

        private void DeletePerson(string id)
        {
            if (id != "0")
            {
                int index = GetIndex(id);
                contacts.RemoveAt(index);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du kan inte ta bort dig själv.");
                Thread.Sleep(2000);
            }
        }
        private void DisplayPerson(string id)
        {
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            int index = GetIndex(id);

            foreach (PropertyInfo item in contacts[index].GetType().GetProperties())        // hajar inte riktigt hur
            {                                                                               // den här propertyInfo grejen funkar...
                string displayNameOfProp = Miscellaneous.editableProps[item.Name];
                if (displayNameOfProp != "ignore" || item.Name== "DateOfBirth")
                {
                    if (item.Name == "DateOfBirth")
                    {
                        string birthDayBoy = "";
                        if (contacts[index].DateOfBirth.Month == DateTime.Now.Month && contacts[index].DateOfBirth.Day >= DateTime.Now.Day)
                        {
                            birthDayBoy = "!fyller år om " + (contacts[index].DateOfBirth.Day - DateTime.Now.Day) + " dagar!\n";
                        }
                        string dateString = contacts[index].DateOfBirth.ToString("yyyy/MM/dd");
                        Console.WriteLine("Född:" + new string(' ',47) + dateString + "  (" + GetAge(contacts[index]) + " år)");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(birthDayBoy);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.WriteLine(displayNameOfProp + ": " + new string(' ', 50 - (displayNameOfProp.Length)) + item.GetValue(contacts[index], null));
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("<DEL> ta bort <INS> redigera <annan tangent> tillbaka");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(new string (' ',100));
            ConsoleKey readKey = Console.ReadKey().Key;
            if (readKey == ConsoleKey.Delete)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Miscellaneous.Working("Deleting");
                Console.WriteLine(".");
                contacts.RemoveAt(index);
            }

            if (readKey == ConsoleKey.Insert)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
 
                EditPerson(index);
                Console.Clear();
                Miscellaneous.Working("Updating");
                DisplayPerson(id); // Borde skapa overload för index, men...
            }
        }
        private void EditPerson(string id)
        {
            int index = GetIndex(id);
            int counter = 0;
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Skriv in ny info, eller tryck <ENTER> för att lämna oförändrad");
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;

            foreach (PropertyInfo item in contacts[index].GetType().GetProperties())
            {
                if (counter > 3)                // namn och födelsedatum är identifierande information, och skall ej uppdateras
                                                // om fel, radera och lägg till igen.
                {
                    string displayNameOfProp = Miscellaneous.editableProps[item.Name];
                    if (displayNameOfProp != "ignore")                                  // ignorerar icke-strängar
                    {
                        Console.Write(displayNameOfProp + ": " + item.GetValue(contacts[index], null));
                        Console.Write(" Nytt värde?"+ new string(' ',60 - ( displayNameOfProp.Length + item.GetValue(contacts[index], null).ToString().Length  ) ));
                        string input = Console.ReadLine();
                        Type myType = contacts[index].GetType();
                        PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                        mysteriousThing.SetValue(contacts[index], input);
                    }
                }
                counter++;
            }
        }

        private void EditPerson(int index)
        {
            Console.Clear();
            int counter = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Skriv in ny info, eller tryck <ENTER> för att lämna öförändrad");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (PropertyInfo item in contacts[index].GetType().GetProperties())
            {
                if (counter > 3)

                {
                    string displayNameOfProp = Miscellaneous.editableProps[item.Name];
                    if (displayNameOfProp != "ignore")
                    {
                        Console.WriteLine(displayNameOfProp + ": " + item.GetValue(contacts[index], null));
                        Console.Write(" Nytt värde?  ");
                        string input = Console.ReadLine();
                        Type myType = contacts[index].GetType();
                        PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                        mysteriousThing.SetValue(contacts[index], input);
                    }
                }
                counter++;
            }
        }

        private void BlockDeblockPerson(string id)
        {
            int index = GetIndex(id);
            contacts[index].IsBlocked = !(contacts[index].IsBlocked);
        }
        private void GhostDeghostPerson(string id)
        {
            int index = GetIndex(id);
            contacts[index].IsGhosted = !(contacts[index].IsGhosted);
        }
        private int GetIndex(string ID)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].ID == ID)           // om två har samma id returneras den första. Men ID 
                {                                   // skall vara unika, så det borde inte hända?
                    return i;
                }
            }
            Console.WriteLine("        ,,,        ");// Detta borde inte kunna hända
            Console.WriteLine("       (O O)       ");
            Console.WriteLine("---ooO--(_)--Ooo---");
            Console.WriteLine("                   ");
            Console.WriteLine("     KILROY SEZ:   ");
            Console.WriteLine("  WOT, NO CONTACT? ");
            return 0;
        }

        public int GetAge(Person person)
        {
            TimeSpan toBirthDay = (DateTime.Today - person.DateOfBirth);
            double daysAlive = (double)toBirthDay.TotalDays;
            int yearsOld = (int)(daysAlive / 365.25);
            return yearsOld;
        }
    }
}

