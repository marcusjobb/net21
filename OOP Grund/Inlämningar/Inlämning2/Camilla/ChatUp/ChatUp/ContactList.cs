using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class ContactList
    {
        public List<Person> myContacts = new List<Person>(); // field
       // public List<Person> MyPersons { get; set; } = new List<Person>(); prop

        public void AddPersonToMyContactList(Person personToAdd)
        {
            this.myContacts.Add(personToAdd);
        }

        public void ShowPersonFromMyContactList(Person personToShow)
        {
            Console.WriteLine($"Förnamn: {personToShow.FirstName}");
            Console.WriteLine($"Efternamn: {personToShow.LastName}");
            Console.WriteLine($"Alias: {personToShow.Alias}");
        }

        public void ShowAllPersonsFromMyContactList(ContactList all)
        {
            Console.WriteLine("Här är en lista på alla alias:");
            foreach (var item in all.myContacts)
            {
                Console.WriteLine(item.Alias);
            }
        }


        public void ChangePersonFromMyContactList(Person personToBeChanged)
        {
        }

        public void ShowPersonsWithCertainLetter(ContactList c)
        {
            Console.WriteLine("Lista alla på viss bokstav - Välj förstabokstav på alias!");
            string ans = Console.ReadLine().ToLower().Trim();
            foreach (var item in c.myContacts)
            {
                if ((item.Alias).Substring(0, 1) == ans)
                {
                    List<Person> certainList = new List<Person>();
                    certainList.Add(item);
                    foreach (var item2 in certainList)
                    {
                        Console.WriteLine($"Förnamn: {item2.FirstName}, Efternamn: {item2.LastName}, Alias: {item2.Alias}");
                    }
                }
            }
            Program.NoSuchPerson();
        }


        public ContactList() // default
        {

        }
    }
}
