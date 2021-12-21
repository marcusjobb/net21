using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils.Helper
{
    class Father
    {
        //-------------------------far--------------------------------------------------

        public static Person FindFather(string firstName, string lastName) //hittar pappan och ger möjlighet att ändra pappa
        {
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);

                if (person != null)
                {
                    var foundFather = person.FatherId;
                    var father = db.People.FirstOrDefault(d => d.Id == foundFather); //koppla personens fatherId med pappans Id

                    if (father != null)
                    {
                        Console.WriteLine($"\n{father.FirstName} {father.LastName} is {person.FirstName}'s father");
                    }
                    else
                    {
                        Console.WriteLine($"Could not find father to {person.FirstName}");
                        Console.WriteLine("Do you want to change father? (if you want to add a father, create a new person via menu first)\n y/n ?");
                        var input = Console.ReadLine().ToLower().Trim();

                        if (input == "y")
                        {
                            SetFather(firstName, lastName);
                        }
                    }
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }

        public static void ChangeFather(string firstName, string lastName) //metod för att ändra pappan
        {
            Console.WriteLine("Do you want to change father? (if you want to add a father, create a new person via menu first)\ny/n ?");
            var input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                Utils.Helper.Father.SetFather(firstName, lastName);
            }
        }

        private static Person SetFather(string firstName, string lastName)  //en metod för att hjälpa ändra pappan
        {
            AddFather(out string dadFirstName, out string dadLastName);
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);

                if (person != null)
                {
                    var father = db.People.FirstOrDefault(m => m.FirstName == dadFirstName &&
                                                            m.LastName == dadLastName);

                    if (father != null)
                    {
                        var currentFather = person.FatherId;
                        person.FatherId = father.Id;
                        Console.WriteLine($"\nYou've changed {person.FirstName}'s father to {father.FirstName}.");
                        db.SaveChanges();
                    }
                    else Console.WriteLine($"Enter an existing person on the family tree!");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }

        private static void AddFather(out string dadFirstName, out string dadLastName)
        {
            Console.Write("Enter father's first name: ");
            dadFirstName = Console.ReadLine();
            Console.Write("Enter father's last name: ");
            dadLastName = Console.ReadLine();
        }
    }
}

