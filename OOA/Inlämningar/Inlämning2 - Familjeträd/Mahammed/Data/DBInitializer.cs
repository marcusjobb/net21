using EF_inlämning_2.Models;

namespace EF_inlämning_2.Data
{
    public class DBInitializer
    {
        public static void Initialize(DataContext context)

        {
            context.Database.EnsureCreated();

            if (context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {
                // GenerationId 1 Hus Stark
            new Person {
                FirstName = "Rickard",
                LastName = "Stark",
                FatherId=0,
                MotherId=0,
            },//Id 1
            new Person {
                FirstName = "Lyarra",
                LastName = "Stark",
                FatherId = 0,
                MotherId = 0,
            },//Id 2
            // GenerationId 2 Hus Stark
            new Person {
                FirstName = "Bradon",
                LastName = "Stark",
                FatherId =1,
                MotherId =2,
            },//Id 3
            new Person {
                FirstName ="Benjen",
                LastName = "Stark",
                FatherId =1,
                MotherId =2,
            },//Id 4
            // jon snows päron
            new Person {
                FirstName = "Lyanna",
                LastName = "Stark",
                FatherId =1,
                MotherId =2,
            },//Id 5
            new Person {
                FirstName = "Rhaegar",
                LastName = "Targaryen",
                FatherId =0,
                MotherId =0,
            },//Id 6

            new Person {
                FirstName = "Eddard (Ned) ",
                LastName  = "Stark",
                FatherId =1,
                MotherId =2,
            },//Id 7
            new Person {
                FirstName = "Catlyn (Tully) ",
                LastName ="Stark",
                FatherId =0,
                MotherId =0,
            },//Id 8
            // GenerationId 3 Hus Stark
            new Person {
                FirstName ="Robb",
                LastName ="Stark",
                FatherId =7,
                MotherId =8,
            },//Id 9
            new Person {
                FirstName = "Sansa",
                LastName = "Stark",
                FatherId =7,
                MotherId =8,
            },//Id 10
            new Person {
                FirstName = "Bran",
                LastName = "Stark",
                FatherId =7,
                MotherId =8,
            },//Id 11
            new Person {
                FirstName = "Arya",
                LastName = "Stark",
                FatherId =7,
                MotherId =8,
            },//Id 12
            new Person {
                FirstName = "Rickon",
                LastName = "Stark",
                FatherId =7,
                MotherId =8,
            },//Id 13

            new Person {
                FirstName = "Jon",
                LastName = "Snow",
                FatherId =6,
                MotherId =5,
            },//Id 14
            };
            foreach (Person person in people)
            {
                context.People.AddRange(person);
            }

            context.SaveChanges();
        }
    }
}