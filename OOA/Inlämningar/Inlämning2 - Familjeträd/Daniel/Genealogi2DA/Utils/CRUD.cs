using Genealogi2DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi2DA.Utils
{
    public class Crudpeople
    {
        // Här kan du lista alla personer, förnamn, efternamn, moder och fader id.
        public void ListAll()
        {
            using var familymembers = new Database();
            {
                Console.Clear();
                var All = familymembers.People.OrderBy(f => f.Id);
                foreach (var a in All)
                {
                    Console.WriteLine(a.FirstName + " " +
                                      a.LastName + " Id: " + a.Id);
                }
            }
            Console.ReadKey();
        }
        //Listar den bokstav dom angivits
        public void InputFirstLetter()
        {
            using var familymembers = new Database();
            {
                Console.Clear();
                Console.WriteLine("Input first letter of firstname to view the list:");
                string firstLetter = Console.ReadLine();

                familymembers.People.Where(n => n.FirstName.StartsWith(firstLetter)).ToList().ForEach(person =>
                Console.WriteLine("Firstname: " + person.FirstName + " Lastname: " + person.LastName));
            }
            Console.ReadKey();
        }
        // Skriv ett födelseår på en i listan så kommer det upp vem det är som fyller år då.
        public void InputBirthYear()
        {
            using (var familymembers = new Database())
            {
                Console.Clear();
                Console.WriteLine("Input birth year:");
                string birthYearInput = Console.ReadLine();
                var birthYear = 0;
                int.TryParse(birthYearInput, out birthYear);

                familymembers.People.Where(n => n.BirthDate == birthYear).ToList().ForEach(person =>
                Console.WriteLine(person.FirstName + " " + person.LastName));
            }
            Console.ReadKey();
        }
        // Uppdatera allt du vill om den valde personen.
        public void EditMember()
        {
            using (var edit = new Database())
            {
                Console.Clear();
                Console.WriteLine("Update a family member by typing the firstname:");
                
                
                var Name = Console.ReadLine();
                var e = edit.People.FirstOrDefault
                    (f => f.FirstName == Name);
                if (e != null)
                {
                    Console.WriteLine("Firstname:");
                    var EditName = Console.ReadLine();
                    e.FirstName = EditName;

                    Console.WriteLine("Lastname:");
                    var EditLastName = Console.ReadLine();
                    e.LastName = EditLastName;

                    Console.WriteLine("Birth year:");
                    var birth = Console.ReadLine();
                    var EditBirth = 0;
                    int.TryParse(birth, out EditBirth);
                    e.BirthDate = EditBirth;

                    Console.WriteLine("Death:");
                    var death = Console.ReadLine();
                    var EditDeath = 0;
                    int.TryParse(death, out EditDeath);
                    e.DeathDate = EditDeath;

                    Console.WriteLine("id of mother:");
                    var Mother = Console.ReadLine();
                    var EditMother = 0;
                    int.TryParse(Mother, out EditMother);
                    e.MotherId = EditMother;

                    Console.WriteLine("id of father:");
                    var Father = Console.ReadLine();
                    var EditFather = 0;
                    int.TryParse(Father, out EditFather);
                    e.FatherId = EditFather;

                    edit.People.Update(e);
                    edit.SaveChanges();
                    Console.WriteLine("Family member updated!");
                }
                else Console.WriteLine("No family member with that name, try again please!");
            }
            Console.ReadKey();
        }
        // finns inga dubletter så sök på förnamn så går det önskade namnet bort från listan.
        public void DeleteMember()
        {
            using (var delete = new Database())
            {
                Console.Clear();
                Console.WriteLine("Delete any member by typing their first name:");
                var inputName = Console.ReadLine();

                var d = delete.People.FirstOrDefault
                    (f => f.FirstName == inputName);

                if (d != null)
                {
                    delete.People.Remove(d);
                    delete.SaveChanges();
                    Console.WriteLine("Success! Member deleted.");
                }
                else Console.WriteLine("Cannot find family member with that name!");

            }
            Console.ReadKey();
        }
        // sök efter grandparents, skriv förnamnet på den person du vill söka
        public void GetGrandParents()
        {
            using (var grandParents = new Database())
            {
                Console.Clear();
                Console.WriteLine("To find grandparents, please input their firstname:");
                var inputName = Console.ReadLine();

                Person member = grandParents.People.FirstOrDefault(p => p.FirstName == inputName);

                if (member != null)
                {
                    List<Person> Listselectedparents = GetParents(member);

                    if (Listselectedparents.Count > 0)
                    {
                        foreach (Person p in Listselectedparents)
                        {
                            List<Person> Inputgrandparents = GetParents(p);
                            if (Inputgrandparents.Count > 0)
                            {
                                foreach (Person grandparent in Inputgrandparents)
                                {
                                    Console.WriteLine(grandparent.FirstName + " " +
                                                      grandparent.LastName);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Parent: " + p.FirstName + " " +
                                              p.LastName + " no parents known");
                            }
                        };
                    }
                    else
                    {
                        Console.WriteLine(member.FirstName + " " +
                                          member.LastName + " has no known parents");
                    }
                }
                else
                {
                    Console.WriteLine("Person does not exist.");
                }
            }
            Console.ReadKey();
        }

        // en lista som visar vilka som har samma föräldrar
        public void GetSiblings()
        {
            using (var siblings = new Database())
            {
                Console.Clear();
                Console.WriteLine("List siblings: Enter the first name of the family member..");
                var inputName = Console.ReadLine();

                var member = siblings.People.FirstOrDefault
                    (n => n.FirstName == inputName);

                if (member != null)
                {
                    siblings.People.Where(s => s.MotherId == member.MotherId ||
                    s.FatherId == member.FatherId).ToList().ForEach(member =>
                    Console.WriteLine(member.FirstName + " " + member.LastName));
                }
                else
                {
                    Console.WriteLine("Member does not exist.");
                }
            }
            Console.ReadKey();
        }
        // Denna är en enkel metod för att visa vilken person som har en viss motherID och fatherID
        public void GetChildren()
        {
            using (var Listchildren = new Database())
            {
                Console.Clear();
                Console.WriteLine("List children: Enter first name of the family member..");
                var InputName = Console.ReadLine();

                var member = Listchildren.People.FirstOrDefault(n => n.FirstName == InputName);

                if (member != null)
                {
                    Listchildren.People.Where(lc => lc.MotherId == member.Id ||
                    lc.FatherId == member.Id).ToList().ForEach(member =>
                    Console.WriteLine(member.FirstName + " " + member.LastName));
                }
                else
                {
                    Console.WriteLine("Member does not exist.");
                }
            }
            Console.ReadKey();
        }
        //Denna metod är till för att visa föräldrar till den peron man har sökt på.
        public List<Person> GetParents(Person p)
        {
            List<Person> parentsList = new List<Person>();

            using var parents = new Database();
            {
                parentsList = parents.People.Where(n => n.Id == p.FatherId ||
                n.Id == p.MotherId).ToList();
            }
            return parentsList;
        }
        public void Create()
        {
            // Skapa en person, följ instruktionerna så dyker en ny medlem i familjen upp
            using var creation = new Database();
            {
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("Firstname:");
                Console.WriteLine("*************");

                var createName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("Lastname:");
                Console.WriteLine("*************");

                var createLastName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("Birth year:");
                Console.WriteLine("*************");

                string input1 = Console.ReadLine();
                var createBirthYear = 0;
                int.TryParse(input1, out createBirthYear);
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("Year of death:");
                Console.WriteLine("*************");

                string input2 = Console.ReadLine();
                var createDeathYear = 0;
                int.TryParse(input2, out createDeathYear);
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("MotheriD:");
                Console.WriteLine("*************");
                string input3 = Console.ReadLine();
                var createMotherId = 0;
                int.TryParse(input3, out createMotherId);
                Console.Clear();
                Console.WriteLine("*************");
                Console.WriteLine("FatheriD:");
                Console.WriteLine("*************");
                string input4 = Console.ReadLine();
                var createFatherId = 0;
                int.TryParse(input4, out createFatherId);

                Person member = new Person()
                {
                    FirstName = createName, LastName = createLastName, BirthDate = createBirthYear, DeathDate = createDeathYear, MotherId = createMotherId, FatherId = createFatherId,
                };

                creation.Add(member);
                creation.SaveChanges();
                Console.WriteLine("Hurray new family member added!!!");
                Console.ReadKey();
            }
        }
    }
}



