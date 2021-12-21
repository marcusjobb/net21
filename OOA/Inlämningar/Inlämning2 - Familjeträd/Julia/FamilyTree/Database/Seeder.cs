using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyTree.Models;

namespace FamilyTree.Database
{
    internal static class Seeder
    {
        //Instansiera databasen med data
        public static void SeedNames()
        {
            using (var db = new FamilyContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                //----------Generera personer
                if (db.People.Count() == 0)
                {
                    db.People.AddRange(new List<Person>
                    {
                                    new Person
                                    {
                                        //ID = 1,
                                        FirstName = "Harry",
                                        LastName = "Potter",
                                        BirthDate = "1980",
                                        DeathDate = "-",
                                        MotherId = 4,
                                        FatherId = 3,
                                    },
                                    new Person
                                    {
                                        //ID = 2,
                                        FirstName = "Ginny",
                                        LastName = "Weasley",
                                        BirthDate = "1981",
                                        DeathDate = "-",
                                        MotherId = 6,
                                        FatherId = 5,
                                    },
                                    new Person
                                    {
                                        //ID = 3,
                                        FirstName = "James",
                                        LastName = "Potter",
                                        BirthDate = "1960",
                                        DeathDate = "1981",
                                        MotherId = 0,
                                        FatherId = 0,
                                    },
                                    new Person
                                    {
                                        //ID = 4,
                                        FirstName = "Lily",
                                        LastName = "Evans",
                                        BirthDate = "1960",
                                        DeathDate = "1981",
                                        MotherId = 0,
                                        FatherId = 0,
                                    },
                                    new Person
                                    {
                                        //ID = 5,
                                        FirstName = "Arthur",
                                        LastName = "Weasley",
                                        BirthDate = "1950",
                                        DeathDate = "-",
                                        MotherId = 0,
                                        FatherId = 0,
                                    },
                                    new Person
                                    {
                                        //ID = 6,
                                        FirstName = "Molly",
                                        LastName = "Prewett",
                                        BirthDate = "1960",
                                        DeathDate = "-",
                                        MotherId = 0,
                                        FatherId = 0,
                                    },
                                    new Person
                                    {   //ID = 7,
                                        FirstName = "James S.",
                                        LastName = "Potter",
                                        BirthDate = "2004",
                                        DeathDate = "-",
                                        MotherId = 2,
                                        FatherId = 1,
                                    },
                                    new Person
                                    {   //ID = 8,
                                        FirstName = "Albus",
                                        LastName = "Potter",
                                        BirthDate = "2006",
                                        DeathDate = "-",
                                        MotherId = 2,
                                        FatherId = 1,
                                    },
                                    new Person
                                    {   //ID = 9,
                                        FirstName = "Lily L.",
                                        LastName = "Potter",
                                        BirthDate = "2008",
                                        DeathDate = "-",
                                        MotherId = 2,
                                        FatherId = 1,
                                    }
                                    });
                    db.SaveChanges();
                }

                //----------Generera födelseplats
                if (db.BirthPlaces.Count() == 0)
                {
                    var james1 = db.People.FirstOrDefault(p => p.FirstName == "James");
                    var lilyE = db.People.FirstOrDefault(p => p.FirstName == "Lily");
                    var harry = db.People.FirstOrDefault(p => p.FirstName == "Harry");
                    var ginny = db.People.FirstOrDefault(p => p.FirstName == "Ginny");
                    var arthur = db.People.FirstOrDefault(p => p.FirstName == "Arthur");
                    var molly = db.People.FirstOrDefault(p => p.FirstName == "Molly");
                    var james2 = db.People.FirstOrDefault(p => p.FirstName == "James S.");
                    var lilyP = db.People.FirstOrDefault(p => p.FirstName == "Lily L.");
                    var albus = db.People.FirstOrDefault(p => p.FirstName == "Albus");

                    db.BirthPlaces.Add(new BirthPlace { Name = "Godric's Hollow", Country = "England", People = new List<Person> { james1, harry } });
                    db.BirthPlaces.Add(new BirthPlace { Name = "The Burrow", Country = "England", People = new List<Person> { ginny } });
                    db.BirthPlaces.Add(new BirthPlace { Name = "Cokeworth", Country = "England", People = new List<Person> { lilyE } });
                    db.BirthPlaces.Add(new BirthPlace { Name = "Unknown", Country = "England", People = new List<Person> { arthur, molly, james2, lilyP, albus } });
                    db.SaveChanges();
                }

                //----------Generera dödsplats
                if (db.DeathPlaces.Count() == 0)
                {
                    var james1 = db.People.FirstOrDefault(p => p.FirstName == "James" && p.BirthDate == "1960");
                    var lilyE = db.People.FirstOrDefault(p => p.FirstName == "Lily" && p.LastName == "Evans");

                    db.DeathPlaces.Add(new DeathPlace { Name = "Godric's Hollow", Country = "England", People = new List<Person> { james1, lilyE } });
                    db.SaveChanges();
                }
            }
        }
    }
}
