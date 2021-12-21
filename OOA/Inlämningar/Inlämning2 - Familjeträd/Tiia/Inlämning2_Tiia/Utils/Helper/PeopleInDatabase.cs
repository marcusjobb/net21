using Inlämning2_Tiia.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia.Utils.Helper
{
    class PeopleInDatabase
    {
        public static void PersonsAdded()
        {
            using (var checker = new PersonContext())
            {
                int rows = checker.People.Count();
                
                if (rows == 0)
                {
                    using (var db = new PersonContext())
                    {                        
                        db.People.Add(new Person // ID = 1
                        {
                            FirstName = "Rhaegar",
                            LastName = "Targaryen",
                            MotherId = 6,
                            FatherId = 5,
                        });

                        db.People.Add(new Person // ID = 2
                        {
                            FirstName = "Viserys",
                            LastName = "Targaryen",
                            MotherId = 6,
                            FatherId = 5,
                        });
                        
                        db.People.Add(new Person // ID = 3
                        {
                            FirstName = "Daenerys",
                            LastName = "Targaryen",
                            MotherId = 6,
                            FatherId = 5,
                        }); 
                        
                        db.People.Add(new Person // ID = 4
                        {
                            FirstName = "Elia",
                            LastName = "Martell",
                            MotherId = null,
                            FatherId = null,
                        }); 
                        
                        db.People.Add(new Person // ID = 5
                        {
                            FirstName = "Aerys",
                            LastName = "Targaryen",
                            MotherId = null,
                            FatherId = null,
                        });

                        db.People.Add(new Person // ID = 6
                        {
                            FirstName = "Rhaella",
                            LastName = "Targaryen",
                            MotherId = null,
                            FatherId = null,
                        });

                        db.People.Add(new Person // ID = 7
                        {
                            FirstName = "Lyanna",
                            LastName = "Stark",
                            MotherId = null,
                            FatherId = null,
                        });

                        db.People.Add(new Person // ID = 8
                        {
                            FirstName = "Jon",
                            LastName = "Snow",
                            MotherId = 7,
                            FatherId = 1,
                        });

                        db.People.Add(new Person // ID = 9
                        {
                            FirstName = "Rhaenys",
                            LastName = "Targaryen",
                            MotherId = 4,
                            FatherId = 1,
                        });

                        db.People.Add(new Person // ID = 10
                        {
                            FirstName = "Aegon",
                            LastName = "Targaryen",
                            MotherId = 4,
                            FatherId = 1,
                        });
                        
                        db.SaveChanges();
                    }
                    checker.SaveChanges();
                }
            }
        }
    }
}
