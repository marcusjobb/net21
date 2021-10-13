using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_2_ChatUp
{
    class PersonSettings
    {
        // Dina metoder är statiska, då måste listan också vara statisk
        // för att de ska kunna använda det
        // Känner mig fortfarande rätt kass på det här med klasser och metdor så har suttit och testat en massor
        // Ska ordna med fler övningar om det
        static ContactList contactList = new();
        public static void AddNewPerson()
        {
            string firstName = "";
            string lastName = "";
            Console.Clear();
            firstName = MainMenu.ReadInput("Skriv in förnamn: ");
            lastName = MainMenu.ReadInput("Skriv in efternamn: ");

            ContactList.Contacts.Add(new Person { FirstName = firstName, LastName = lastName });
        }

        public static void RemovePerson()
        {
            Console.Clear();
            for (int i = 0; i < ContactList.Contacts.Count; i++)
            {
                Person person = ContactList.Contacts[i];
                string output = person.FirstName + " " + person.LastName;
                Console.WriteLine(( i + 1 ) + ": " + output);// i + 1 för att göra det snällare för användare
            }

            Console.WriteLine("Mata in siffran på den personen du vill ta bort");
            var input = int.TryParse(Console.ReadLine(), out int value);
            ContactList.Contacts.RemoveAt(value - 1);
        }

        public static void EditPerson()
        {
            Console.Clear();
            for (int i = 0; i < ContactList.Contacts.Count; i++)
            {
                Person person = ContactList.Contacts[i];
                string output = person.FirstName + " " + person.LastName;
                Console.WriteLine((i + 1) + ": " + output);
            }
            Console.WriteLine("Mata in siffran på den personen du vill ändra namn på");
            var input = int.TryParse(Console.ReadLine(), out int value);
            ContactList.Contacts.RemoveAt(value - 1);

            string firstName = "";
            string lastName = "";
            Console.Clear();
            firstName = MainMenu.ReadInput("Skriv in det nya förnamnet: ");
            lastName = MainMenu.ReadInput("Skriv in det nya efternamnet: ");

            ContactList.Contacts.Add(new Person { FirstName = firstName, LastName = lastName });

        }

        public static void SearchPerson()
        {
            Console.Clear();
            Console.WriteLine("Mata in förnamn som du vill söka på: ");
            string input = Console.ReadLine();

            foreach (var person in ContactList.Contacts)
            {
                if (person.FirstName.StartsWith(input) == true)
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
                
            }
        }

        public static void ListAll()
        {
            Console.Clear();
            foreach (var person in ContactList.Contacts)
            {
                string output = person.FirstName + " " + person.LastName;
                Console.WriteLine(output); 
            }

        }

    }
}
// item är en Person typ och den har ingen ToString, alltså vet inte Write metoden vad den ska göra med den
// write metoden tar bara emot string och item är Person.
// Så antingen skapar du en sträng som får ha informationen om personen, eller så skapar du
// en ToString() i Person
// Console.WriteLine anropar alltid .ToString() men då du använder en egen metod för att
// skriva ut så vill den metod enbart ha string.
// Förutom det så är det riktigt coolt gjort!
// den kommer nu att skriva ut Inlämning_2.Person :)
// var blir automatiskt av typen Person
// Listan Contacts är en lista på Person så loopen anpassar sig till det