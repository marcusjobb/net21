using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Genealogi.Database;

namespace WS_Genealogi.Utiles
{
    internal class BasicHelper
    {
        public static void Write(string sentence)
        {
            Console.WriteLine(sentence);
        }
        public static string WriteAndInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static void ShowAll() // :D
        {
            
            using (var db = new PersonContext())
            {
                
                foreach (var item in db.Persons)
                {
                    Console.WriteLine(item);
                }
                
            }
        }
        public static void SearchByName(string name)
        {
            using (var db = new PersonContext())
            {
                foreach (var person in db.Persons.Where(n => n.Name.Contains(name)))
            {
                Console.WriteLine(person);
            }

            }
        }
        public static void SearchByLastName(string lastName)
        {
            using (var db = new PersonContext())
            {
                foreach (var person in db.Persons.Where(n => n.LastName.Contains(lastName)))
                {
                    Console.WriteLine(person);
                }

            }
        }
    }
}
