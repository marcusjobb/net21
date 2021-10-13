using System;
using System.Collections.Generic;

namespace ChatUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContactList minaKontakter = new ContactList();


            // Testlista med tre personer vid start av programmet:
            Person a = new Person();
            a.FirstName = "aaa";
            a.LastName = "ööö";
            a.Alias = "aö";
            Person b = new Person();
            b.FirstName = "bbb";
            b.LastName = "äää";
            b.Alias = "bä";
            Person c = new Person();
            c.FirstName = "ccc";
            c.LastName = "ååå";
            c.Alias = "cå";
            Person cOther = new Person(); // annan person på 'c' för att kunna testa att det går att skriva ut flera på viss bokstav
            cOther.FirstName = "cOtherFirst";
            cOther.LastName = "cOtherLast";
            cOther.Alias = "cOtherAlias";
            minaKontakter.AddPersonToMyContactList(a); minaKontakter.AddPersonToMyContactList(b); minaKontakter.AddPersonToMyContactList(c);minaKontakter.AddPersonToMyContactList(cOther);

            //Person personReturnedFromHelperClass = PersonHelper.AskForPerson(minaKontakter);
            //Console.WriteLine(personReturnedFromHelperClass.Alias + " returned");



            Menu(minaKontakter); // Använder minaKontakter som argument när metoden körs
        }

        private static void Menu(ContactList minaKontakter) // hämtar in minaKontakter som parameter
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Vad vill du göra? Välj ett alternativ!\n1. Lägga till person\n2. Visa person\n3. Ändra person\n4. Ta bort person\n5a. Lista alla personer\n5b. Lista person vars namn börjar på viss bokstav\nq. AVSLUTA");
                string userInput = Console.ReadLine().ToLower().Trim();
                switch (userInput)
                {
                    case "1": // LÄGGA TILL
                        Console.Write("Skriv in personens förnamn: ");
                        string f = Console.ReadLine().Trim();
                        Console.Write("Skriv in personens efternamn: ");
                        string l = Console.ReadLine().Trim();
                        Console.Write("Skriv in personens alias: ");
                        string a = Console.ReadLine().Trim();
                        Person newPerson = new Person(f, l, a); // Konstruktorn körs
                       
                        minaKontakter.AddPersonToMyContactList(newPerson);
                        Console.WriteLine(newPerson.Alias + " tillagd");
                        break;

                    case "2": // VISA ALLT OM PERSON
                        Console.WriteLine("Vilken av dessa vill du visa all information om? Välj förstabokstav i alias!");
                        string s = Console.ReadLine().ToLower().Trim();

                        foreach (var item in minaKontakter.myContacts)
                        {
                            if ((item.Alias).Substring(0, 1) == s)
                            {
                                minaKontakter.ShowPersonFromMyContactList(item);
                            }
                        }
                        NoSuchPerson();
                        break;

                    case "3": // ÄNDRA PERSON
                        Console.WriteLine("Vilken av dessa vill du ändra? Välj förstabokstav på alias!");
                        string ss = Console.ReadLine().ToLower().Trim();
                        foreach (var item in minaKontakter.myContacts)
                        {
                            if ((item.Alias).Substring(0, 1) == ss)
                            {
                                Console.WriteLine("Vilken av egenskaperna vill du ändra?");
                                Console.WriteLine("[F]örnamn");
                                Console.WriteLine("[E]fternamn");
                                Console.WriteLine("[A]lias");
                                //Console.WriteLine("[E]mejl-adress");
                                //Console.WriteLine("[F]acebookprofil");
                                //Console.WriteLine("[I]nstagramprofil");
                                //Console.WriteLine("[B]lockerad");
                                //Console.WriteLine("[G]hostad");
                                //Console.WriteLine("[L]inkedInProfil");
                                //Console.WriteLine("[T]witterprofil");
                                string input = Console.ReadLine().Trim().ToLower();
                                switch (input)
                                {
                                    case "f":
                                        Console.WriteLine("Du valde " + input);
                                        Console.Write("Skriv in nytt förnamn: ");
                                        f = Console.ReadLine().Trim();
                                        item.FirstName = f;
                                        Console.WriteLine("Du har uppdaterat " + item.Alias + " med förnamnet: " + f + ". Personens fullständiga information är nu: " + item.Alias + " " + item.FirstName + " " + item.LastName);
                                        break;
                                    case "e":
                                        Console.WriteLine("Du valde " + input);
                                        Console.Write("Skriv in nytt efternamn: ");
                                        l = Console.ReadLine().Trim();
                                        item.LastName = l;
                                        Console.WriteLine("Du har uppdaterat " + item.Alias + " med efternamn: " + l + ". Personens fullständiga information är nu: " + item.Alias + " " + item.FirstName + " " + item.LastName);
                                        break;
                                    case "a":
                                        Console.WriteLine("Du valde " + input);
                                        Console.Write("Skriv in nytt alias: ");
                                        a = Console.ReadLine().Trim();
                                        item.Alias = a;
                                        Console.WriteLine("Du har uppdaterat " + item.Alias + " med aliaset: " + a + ". Personens fullständiga information är nu: " + item.Alias + " " + item.FirstName + " " + item.LastName);
                                        break;

                                    default:
                                        Console.WriteLine("Ogitligt val - försök igen!");
                                        break;
                                }
                            }
                        }
                        NoSuchPerson();
                        break;

                    case "4": // TA BORT PERSON
                        Console.WriteLine("Vilken av dessa vill du ta bort? Välj förstabokstav på alias");
                        string sss = Console.ReadLine().ToLower().Trim();

                        Person removedPerson = new Person();
                        foreach (var item in minaKontakter.myContacts)
                        {
                            if (item.Alias.Substring(0, 1) == sss)
                            {
                                removedPerson = item;
                                Console.WriteLine(item.Alias + " kommer att tas bort.");
                            }
                        }
                        minaKontakter.myContacts.Remove(removedPerson);
                        NoSuchPerson();
                        break;

                    case "5a": // LISTA ALLA PERSONER (bara alias)
                        minaKontakter.ShowAllPersonsFromMyContactList(minaKontakter);
                        break;

                    case "5b": // LISTA PERSONER PÅ VISS BOKSTAV
                        minaKontakter.ShowPersonsWithCertainLetter(minaKontakter);
                        break;

                    case "q":
                        done = true;
                        break;

                    default:
                        Console.WriteLine("Ogitligt val. Försök igen!");
                        break;
                }
            }
        }

        public static void NoSuchPerson()
        {
            Console.WriteLine("Det finns ingen med den begynnelsebokstaven!");
        }




        //public static void SelectPerson()
        //{

        //}

        //public static Person AskForPerson(ContactList c)
        //{
        //    Console.WriteLine("Vilken vill du välja? Välj förstabokstav i alias!");
        //    string s = Console.ReadLine();

        //    Person personChosen = new Person();

        //    foreach (var item in c.myContacts)
        //    {
        //        if (item.Alias == s)
        //        {
        //            personChosen = item;
        //        }
        //    }
        //    return personChosen;
        //}

    }
}
