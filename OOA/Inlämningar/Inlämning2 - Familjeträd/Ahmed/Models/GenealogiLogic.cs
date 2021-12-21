using Inlämning2.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2.Models
{
    public class GenealogiLogic : IGenealogiCRUD
    {
        public void Clear()
        {
            using (var db = new FamilyTreeContext())
            {
                db.People.RemoveRange(db.People);
                db.SaveChanges();
            }
        }

        public void Create(Person person)
        {
            using (var db = new FamilyTreeContext())
            {
                db.People.Add(person);
                db.SaveChanges();
            }
        }

        public void Create(List<Person> people)
        {
            using (var db = new FamilyTreeContext())
            {
                db.People.AddRange(people);
                db.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var db = new FamilyTreeContext())
            {
                var selectedPerson = db.People.FirstOrDefault(x => x.ID == Id);
                if (selectedPerson == null)
                {
                    return;
                }
                db.Remove(selectedPerson);

                db.SaveChanges();
            }
        }

        public void Delete(string name)
        {
            using (var db = new FamilyTreeContext())
            {
                var selectedPerson = db.People.FirstOrDefault(x => x.FirstName == name);
                if (selectedPerson == null)
                {
                    return;
                }
                db.Remove(selectedPerson);

                db.SaveChanges();
            }
        }

        public Person GetFather(int Id)
        {
            var child = Read(Id);
            if (child == null || child.Father == null)
            {
                return null;
            }
            return Read((int)child.Father);
        }

        public Person GetMother(int Id)
        {
            var child = Read(Id);
            if (child == null || child.Mother == null)
            {
                return null;
            }
            return Read((int)child.Mother);
        }

        public List<Person> GetOffsprings(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Person> List(string filter = "firstName")
        {
            using (var db = new FamilyTreeContext())
            {
                switch(filter)
                {
                    case "lastName":
                        return db.People.OrderBy(x => x.LastName).ToList();
                    default:
                        return db.People.OrderBy(x => x.FirstName).ToList();
                }
            }
        }

        public Person Read(string name)
        {
            if (name == null)
            {
                return null;
            }
            using (var db = new FamilyTreeContext())
            {
                return db.People.FirstOrDefault(person => person.FirstName.ToLower() == name.ToLower());
            }
        }

        public Person Read(int Id)
        {
            using (var db = new FamilyTreeContext())
            {
              return  db.People.FirstOrDefault(x => x.ID == Id);
            }
        }

        public void SetFather(int offspringId, int fatherId)
        {
            var offspring = Read(offspringId);
            var father = Read(fatherId);

            if (offspring == null || father == null)
            {
                return;
            }

            using (var db = new FamilyTreeContext())
            {
                var person = db.People.FirstOrDefault(x => x.ID == offspringId);
                person.Father = fatherId;
                db.SaveChanges();
            }
        }

        public void SetMother(int offspringId, int motherId)
        {
            var offspring = Read(offspringId);
            var mother = Read(motherId);

            if (offspring == null || mother == null)
            {
                return;
            }

            using (var db = new FamilyTreeContext())
            {
                var person = db.People.FirstOrDefault(x => x.ID == offspringId);
                person.Mother = motherId;
                db.SaveChanges();
            }
        }

        public void Update(Person person)
        {
            using (var db = new FamilyTreeContext())
            {
                var selectedPerson = db.People.FirstOrDefault(x => x.ID == person.ID);
                if (selectedPerson == null)
                {
                    return;
                }
                selectedPerson.FirstName = person.FirstName ?? selectedPerson.FirstName;
                selectedPerson.LastName = person.LastName ?? selectedPerson.LastName;
                selectedPerson.BirthDate = person.BirthDate ?? selectedPerson.BirthDate;
                selectedPerson.DeathDate = person.DeathDate ?? selectedPerson.DeathDate;
                db.SaveChanges();
            }
        }
    }
}
