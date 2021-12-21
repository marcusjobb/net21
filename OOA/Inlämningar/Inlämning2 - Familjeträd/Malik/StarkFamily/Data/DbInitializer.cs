using StarkFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarkFamily.Data
{
    public class DbInitializer
    {
        public static void Initialize(FamilyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Personos.Any())
            {
                return;   // DB has been seeded
            }

            var persons = new Person[]
            {
            new Person{Id=1, FirstName="Rickard",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21")},
            new Person{Id=2, FirstName="Mother",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21")},
            new Person{Id=3, FirstName="Brandon",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"),DeathDate=DateTime.Parse("1986-9-21"),FatherId=1,/*MotherId=2*/},
            new Person{FirstName="Eddard",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=1},
            new Person{FirstName="Benjen",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=1},
            new Person{Id=5, FirstName="Lyanna",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=1},
            new Person{Id=4, FirstName="Catelyn",LastName="Tulle", BirthDate=DateTime.Parse("1936-03-17"),DeathDate=DateTime.Parse("1986-9-21")},
            new Person{Id=6, FirstName = "Rhaenys", LastName = "Tagaryen", BirthDate = DateTime.Parse("1936-03-17"), DeathDate = DateTime.Parse("1986-9-21"), FatherId =3},
            new Person{FirstName="Robb",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"),DeathDate=DateTime.Parse("1986-9-21"),FatherId=3 },
            new Person{FirstName="Snas",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=3,/*MotherId=4*/},
            new Person{FirstName="Arya",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=3 },
            new Person{FirstName="Bran",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=3 },
            new Person{FirstName="Rickon",LastName="Stark", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=3 },
            new Person{FirstName="Jon",LastName="Snow", BirthDate=DateTime.Parse("1936-03-17"), DeathDate=DateTime.Parse("1986-9-21"),FatherId=6,/*MotherId=5*/ },
            };
            foreach (Person s in persons)
            {
                context.Personos.Add(s);
            }
            context.SaveChanges();
        }
    }
}
