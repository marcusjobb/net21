using Genealogi_OOA_JosefinPersson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    public class PersonCrud
    {
        public void Create()
        {
            using (var create = new Database())
            {
                Console.WriteLine("Firstname:");
                var createName = Console.ReadLine();

                Console.WriteLine("Lastname:");
                var createLastName = Console.ReadLine();

                Console.WriteLine("Birth year:");
                string input1 = Console.ReadLine();
                var createBirthYear = 0;
                int.TryParse(input1, out createBirthYear);

                Console.WriteLine("Year of death:");
                string input2 = Console.ReadLine();
                var createDeathYear = 0;
                int.TryParse(input2, out createDeathYear);

                Console.WriteLine("Mother(Id):");
                string input3 = Console.ReadLine();
                var createMotherId = 0;
                int.TryParse(input3, out createMotherId);

                Console.WriteLine("Father(Id):");
                string input4 = Console.ReadLine();
                var createFatherId = 0;
                int.TryParse(input4, out createFatherId);

                Person person = new Person()
                {
                    FirstName = createName,
                    LastName = createLastName,
                    BirthDate = createBirthYear,
                    DeathDate = createDeathYear,
                    MotherId = createMotherId,
                    FatherId = createFatherId,
                };

                create.Add(person);
                create.SaveChanges();
                Console.WriteLine("New family member added!");
                Console.ReadKey();
            }
        }
        public void Read() // listar alla förnamn, efternamn samt Id
        {
            using (var family = new Database())
            {
                var list = family.People.OrderByDescending(f => f.Id);
                foreach (var n in list)
                {
                    Console.WriteLine(" - " + n.FirstName + " " + n.LastName + " Id: " + n.Id);
                }
            }
            Console.ReadKey();
        }
        public void ReadFirstLetter()  //listar efter angiven bokstav
        {
            using (var family = new Database())
            {
                Console.WriteLine("Input first letter of firstname:");
                string firstLetter = Console.ReadLine();

                family.People.Where(n => n.FirstName.StartsWith(firstLetter)).ToList().ForEach(person => Console.WriteLine("Firstname: " + person.FirstName + " Lastname: " + person.LastName));
            }
            Console.ReadKey();
        }
        public void ReadBirthYear() //listar efter angivet födelseår
        {
            using (var family = new Database())
            {
                Console.WriteLine("Input birth year:");
                string birthYearInput = Console.ReadLine();
                var birthYear = 0;
                int.TryParse(birthYearInput, out birthYear);

                family.People.Where(n => n.BirthDate == birthYear).ToList().ForEach(person => Console.WriteLine("  -  " + person.FirstName + " " + person.LastName + "  -  "));
            }
            Console.ReadKey();
        }
        public void Update() //uppdaterar vald person, alla properties
        {
            using (var update = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to update:");
                var inputName = Console.ReadLine();

                var u = update.People.Where(f => f.FirstName == inputName).FirstOrDefault();
                if (u != null)
                {
                    Console.WriteLine("Firstname:");
                    var newName = Console.ReadLine();
                    u.FirstName = newName;

                    Console.WriteLine("Lastname:");
                    var newLastName = Console.ReadLine();
                    u.LastName = newLastName;

                    Console.WriteLine("Birth year:");
                    string birthInput = Console.ReadLine();
                    var newBirth = 0;
                    int.TryParse(birthInput, out newBirth);
                    u.BirthDate = newBirth;

                    Console.WriteLine("Year of death:");
                    string deathInput = Console.ReadLine();
                    var newDeath = 0;
                    int.TryParse(deathInput, out newDeath);
                    u.DeathDate = newDeath;

                    Console.WriteLine("Id of mother:");
                    string momInput = Console.ReadLine();
                    var newMom = 0;
                    int.TryParse(momInput, out newMom);
                    u.MotherId = newMom;

                    Console.WriteLine("Id of father:");
                    string dadInput = Console.ReadLine();
                    var newDad = 0;
                    int.TryParse(dadInput, out newDad);
                    u.FatherId = newDad;

                    update.People.Update(u);
                    update.SaveChanges();
                    Console.WriteLine("Family member updated!");
                }
                else Console.WriteLine("Cannot find family member with that firstname!");
            }
            Console.ReadKey();
        }
        public void Delete() // söker via förnamn, ta bort från tabellen
        {
            using (var delete = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to delete:");
                var inputName = Console.ReadLine();

                var d = delete.People.Where(f => f.FirstName == inputName).FirstOrDefault();
                if (d != null)
                {
                    delete.People.Remove(d);
                    delete.SaveChanges();
                    Console.WriteLine("Family member deleted!");
                }
                else Console.WriteLine("Cannot find family member with that firstname!");
            }
            Console.ReadKey();
        }
        public void ShowGrandParents() // sök på förnamn, söker upp dess föräldrar och lägger i lista, söker sedan upp deras föräldrar och listar dem
        {
            using (var grandParents = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to see more info about:");
                var inputName = Console.ReadLine();

                Person person = grandParents.People.Where(p => p.FirstName == inputName).FirstOrDefault();

                if (person != null)
                {
                    List<Person> parentsList = GetParents(person);

                    if (parentsList.Count > 0)
                    {
                        foreach (Person p in parentsList)
                        {
                            List<Person> grandParentsList = GetParents(p);
                            if (grandParentsList.Count > 0)
                            {
                                foreach (Person gp in grandParentsList)
                                {
                                    Console.WriteLine(" - " + gp.FirstName + " " + gp.LastName + " - ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Parent: " + p.FirstName + " " + p.LastName + " has no known parents");
                            }
                        };
                    }
                    else
                    {
                        Console.WriteLine(person.FirstName + " " + person.LastName + " has no known parents");
                    }
                }
                else
                {
                    Console.WriteLine("Person does not exist.");
                }
            }
            Console.ReadKey();
        }
        public void ShowSiblings() // visar alla med samma föräldrar
        {
            using (var siblings = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to see more info about:");
                var inputName = Console.ReadLine();

                var person = siblings.People.Where(n => n.FirstName == inputName).FirstOrDefault();

                if (person != null)
                {
                    siblings.People.Where(s => s.MotherId == person.MotherId || s.FatherId == person.FatherId).ToList().ForEach(person => Console.WriteLine(" - " + person.FirstName + " " + person.LastName + " - "));
                }
                else
                {
                    Console.WriteLine("Person does not exist.");
                }
            }
            Console.ReadKey();
        }
        public void ShowChildren() //visar alla som har personen som motherId eller fatherId
        {
            using (var children = new Database())
            {
                Console.WriteLine("Input firstname of the family member you wish to see more info about:");
                var inputName = Console.ReadLine();

                var person = children.People.Where(n => n.FirstName == inputName).FirstOrDefault();

                if (person != null)
                {
                    children.People.Where(c => c.MotherId == person.Id || c.FatherId == person.Id).ToList().ForEach(person => Console.WriteLine(" - " + person.FirstName + " " + person.LastName + " - "));
                }
                else
                {
                    Console.WriteLine("Person does not exist.");
                }
            }
            Console.ReadKey();
        }
        private List<Person> GetParents(Person p) // metod för showGrandParents(), stoppar in alla föräldrar till angiven person i en lista
        {
            List<Person> parentsList = new List<Person>();

            using (var parents = new Database())
            {
                parentsList = parents.People.Where(n => n.Id == p.FatherId || n.Id == p.MotherId).ToList();
            }
            return parentsList;
        }
    }
}
