using EF_Genealogy.Data;
using EF_Genealogy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Utils
{
    public static class DbEntityHandler
    {
        public static void AddPerson(Person person)
        {
            using var db = new GenealogyContext();
            db.People.Add(person);
            db.SaveChanges();
        }

        public static void UpdatePerson(Person person)
        {
            using var db = new GenealogyContext();
            db.Update(person);
            db.SaveChanges();
        }

        public static void DeletePerson(Person person)
        {
            using var db = new GenealogyContext();
            db.Remove(person);
            db.SaveChanges();
        }


        public static void AddPlanet(Place planet)
        {
            using var db = new GenealogyContext();
            db.Locations.Add(planet);
            db.SaveChanges();
        }

        public static void FindOrCreatePlanet(string planetname)
        {
            using var db = new GenealogyContext();
            var planet = db.Locations.FirstOrDefault(
                p => p.LocationName == planetname);
            if (planet == null)
            {
                planet = new Place { LocationName = planetname };
                db.Locations.Add(planet);
                db.SaveChanges();
            }
        }
        public static Place FindOrCreatePlanetReturnPlanet(string planetname)
        {
            using var db = new GenealogyContext();
            var planet = db.Locations.FirstOrDefault(
                p => p.LocationName == planetname);
            if (planet == null)
            {
                planet = new Place { LocationName = planetname };
                db.Locations.Add(planet);
                db.SaveChanges();
            }
            return planet;
        }

        public static int FindOrCreatePerson(string name, string lastname)
        {
            using var db = new GenealogyContext();
            var person = db.People.FirstOrDefault(
                p => p.FirstName == name && (p.LastName == lastname));
            if (person == null)
            {
                person = new Person { FirstName = name, LastName = lastname };
                db.People.Add(person);
                db.SaveChanges();
            }
            return person.ID;
        }

        public static Person FindOrCreateReturnPerson(string name, string lastname)
        {
            using var db = new GenealogyContext();

            var person = db.People.FirstOrDefault(
                p => p.FirstName == name && (p.LastName == lastname));
            if (person == null)
            {
                person = new Person { FirstName = name, LastName = lastname };
                db.People.Add(person);
                db.SaveChanges();
            }
            return person;
        }

        public static int GetPersonID(string name, string lastname)
        {
            using var db = new GenealogyContext();
            var person = db.People.FirstOrDefault(
                p => p.FirstName == name && (p.LastName == lastname));
            return person.ID;
        }        

        /// <summary>
        /// Adds an event + event description to the database, linked to the person sent in. I think this works.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="eventDesc"></param>
        public static void AddEvent(Person person, string eventDesc)
        {
            using var db = new GenealogyContext();
            db.Attach(person);
            
            var lifeEvent = new HistoricalEvent();
            // If there are no events with the same description, creates one. Maybe better to search unique event ID's, comparing them to the event.person ID?
            var uniqueEvent = db.LifeEvents.FirstOrDefault(e=> e.EventDescription == eventDesc);

            if (uniqueEvent == null)
            {
                lifeEvent.EventDescription = eventDesc;
                lifeEvent.EventPerson = person;
                db.LifeEvents.Add(lifeEvent);
                db.SaveChanges();
            }
        }
    }
}
