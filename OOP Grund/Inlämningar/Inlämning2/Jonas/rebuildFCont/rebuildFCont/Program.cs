using System;
using System.Collections.Generic;


namespace Fdate002
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts myContacts = new Contacts();
            AddTestPersons(myContacts);
            AddMySelf(myContacts);                                          // Programmet krashar om kontaktlistan blir tom -
                                                                            // användaren själv läggs in som oraderbar person
            List<(string,string)> personList = new List<(string,string)>(); // Lista av string-tuples med info att visa
                                                                            // i menyer i första termen, och Propertyn ID i
            while (true)                                                    // den andra.
            {
                 
                myContacts.Menu(Miscellaneous.mainMenuHeader, Miscellaneous.MainMenuOptions);   // alla val i huvudmenyn leder till
                                                                                                // menyer för att välja olika personer
                char myReturn = myContacts.LetUserChoose(Miscellaneous.MainMenuOptions, false); // i kontaktlistan, och manipulera
                                                                                                // dessa. Körs tills personmenyn returnerar 
                                                                                                // '!', sen kan ett nytt val göras.
                switch (myReturn)
                {
                    case '1':
                        do
                        {
                            myReturn = ' ';
 
                            personList = Miscellaneous.BuildMenu("all", myContacts); // menyn byggs om en gång per knapptryckning.
                            myContacts.Menu(Miscellaneous.personHeader, personList);
                            myReturn = myContacts.LetUserChoose(personList, true);
                        } while (myReturn!='!');
                        break;
                    case '2':

                        char myReturn2 = ' ';                                               // VS klagar på unnecessary assignment of value?
                        do
                        {
                            myContacts.Menu(Miscellaneous.menuHeader,  Miscellaneous.ABC);  // väljer begynnelsebokstav
                            myReturn2 = myContacts.LetUserChoose(Miscellaneous.ABC, false);
                        } while (myReturn2 == ' ');

                        do
                        {
                            personList = Miscellaneous.BuildMenu(myReturn2.ToString(), myContacts); // visar meny med personer med förnamn på bokstaven 
                            myContacts.Menu(Miscellaneous.personHeader, personList);                // bara förnamn just nu.
                            myReturn = myContacts.LetUserChoose(personList, true);                  //
                        } while (myReturn != '!');

                        break;
                    case '3':
                        do
                        {
                            personList = Miscellaneous.BuildMenu("blocked", myContacts);
                            myContacts.Menu(Miscellaneous.personHeader, personList);
                            myReturn = myContacts.LetUserChoose(personList, true);
                        } while (myReturn != '!');
                        break;
                    case '4':
                        do
                        {
                            personList = Miscellaneous.BuildMenu("ghosted", myContacts);
                            myContacts.Menu(Miscellaneous.personHeader, personList);
                            myReturn = myContacts.LetUserChoose(personList, true);
                        } while (myReturn != '!');
                        break;
                    case '5':
                        do
                        {
                            personList = Miscellaneous.BuildMenu("birthday", myContacts);
                            myContacts.Menu(Miscellaneous.personHeader, personList);
                            myReturn = myContacts.LetUserChoose(personList, true);
                        } while (myReturn != '!');
                        break;

                    case '6':
                        char myReturn3 = ' ';                                               // VS klagar på unnecessary assignment of value?
                        do
                        {
                            myContacts.Menu(Miscellaneous.menuHeader, Miscellaneous.ABC);  // väljer begynnelsebokstav
                            myReturn3 = myContacts.LetUserChoose(Miscellaneous.ABC, false);
                        } while (myReturn3 == ' ');

                        do
                        {
                            myReturn3 = char.ToLower(myReturn3);
                            personList = Miscellaneous.BuildMenu(myReturn3.ToString(), myContacts); // visar meny med personer med efternamn på bokstaven 
                            myContacts.Menu(Miscellaneous.personHeader, personList);                //  
                            myReturn = myContacts.LetUserChoose(personList, true);                  //
                        } while (myReturn != '!');


                        break;

                    default:

                         // gör ingenting - åk en runda till.
                        break;
                }
            }
        }

        public static void AddMySelf(Contacts myContacts)
        {
            Console.Write("Mata in ditt förnamn: ");
            string myFirstName = Console.ReadLine();
            Console.Clear();
            Console.Write("Mata in ditt efternamn: ");
            string myLastName = Console.ReadLine();

            DateTime myDateOfBirth = new DateTime();
            do
            {
                Console.Clear();
                Console.Write("Mata in ditt födelsedatum (åååå mm dd): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out myDateOfBirth));
            Person mySelf = new Person { FirstName = myFirstName, LastName = myLastName, DateOfBirth = myDateOfBirth, ID = "0" };
            myContacts.contacts.Add(mySelf);
        }
        public static void AddTestPersons( Contacts myContacts)
        {
            // Dessa är för avsedda för test. 
            Person nell = new Person { FirstName = "Nell", LastName = "Gwynn", DateOfBirth = new DateTime(1650, 2, 2), ID = "1" };
            myContacts.contacts.Add(nell);
            Person louise = new Person { FirstName = "Loise", LastName = "de Kerouaille", DateOfBirth = new DateTime(1649, 9, 5), ID = "2" };
            myContacts.contacts.Add(louise);
            Person marielouise = new Person { FirstName = "Marie-Louise", LastName = "morphy", DateOfBirth = new DateTime(1737, 10, 21), ID = "3" };
            myContacts.contacts.Add(marielouise);
            Person jeanA = new Person { FirstName = "Jean-Antoinette", LastName = "poisson", DateOfBirth = new DateTime(1721, 12, 29), ID = "4" };
            myContacts.contacts.Add(jeanA);
            Person esther = new Person { FirstName = "Esther", LastName = "Lachmann", DateOfBirth = new DateTime(1819, 5, 7), ID = "5" };
            myContacts.contacts.Add(esther);
            Person blanche = new Person { FirstName = "Blanche", LastName = "d'Antigny", DateOfBirth = new DateTime(1840, 5, 9), ID = "6" };
            myContacts.contacts.Add(blanche);
            Person emma = new Person { FirstName = "Emma", LastName = "Hamilton", DateOfBirth = new DateTime(1765, 4, 26), ID = "7" };
            myContacts.contacts.Add(emma);
            Person harriette = new Person { FirstName = "Harriette", LastName = "Wilson", DateOfBirth = new DateTime(1786, 2, 2), ID = "8" };
            myContacts.contacts.Add(harriette);
            Person cora = new Person { FirstName = "Cora", LastName = "Pearl", DateOfBirth = new DateTime(1836, 12, 12), ID = "9", IsBlocked = true };
            myContacts.contacts.Add(cora);
            Person marie = new Person { FirstName = "marie", LastName = "duplessis", DateOfBirth = new DateTime(1824, 1, 15), ID = "10" };
            myContacts.contacts.Add(marie);
            Person catherine = new Person { FirstName = "catherine", LastName = "walters", DateOfBirth = new DateTime(1839, 6, 13), ID = "11", IsBlocked = true };
            myContacts.contacts.Add(catherine);
            Person margarethe = new Person { FirstName = "margarethe", LastName = "zelle", DateOfBirth = new DateTime(1876, 8, 7), ID = "12" };
            myContacts.contacts.Add(margarethe);
            Person liane = new Person { FirstName = "liane", LastName = "de pougy", DateOfBirth = new DateTime(1869, 7, 2), ID = "13", IsGhosted = true };
            myContacts.contacts.Add(liane);
            Person ninon = new Person { FirstName = "Ninon", LastName = "deLanclos", DateOfBirth = new DateTime(1620, 11, 10), ID = "14" };
            myContacts.contacts.Add(ninon);
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Slottsberg", DateOfBirth = new DateTime(1760, 5, 29), ID = "15", IsGhosted = true };
            myContacts.contacts.Add(charlotte);
            Person marion = new Person { FirstName = "marion", LastName = "delorme", DateOfBirth = new DateTime(1613, 10, 3), ID = "16" };
            myContacts.contacts.Add(marion);
            Person dorothea = new Person { FirstName = "dorothea", LastName = "jordan", DateOfBirth = new DateTime(1761, 11, 22), ID = "17" };
            myContacts.contacts.Add(dorothea);
            Person kitty = new Person { FirstName = "Kitty", LastName = "Fisher", DateOfBirth = new DateTime(1741, 6, 1), ID = "18" };
            myContacts.contacts.Add(kitty);
        }

    }
}

