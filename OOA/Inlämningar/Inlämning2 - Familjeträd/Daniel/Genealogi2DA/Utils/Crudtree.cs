using Genealogi2DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi2DA.Utils
{
    public class FamTree
    {
        internal void Thestarks()
        {
            using var hantera = new Database();
            {
                int add = hantera.People.Count();
                if (add == 0)
                {
                    using (var db = new Database())
                    {
                        db.People.Add(new Person
                        { 
                            FirstName = "Rickard", LastName = "Stark",
                            BirthDate = 1500, DeathDate = 1550,
                            MotherId = 0, FatherId = 0, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Lyarra", LastName = "Stark",
                        BirthDate = 1505, DeathDate = 1549,
                        MotherId = 0, FatherId = 0, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Brandon", LastName = "Stark",
                        BirthDate = 1526, DeathDate = 1570,
                        MotherId = 2, FatherId = 1, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Arya", LastName = "Stark",
                        BirthDate = 1556, DeathDate = 1620,
                        MotherId = 8, FatherId = 3, });

                    db.People.Add(new Person
                    {
                        FirstName = "Rickon", LastName = "Stark",
                        BirthDate = 1560, DeathDate = 1570,
                        MotherId = 8, FatherId = 3, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Jon", LastName = "Snow",
                        BirthDate = 1551, DeathDate = 1630,
                        MotherId = 6, FatherId = 7, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Ned", LastName = "Stark",
                        BirthDate = 1525, DeathDate = 1565,
                        MotherId = 2, FatherId = 1, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Bran", LastName = "Stark",
                        BirthDate = 1557, DeathDate = 1624,
                        MotherId = 2, FatherId = 1, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Benjen", LastName = "Stark",
                        BirthDate = 1527, DeathDate = 1580,
                        MotherId = 2, FatherId = 1, });

                    db.People.Add(new Person
                    {
                        FirstName = "Lyanna", LastName = "Stark",
                        BirthDate = 1528, DeathDate = 1548,
                        MotherId = 2, FatherId = 1, });
                    db.People.Add(new Person
                    {
                        FirstName = "Rhaegar", LastName = "Targaryen",
                        BirthDate = 1520, DeathDate = 1555,
                        MotherId = 0, FatherId = 0, });

                    db.People.Add(new Person 
                    {
                        FirstName = "Catelyn", LastName = "Stark",
                        BirthDate = 1530, DeathDate = 1569,
                        MotherId = 0, FatherId = 0, });
                    db.People.Add(new Person 
                    {
                        FirstName = "Robb", LastName = "Stark",
                        BirthDate = 1550, DeathDate = 1569,
                        MotherId = 8, FatherId = 3,
                    });
                    db.People.Add(new Person 
                    {
                        FirstName = "Sansa", LastName = "Stark",
                        BirthDate = 1555, DeathDate = 1600,
                        MotherId = 8, FatherId = 3, });
                   
                    db.SaveChanges();
                }
            }
        }
    }
}
}


