using EF_inlämning_2.Data;
using EF_inlämning_2.Models;

namespace EF_inlämning_2.Utils
{
    internal class Crud
    {
        private static List<Person> GetParents(Person p) // GrandParents()
        {
            List<Person> parentsList = new();

            using (var parents = new DataContext())
            {
                parentsList = parents.People.Where(n => n.Id == p.FatherId || n.Id == p.MotherId).ToList();
            }
            return parentsList;
        }

        public static void Create()//Create New Person
        {
            using (var addncreate = new DataContext())
            {
                Console.WriteLine("Firstname:");
                var addncreateName = Console.ReadLine();

                Console.WriteLine("Lastname:");
                var addncreateLastName = Console.ReadLine();

                Console.WriteLine("Mother(Id):");
                _ = int.TryParse(Console.ReadLine(), out int addncreateMotherId);

                Console.WriteLine("Father(Id):");
                _ = int.TryParse(Console.ReadLine(), out int addncreateFatherId);

                Person person = new()
                {
                    FirstName = addncreateName,
                    LastName = addncreateLastName,
                    MotherId = addncreateMotherId,
                    FatherId = addncreateFatherId,
                };

                addncreate.Add(person);
                addncreate.SaveChanges();
                Console.WriteLine("New member added!");
                Console.ReadKey();
            }
        }

        public static void ReadAll() // List all
        {
            using (var dataContext = new DataContext())
            {
                var list = dataContext.People.OrderBy(f => f.Id);
                foreach (var n in list)
                {
                    Console.WriteLine(" Id: " + n.Id + " " + n.FirstName + " " + n.LastName);
                }
            }
        }

        public static void ReadListFirstL()  //List by First Letter
        {
            using (var dataContext = new DataContext())
            {
                Console.WriteLine("Input first letter of firstname:");
                var firstL = Console.ReadLine();

                dataContext.People.Where(n => n.FirstName.StartsWith(firstL)).ToList().ForEach(person => Console.WriteLine("Firstname: " + person.FirstName + " Lastname: " + person.LastName));
            }
        }

        public static void Update() //Update Member
        {
            using (var update = new DataContext())
            {
                Console.WriteLine("Input Firstname of family member:");
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

                    Console.WriteLine("FatherId:");
                    _ = int.TryParse(Console.ReadLine(), out int newDad);
                    u.FatherId = newDad;

                    Console.WriteLine("MotherId:");
                    _ = int.TryParse(Console.ReadLine(), out int newMom);
                    u.MotherId = newMom;

                    update.People.Update(u);
                    update.SaveChanges();
                    Console.WriteLine("Family updated!");
                }
                else Console.WriteLine("Cannot find family member!");
            }
        }

        public static void Delete() //Delete Member
        {
            using (var delete = new DataContext())
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
        }

        public void GrandParents() //List GrandParents
        {
            using (var grandParents = new DataContext())
            {
                Console.WriteLine("\nChoose By Firstname:");
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
        }

        public static void Siblings() // List Siblings
        {
            using (var siblings = new DataContext())
            {
                Console.WriteLine("\nChoose By Firstname:");
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
        }

        public static void Children() //List Children
        {
            using (var children = new DataContext())
            {
                Console.WriteLine("\nChoose By Firstname:");
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
    }
}