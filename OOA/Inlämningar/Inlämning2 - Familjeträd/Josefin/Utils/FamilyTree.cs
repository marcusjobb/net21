using Genealogi_OOA_JosefinPersson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson.Utils
{
    public class FamilyTree
    {
        public void StarkFamily()
        {
            using (var checker = new Database())
            {
                int rows = checker.People.Count();
                if (rows == 0)
                {
                    using (var db = new Database())
                    {
                        db.People.Add(new Models.Person  //1
                        {
                            FirstName = "Rickard",
                            LastName = "Stark",
                            BirthDate = 1500,
                            DeathDate = 1550,
                            MotherId = 0,
                            FatherId = 0,
                        });
                        db.People.Add(new Models.Person //2
                        {
                            FirstName = "Lyarra",
                            LastName = "Stark",
                            BirthDate = 1505,
                            DeathDate = 1549,
                            MotherId = 0,
                            FatherId = 0,
                        });
                        db.People.Add(new Models.Person  //3
                        {
                            FirstName = "Hoster",
                            LastName = "Tully",
                            BirthDate = 1500,
                            DeathDate = 1550,
                            MotherId = 0,
                            FatherId = 0,
                        });
                        db.People.Add(new Models.Person //4
                        {
                            FirstName = "Minisa",
                            LastName = "Tully",
                            BirthDate = 1505,
                            DeathDate = 1549,
                            MotherId = 0,
                            FatherId = 0,
                        });
                        db.People.Add(new Models.Person  //5
                        {
                            FirstName = "Aerys",
                            LastName = "Targaryen",
                            BirthDate = 1500,
                            DeathDate = 1550,
                            MotherId = 0,
                            FatherId = 0,
                        });
                        db.People.Add(new Models.Person //6
                        {
                            FirstName = "Rhaella",
                            LastName = "Targaryen",
                            BirthDate = 1505,
                            DeathDate = 1549,
                            MotherId = 0,
                            FatherId = 0,
                        });
                        db.People.Add(new Models.Person //7
                        {
                            FirstName = "Ned",
                            LastName = "Stark",
                            BirthDate = 1525,
                            DeathDate = 1565,
                            MotherId = 2,
                            FatherId = 1,
                        });
                        db.People.Add(new Models.Person //8
                        {
                            FirstName = "Brandon",
                            LastName = "Stark",
                            BirthDate = 1526,
                            DeathDate = 1570,
                            MotherId = 2,
                            FatherId = 1,
                        });
                        db.People.Add(new Models.Person //9
                        {
                            FirstName = "Benjen",
                            LastName = "Stark",
                            BirthDate = 1527,
                            DeathDate = 1580,
                            MotherId = 2,
                            FatherId = 1,
                        });
                        db.People.Add(new Models.Person //10
                        {
                            FirstName = "Lyanna",
                            LastName = "Stark",
                            BirthDate = 1528,
                            DeathDate = 1548,
                            MotherId = 2,
                            FatherId = 1,
                        });
                        db.People.Add(new Models.Person //11
                        {
                            FirstName = "Rhaegar",
                            LastName = "Targaryen",
                            BirthDate = 1520,
                            DeathDate = 1555,
                            MotherId = 6,
                            FatherId = 5,
                        });
                        db.People.Add(new Models.Person //12
                        {
                            FirstName = "Catelyn",
                            LastName = "Stark",
                            BirthDate = 1530,
                            DeathDate = 1569,
                            MotherId = 4,
                            FatherId = 3,
                        });
                        db.People.Add(new Models.Person //13
                        {
                            FirstName = "Robb",
                            LastName = "Stark",
                            BirthDate = 1550,
                            DeathDate = 1569,
                            MotherId = 12,
                            FatherId = 7,
                        });
                        db.People.Add(new Models.Person //14
                        {
                            FirstName = "Sansa",
                            LastName = "Stark",
                            BirthDate = 1555,
                            DeathDate = 1600,
                            MotherId = 12,
                            FatherId = 7,
                        });
                        db.People.Add(new Models.Person //15
                        {
                            FirstName = "Arya",
                            LastName = "Stark",
                            BirthDate = 1556,
                            DeathDate = 1620,
                            MotherId = 12,
                            FatherId = 7,
                        });
                        db.People.Add(new Models.Person //16
                        {
                            FirstName = "Bran",
                            LastName = "Stark",
                            BirthDate = 1557,
                            DeathDate = 1624,
                            MotherId = 12,
                            FatherId = 7,
                        });
                        db.People.Add(new Models.Person //17
                        {
                            FirstName = "Rickon",
                            LastName = "Stark",
                            BirthDate = 1560,
                            DeathDate = 1570,
                            MotherId = 12,
                            FatherId = 7,
                        });
                        db.People.Add(new Models.Person //18
                        {
                            FirstName = "Jon",
                            LastName = "Snow",
                            BirthDate = 1551,
                            DeathDate = 1630,
                            MotherId = 10,
                            FatherId = 11,
                        });
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
