using WS_Genealogi.Database;
using WS_Genealogi.Models;
using static WS_Genealogi.Utiles.BasicHelper;
namespace WS_Genealogi.Utiles
{
    internal class PersonHelper
    {
        // Jäklar vad snyggt! Bra lösning!
        public static Person FindOrCreatePerson(string name, string lastname, int birthday)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name && // Sök på namnet
                (lastname == p.LastName)
                );
                if (person == null) // om personen inte finns, skapa den
                {
                    person = new Person { Name = name, LastName = lastname, Birthday = birthday };
                    db.Persons.Add(person);
                    db.SaveChanges();
                    Console.WriteLine("Personen är nu skapad!");
                }
                return person;
            }
        }

        public static Person FindAndDeletePerson(string name, string lastname)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name &&
                (lastname == p.LastName)
                );
                if (person != null) // om personen finns, ta bort den
                {
                    db.Persons.Remove(person);
                    db.SaveChanges();
                    Console.WriteLine("Personen är nu borta!");
                }
                return person;
            }
        }

        public static Person FindAndUpdatePerson(string name, string lastname)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name &&
                (lastname == p.LastName)
                );
                if (person != null) // om personen finns, ta bort den
                {
                    Update(person);
                    db.Persons.Update(person);
                    db.SaveChanges();
                    Console.WriteLine("Personen är nu uppdaterad");
                }
                return person;
            }
        }

        private static void Update(Person person)
        {
            Console.WriteLine("Vad vill du uppdatera?");
            Console.WriteLine("1. Namn");
            Console.WriteLine("2. Efternamn");
            Console.WriteLine("3. födelseår");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Skriv in det nya namnet: ");
                string updatedVariable = Console.ReadLine();
                person.Name = updatedVariable;
            }
            if (input == "2")
            {
                Console.Write("Skriv in det nya Efternamnet: ");
                string updatedVariable = Console.ReadLine();
                person.LastName = updatedVariable;
            }
            if (input == "3")
            {
                Console.Write("Skriv in det nya Födelseåret: ");
                string updatedVariable = Console.ReadLine();
                int.TryParse(updatedVariable, out int birthYearUpdated);
                person.Birthday = birthYearUpdated;

            }

        }

        public static Person FindOrCreateFather(string name, string lastname, int birthday)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name &&
                (lastname == p.LastName)
                );
                if (person != null)
                {
                    string parentName = WriteAndInput("Skriv in namn på förälder: ");
                    string parentLastName = WriteAndInput("Skriv in efternamn på förälder: ");
                    int.TryParse(WriteAndInput("Skriv in födelseår på förälder: "), out int parentBirthYear);
                    person.Father = parentName + " " + parentLastName;
                    db.Persons.Update(person);
                    db.SaveChanges();
                    FindOrCreatePerson(parentName, parentLastName, parentBirthYear);
                }
                return person;
            }
        }
        public static Person FindOrCreateMother(string name, string lastname, int birthday)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name &&
                (lastname == p.LastName) &&
                (birthday == p.Birthday)
                );
                if (person != null)
                {
                    string parentName = WriteAndInput("Skriv in namn på förälder: ");
                    string parentLastName = WriteAndInput("Skriv in efternamn på förälder: ");
                    int.TryParse(WriteAndInput("Skriv in födelseår på förälder: "), out int parentBirthYear);
                    person.Mother = parentName + " " + parentLastName;
                    db.Persons.Update(person);
                    db.SaveChanges();
                    FindOrCreatePerson(parentName, parentLastName, parentBirthYear);
                }
                return person;
            }
        }
    }
}
