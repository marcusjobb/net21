using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils.Helper
{
    class Mother
    {
        //--------------------mor-------------------------------

        public static Person FindMother(string firstName, string lastName) ////hittar personens mamma och ger möjlighet att ändra mamman
        {
            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);

                if (person != null)
                {
                    var foundMother = person.MotherId;
                    var mother = db.People.FirstOrDefault(m => m.Id == foundMother); //koppla personens motherId med mammans Id

                    if (mother != null)
                    {
                        Console.WriteLine($"\n{mother.FirstName} {mother.LastName} is {person.FirstName} {person.LastName}'s mother");
                    }
                    else
                    {
                        Console.WriteLine($"Could not find mother to {person.FirstName}");
                        Console.WriteLine("Do you want to change mother? (if you want to add a mother, create a new person via menu first)\n y/n ?");
                        var input = Console.ReadLine().ToLower().Trim();

                        if (input == "y")
                        {
                            SetMother(firstName, lastName);
                        }
                    }
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }

        public static void ChangeMother(string firstName, string lastName) //metod för att ändra mamman
        {
            Console.WriteLine("Do you want to change mother? (if you want to add a mother, create a new person via menu first)\ny/n ?");
            var input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                SetMother(firstName, lastName);
            }
        }

        public static Person SetMother(string firstName, string lastName) //en metod för att hjälpa ändra mamman
        {           
            AddMother(out string momFirstName, out string momLastName);

            using (var db = new Database.PersonContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName &&
                                                            p.LastName == lastName);

                if (person != null)
                {
                    var mother = db.People.FirstOrDefault(m => m.FirstName == momFirstName &&
                                                            m.LastName == momLastName);

                    if (mother != null) //Om mor finns, uppdatera Id-kopplingen
                    {
                        var currentMother = person.MotherId;
                        person.MotherId = mother.Id;
                        Console.WriteLine($"\nYou've changed {person.FirstName}'s mother to {mother.FirstName}.");
                        db.SaveChanges();
                    }
                    else Console.WriteLine("This person doesn't exist in the family tree. Add person first to be able to change mother.");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");

                return person;
            }
        }
        private static void AddMother(out string momFirstName, out string momLastName)
        {
            Console.Write("Enter mother's first name: ");
            momFirstName = Console.ReadLine();
            Console.Write("Enter mother's last name: ");
            momLastName = Console.ReadLine();
        }

    }
}

