using EF_Genealogy.Data;
using EF_Genealogy.Models;
using EF_Genealogy.Utils.UserInput;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Utils.CRUD
{
    public static class SearchEntries
    {

        public static Person GetPersonByID(int ID)
        {
            using var db = new GenealogyContext();

            var person = db.People
                //.Include("BirthLocation").Include("DeathLocation")
                .Include("PersonHistory")//.Include("Spouse")
                .FirstOrDefault(p => p.ID == ID);
            return person;
        }

        public static int GetPersonByIDReturnID(int ID)
        {
            using var db = new GenealogyContext();
            var person = db.People
                //.Include("BirthLocation").Include("DeathLocation")
                .Include("PersonHistory")//.Include("Spouse")
                .FirstOrDefault(p => p.ID == ID);
            return person.ID;
        }

        // Uses "Contains" instead of "==" for smoother searches.
        public static List<Person> GetPeopleByName(string name)
        {
            using var db = new GenealogyContext();
            var personList = db.People
                //.Include("BirthLocation").Include("DeathLocation")
                .Include("PersonHistory")//.Include("Spouse")
                .Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name)).ToList();
            return personList;
        }

        public static List<Person> GetPeopleBySameNameLetter(string name)
        {
            using var db = new GenealogyContext();
            var personList = db.People
                //.Include("BirthLocation").Include("DeathLocation")
                .Include("PersonHistory")//.Include("Spouse")
                .Where(p => p.FirstName.StartsWith(@name)).ToList();
            return personList;
        }

        public static List<Person> GetPeopleByPlanet(string homeplanet)
        {
            using var db = new GenealogyContext();
            var personList = db.People
                //.Include("BirthLocation").Include("DeathLocation")
                .Include("PersonHistory")//.Include("Spouse")
                .Where(p => p.BirthLocation == homeplanet).ToList();
            return personList;
        }

        public static List<Person> GetPeopleByBirthDate(string date)
        {
            
            using var db = new GenealogyContext();
            var personList = db.People
                //.Include("BirthLocation").Include("DeathLocation")
                .Include("PersonHistory")//.Include("Spouse")
                .Where(p => p.BirthDate == date).ToList();
            return personList;
        }

        /// <summary>
        /// Searches for people who has the same mother and father of the parameter person, stores them all in a list which is then returned.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static List<Person> GetSiblings(Person person)
        {
            using var db = new GenealogyContext();
            var siblingList = db.People.
                Include("PersonHistory")//.Include("Spouse")
                .Where(s => s.FatherID == person.FatherID || s.MotherID == person.MotherID)
                .Where(s => s.FatherID != null && s.MotherID != null)
                .Where(s => s.FatherID != person.ID && s.MotherID != person.ID)
                .Where(s =>s.ID != person.ID).ToList();
            return siblingList;
        }


        public static List<Person> GetChildren(Person person)
        {
            using var db = new GenealogyContext();
            var childrenList = db.People.
                Include("PersonHistory")//.Include("Spouse")
                .Where(c => c.FatherID == person.ID || c.MotherID == person.ID).ToList();
            return childrenList;
        }
        public static bool DoesPersonExist(string firstName, string lastName)
        {
            bool personExists = false;
            using (var db = new GenealogyContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);
                if (person != null)
                    personExists = true;
            }
            return personExists;
        }

        public static bool DoesPersonExist(int id)
        {
            bool personExists = false;
            using (var db = new GenealogyContext())
            {
                var person = db.People.FirstOrDefault(p => p.ID == id);
                if (person != null)
                    personExists = true;
            }
            return personExists;
        }
        public static bool DoesPersonExist(Person person)
        {
            bool personExists = false;
            using (var db = new GenealogyContext())
            {
                var foundPerson = db.People.FirstOrDefault(p => p.ID == person.ID);
                if (foundPerson != null)
                    personExists = true;
            }
            return personExists;
        }
    }
}
