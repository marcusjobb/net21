using Inlämning2byDB.Models;
using System.Linq;

namespace Inlämning2byDB.Data
{
    public static class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Persons.Any())
            {
                return;
            }

            var persons = new Person[]
            {
            // Generation X
            new Person{FirstName="Abe",LastName="Simpson",FatherId=null, MotherId=null}, // [id=1]
            new Person{FirstName="Mona",LastName="Simpson",FatherId=null, MotherId=null}, // [id=2]
            new Person{FirstName="Clancy",LastName="Bouvier",FatherId=null, MotherId=null}, // [id=3]
            new Person{FirstName="Jacqueline",LastName="Bouvier",FatherId=null, MotherId=null}, // [id=4]

            // Generation Y.
            new Person{FirstName="Herb",LastName="Simpson",FatherId=1, MotherId=2}, // [id=5]
            new Person{FirstName="Homer",LastName="Simpson",FatherId=1, MotherId=2}, // [id=6]
            new Person{FirstName="Marge",LastName="Bouvier",FatherId=3, MotherId=4}, // [id=7]
            new Person{FirstName="Patty",LastName="Bouvier",FatherId=3, MotherId=4}, // [id=8]
            new Person{FirstName="Selma",LastName="Bouvier",FatherId=3, MotherId=4}, // [id=9]

            // Generation Z.
            new Person{FirstName="Bart",LastName="Simpson",FatherId=6, MotherId=7}, // [id=10]
            new Person{FirstName="Lisa",LastName="Simpson",FatherId=6, MotherId=7}, // [id=11]
            new Person{FirstName="Maggie",LastName="Simpson",FatherId=6, MotherId=7}, // [id=12]
            new Person{FirstName="Ling",LastName="Bouvier",FatherId=null, MotherId=9} // [id=13]
            };
            foreach (Person p in persons)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();
        }
    }
}
