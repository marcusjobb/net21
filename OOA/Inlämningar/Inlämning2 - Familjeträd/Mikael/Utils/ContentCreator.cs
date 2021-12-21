using System.Linq;

namespace Inlämning_2_EntityFramwork.Utils;
public class ContentCreator
{

    public void ContentCreation() //Metod som adderar karaktärer om databasen är tom.
    {
        using (var checker = new DBClass()){

            int rows = checker.People.Count();
            if (rows == 0)
            {

                using (var db = new DBClass())
                {
                    db.People.Add(new Models.Person()
                    {
                        Name = "Tommy",
                        LastName = "Shelby",
                        BirthYear = 1890,
                        DeathYear = null,
                        Father = 1,
                        Mother = 2,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "Polly",
                        LastName = "Gray",
                        BirthYear = 1884,
                        DeathYear = null,
                        Father = null,
                        Mother = 3,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "John",
                        LastName = "Shelby",
                        BirthYear = 1895,
                        DeathYear = 1925,
                        Father = 1,
                        Mother = 2,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "Charles",
                        LastName = "Shelby",
                        BirthYear = 1922,
                        DeathYear = 1946,
                        Father = 4,
                        Mother = 5,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "Arthur Jr",
                        LastName = "Shelby",
                        BirthYear = 1887,
                        DeathYear = null,
                        Father = 1,
                        Mother = 2,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "Arthur Sr",
                        LastName = "Shelby",
                        BirthYear = 1860,
                        DeathYear = 1924,
                        Father = null,
                        Mother = 3,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "Ada",
                        LastName = "Thorne",
                        BirthYear = 1897,
                        DeathYear = null,
                        Father = 1,
                        Mother = 2,
                    });
                    db.People.Add(new Models.Person()
                    {

                        Name = "Karl",
                        LastName = "Thorne",
                        BirthYear = 1919,
                        DeathYear = null,
                        Father = 6,
                        Mother = 5,
                    });
                    db.SaveChanges();
                }
                }
            }
            
        }
    }




