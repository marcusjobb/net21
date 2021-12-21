using Inlämning2byDB.Data;
using Inlämning2byDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inlämning2byDB.Services
{
    public class PersonService
    {
        private readonly ApplicationDbContext _db;

        public PersonService(ApplicationDbContext db)
        {
            _db = db;
        }

        // Hämta alla personer.
        public IEnumerable<Person> GetAllPersons()
        {
            return _db.Persons;
        }

        // Hämta en person.
        public Person GetPerson(int id) 
        {
            return _db.Persons.Find(id);
        }

        // Skapar en person.
        public Person CreatePerson(Person person)
        {
            var savedPerson = _db.Persons.Add(person);
            _db.SaveChanges();
            return savedPerson.Entity;
        }

        // Ta bort en person.
        public void DeletePerson(Person person)
        {
            var deletedPerson = _db.Persons.Remove(person);
            _db.SaveChanges();
        }

        // Updaterar person.
        public Person UpdatePerson(Person person)
        {
            var updatedPerson = _db.Persons.Update(person);
            _db.SaveChanges();
            return updatedPerson.Entity;
        }

        // Get Childrens
        public List<Person> GetChildrens(int parentId)
        {
            var children = _db.Persons.Where(person => person.FatherId == parentId || person.MotherId == parentId);
            return children.ToList();
        }
    }
}
