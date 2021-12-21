// -----------------------------------------------------------------------------------------------
//  PersonHelper.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Helpers
{
    using FamilyTreeWF.Database;
    using FamilyTreeWF.DTO;
    using FamilyTreeWF.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public static class PersonHelper
    {
        public static Person GetPersonById(int id)
        {
            using (var db = new DbAccess())
            {
                var person = db.People?.Include(x => x.BirthCity)
                                      .Include(x => x.BirthCountry)
                                      .Include(x => x.DeathCity)
                                      .Include(x => x.DeathCountry)
                                      .Include(x => x.Father)
                                      .Include(x => x.Mother)
                                      .FirstOrDefault(x => x.PersonId == id);

                return person ?? new Person();
            }
        }
        public static bool CheckForDuplicate(Person person)
        {
            using (var db = new DbAccess())
            {
                var duplicate = db.People?.Where(d => d.FirstName == person.FirstName
                                                    && d.LastName == person.LastName
                                                    && d.BirthYear == person.BirthYear
                                                    && d.FatherId == person.FatherId
                                                    && d.MotherId == person.MotherId)
                                           .FirstOrDefault(new Person { PersonId = 0 });
                bool duplicateExists = duplicate?.PersonId != 0;
                return duplicateExists;
            }
        }
        public static List<Person> GetAllPeople()
        {
            using (var db = new DbAccess())
            {
                var people = db.People?.Include(x => x.BirthCity)
                                      .Include(x => x.BirthCountry)
                                      .Include(x => x.DeathCity)
                                      .Include(x => x.DeathCountry)
                                      .Include(x => x.Father)
                                      .Include(x => x.Mother)
                                      .ToList();

                return people ?? new List<Person>();
            }
        }
        public static List<IdName> GetAllFirstLastNames(bool forComboBox = true, bool excludeSelf = false, int selfId = -2)
        {
            using (var db = new DbAccess())
            {
                var people = db.People?.Select(x => new IdName { Id = (int)x.PersonId, Name = x.FirstName + " " + x.LastName + " born in " + x.BirthYear }).ToList();
                if (forComboBox) people?.Insert(0, new IdName { Id = -1, Name = "" });
                if (excludeSelf) people?.Remove(people.First(x => x.Id == selfId));
                return people ?? new List<IdName>();
            }
        }

        internal static (int,bool) UpsertPerson(Person input)
        {
            var isPersonInDb = false;
            using (var db = new DbAccess())
            {
                if (input.PersonId == 0)
                {
                    isPersonInDb = CheckForDuplicate(input);
                    if (!isPersonInDb)
                    {
                        db.Entry(input).State = EntityState.Added;
                        db.People?.Add(input);
                    }
                }
                else db.Entry(input).State = EntityState.Modified;

                var rowsAffected= db.SaveChanges();
                return (rowsAffected, isPersonInDb);
            }
        }
        public static List<Person> GetChildren(Person person)
        {
            using (var db = new DbAccess())
            {
                var children = db.People?.Where(p => p.FatherId == person.PersonId || p.MotherId == person.PersonId).ToList();
                return children ?? new List<Person>();
            }
        }
        public static List<Person> GetGrandParents(Person person)
        {
            var parents = GetParents(person);
            return GetGrandParents(parents);
        }
        public static List<Person> GetGrandParents(List<Person> parents)
        {
            using (var db = new DbAccess())
            {
                List<Person> gramps = new();
                if (db.People != null)
                {
                    foreach (var parent in parents)
                    {
                        gramps.AddRange(db.People.Include<Person>("Father").Include<Person>("Mother").Where(p => p.PersonId == parent.FatherId || p.PersonId == parent.MotherId).ToList());
                    }
                }
                return gramps;
            }
        }

        public static List<Person> GetSiblings(Person pers)
        {
            using (var db = new DbAccess())
            {
                if ((pers.Father != null || pers.Mother != null) && db.People != null)
                    return db.People.Include<Person>("Father").Include<Person>("Mother").Where(p => (p.FatherId == pers.FatherId || p.MotherId == pers.MotherId) && p.PersonId != pers.PersonId).ToList();
                else return new List<Person>();
            }
        }

        public static List<Person> GetParents(Person pers)
        {
            using (var db = new DbAccess())
            {
                if (db.People != null) return db.People.Include("Father").Include<Person>("Mother").Where(p => p.PersonId == pers.FatherId || p.PersonId == pers.MotherId).ToList();
                else return new List<Person>();
            }
        }
        public static List<Person> GetUnclesAndAunts(Person person)
        {
            var grandparents = GetGrandParents(person);
            return GetUnclesAndAunts(grandparents, person.FatherId, person.MotherId);
        }
        public static List<Person> GetUnclesAndAunts(List<Person> grandparents, int? fatherId, int? motherId)
        {
            var unclesAndAunts = new List<Person>();
            using (var db = new DbAccess())
            {
                foreach (Person gp in grandparents)
                {
                    var tmpList = db.People?.Include("Father")
                                           .Include("Mother")
                                           .Where(p => (p.FatherId == gp.PersonId || p.MotherId == gp.PersonId) && p.PersonId != fatherId && p.PersonId != motherId)
                                           .Distinct();

                    if (tmpList != null)
                    {
                        foreach (var person in tmpList)
                        {
                            if (!unclesAndAunts.Contains(person)) unclesAndAunts.Add(person);
                        }
                    }
                }
                return unclesAndAunts.ToList();
            }
        }

        public static int DeletePerson(Person person)
        {
            int result = 0;
            using (var db = new DbAccess())
            {
                db.People?.Remove(person);
                result = db.SaveChanges();
            }
            return result;
        }
        public static List<Person> GetCousins(Person person)
        {
            var unclesAndAunts = GetUnclesAndAunts(person);
            return GetCousins(unclesAndAunts);
        }
        public static List<Person> GetCousins(List<Person> unclesAndAunts)
        {
            var cousins = new List<Person>();
            using (var db = new DbAccess())
            {
                if (db.People != null)
                {
                    foreach (var ua in unclesAndAunts)
                    {
                        cousins.AddRange(db.People.Include<Person>("Father").Include<Person>("Mother").Where(p => p.FatherId == ua.PersonId || p.MotherId == ua.PersonId));
                    }
                }
                return cousins.ToList();
            }
        }
    }
}
