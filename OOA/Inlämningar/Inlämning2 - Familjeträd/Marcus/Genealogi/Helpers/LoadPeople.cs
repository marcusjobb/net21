using Microsoft.EntityFrameworkCore;
using Genealogi.Data;
using Genealogi.Models;

namespace Genealogi.Helpers
{
    public static class LoadPeople
    {   
        static bool added = false;
        public static void Load(GenealogiDbContext db)
        {
            if(!added)
            {
                List<Person> people = new();
                people.Add(new Person() { Name = "Abe", LastName = "Simpson", BirthDate = new DateTime(1920, 08, 26), DeathDate = null, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = null, MotherId = null, Image = null });
                people.Add(new Person() { Name = "Mona", LastName = "Simpson", BirthDate = new DateTime(1929, 05, 15), DeathDate = new DateTime(2008, 05, 11), BirthPlace = "A Place", DeathPlace = "A Place", FatherId = null, MotherId = null, Image = null });

                people.Add(new Person() { Name = "Herb", LastName = "Simpson", BirthDate = new DateTime(1952, 12, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 1, MotherId = 2, Image = null });
                people.Add(new Person() { Name = "Homer", LastName = "Simpson", BirthDate = new DateTime(1956, 05, 12), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 1, MotherId = 2, Image = null });

                people.Add(new Person() { Name = "Clancy", LastName = "Bouvier", BirthDate = new DateTime(1932, 09, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = null, MotherId = null, Image = null });
                people.Add(new Person() { Name = "Jacqueline", LastName = "Bouvier", BirthDate = new DateTime(1935, 05, 08), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = null, MotherId = null, Image = null });

                people.Add(new Person() { Name = "Marge", LastName = "Bouvier", BirthDate = new DateTime(1954, 10, 02), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 5, MotherId = 6, Image = null });
                people.Add(new Person() { Name = "Patty", LastName = "Bouvier", BirthDate = new DateTime(1949, 06, 17), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 5, MotherId = 6, Image = null });
                people.Add(new Person() { Name = "Selma", LastName = "Bouvier", BirthDate = new DateTime(1947, 08, 05), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 5, MotherId = 6, Image = null });

                people.Add(new Person() { Name = "Bart", LastName = "Simpson", BirthDate = new DateTime(1977, 02, 23), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 4, MotherId = 7, Image = null });
                people.Add(new Person() { Name = "Lisa", LastName = "Simpson", BirthDate = new DateTime(1981, 05, 09), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 4, MotherId = 7, Image = null });
                people.Add(new Person() { Name = "Maggie", LastName = "Simpson", BirthDate = new DateTime(1988, 06, 16), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = 4, MotherId = 7, Image = null });

                people.Add(new Person() { Name = "Ling", LastName = "Bouvier", BirthDate = new DateTime(2002, 12, 04), DeathDate = DateTime.Now, BirthPlace = "A Place", DeathPlace = "A Place", FatherId = null, MotherId = 9, Image = null });

                foreach (var person in people)
                {
                    if (!db.People.Any(p => p.Name == person.Name && p.LastName == person.LastName && p.BirthDate == person.BirthDate))
                        db.People.Add(person);
                }

                db.SaveChanges();

                added = true;
            }
        }
    }
}
