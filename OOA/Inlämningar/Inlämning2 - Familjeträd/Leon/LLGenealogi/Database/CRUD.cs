using LLGenealogi.Models;
using System.Linq;

namespace LLGenealogi
{
    public class CRUD
    {
        LLGenContext Db = new LLGenContext();

        public string Databasename { get; set; } = "LLGenealogi";
        public int Maxrows { get; set; } = 10; // max rows to return when searching
        public string Orderby { get; set; } = "";
        public void Create(Person person) 
        { 
            if(ValidPerson(person.Name))
            {
                Console.WriteLine("Person already exists.");
            }
            else
            {
                try
                {
                    Db.People.Add(person);
                    Save();
                    Console.WriteLine("Person created.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void Delete(Person person) 
        {
            try
            {
                var result = Db.People.Remove(person);
                Save();
                Console.WriteLine("Person removed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public bool ValidPerson(int Id) 
        {
            if(Db.People.Find(Id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidPerson(string name)
        {
            var result = Db.People.SingleOrDefault(p => p.Name.Equals(name));
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Person GetFather(Person person) 
        {
            var result = Db.People.Find(person.Far);
            if(result != null)
            {
                Console.WriteLine("Father found.");
            }
            else
            {
                Console.WriteLine("Im just going to buy a pack of smokes okay son?");
            }
            return result;
        }
        public Person GetMother(Person person) 
        {
            var result = Db.People.Find(person.Mor);
            if (result != null)
            {
                Console.WriteLine("Father found.");
            }
            else
            {
                Console.WriteLine("Im just going to buy a pack of smokes okay son?");
            }
            return result;
        }

        // List by letter.
        public List<Person> listPeople(string str)
        {
            List<Person> list = new List<Person>();
            var result = Db.People.Where(p => p.Name.Substring(0, 1).Equals(str));
            foreach (var p in result)
            {
                list.Add(p);
            }
            return list;
        }

        // List by year of birth.
        public List<Person> listPeople(int yearOfBirth)
        {
            List<Person> list = new List<Person>();
            var result = Db.People.Where(p => p.YearOfBirth.Equals(yearOfBirth));
            foreach (var p in result)
            {
                list.Add(p);
            }
            return list;
        }

        // List all.
        public List<Person> listPeople()
        {
            List<Person> list = new List<Person>();
            var result = Db.People;
            foreach (var p in result)
            {
                list.Add(p);
            }
            return list;
        }
        public List<Person> listPeopleSiblings(Person person)
        {
            List<Person> list = new List<Person>();            
            var result1 = Db.People.Where(p => p.Mor.Equals(person.Mor));
            var result2 = Db.People.Where(p => p.Far.Equals(person.Far));
            var result3 = result1.Union(result2).Distinct();
            foreach(var p in result3)
            {
                list.Add(p);
            }
            return list;
        }
        public Person Read(string name)
        {
            var result = Db.People.SingleOrDefault(p => p.Name.Equals(name));
            if (result != null)
            {
                Console.WriteLine("Person read.");
                return result;
            }
            Console.WriteLine("Person not read. That person doesnt exist...");
            return result;
        }

        public Person Read(int Id)
        {
            var result = Db.People.SingleOrDefault(p => p.Id == Id);
            if (result != null)
            {
                Console.WriteLine("Person read.");
                return result;
            }
            Console.WriteLine("Person not read. That person doesnt exist....");
            return result;
        }

        public void Update(Person person, string nameOfEdit) 
        {
            if (ValidPerson(nameOfEdit))
            {
                var personToEdit = Read(nameOfEdit);
                if (person.Name != null)
                {
                    personToEdit.Name = person.Name;
                }
                if (person.LastName != null)
                {
                    personToEdit.LastName = person.LastName;
                }
                if (person.YearOfBirth != 0)
                {
                    personToEdit.YearOfBirth = person.YearOfBirth;
                }
                if(person.Far != 0)
                {
                    personToEdit.Far = person.Far;
                }
                if(person.Mor != 0)
                {
                    personToEdit.Mor = person.Mor;
                }
                Save();
                Console.WriteLine("Person updated.");
            }
            else
            {
                Console.WriteLine("Update failed. That person doesnt exist...");   
            }
        }

        public void Save()
        {
            Db.SaveChanges();
            Console.WriteLine("Changes saved.");
        }
    }
}

