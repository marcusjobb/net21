using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Genealogy.Utils.CRUD;
using EF_Genealogy.Models;
using EF_Genealogy.Utils;

namespace EF_Genealogy.Data
{
    public static class InitializeDB
    {

        internal static void RunInitializer()
        {
            // Uncomment to reset database on launch
            //ClearDatabase();
            CreateAndMigrate();
            Seed();
        }
         
        /// <summary>
        /// Seeds the DB with locations and people
        /// </summary>
        private static void Seed()
        {
            SeedPlanets();
            SeedPeople();

        }

        private static void SeedPeople()
        {
            // Person has to be created and saved before another database connection, to avoid duplication of the other DbEntityHandler additions, which is why this section looks quite wonky.
            var seededLuke = DbEntityHandler.FindOrCreateReturnPerson("Luke", "Skywalker");
            var seededAnakin = DbEntityHandler.FindOrCreateReturnPerson("Anakin", "Skywalker");
            var seededPadme = DbEntityHandler.FindOrCreateReturnPerson("Padmé", "Amidala");
            //-------------------------------------------------------------------------------
            seededLuke.FatherID = DbEntityHandler.FindOrCreatePerson("Anakin", "Skywalker");
            seededLuke.MotherID = DbEntityHandler.FindOrCreatePerson("Padmé", "Amidala");
            seededLuke.SpouseID = DbEntityHandler.FindOrCreatePerson("Mara", "Jade");
            seededLuke.BirthDate = "19 BBY";
            seededLuke.BirthLocation = "Tatooine";
            DbEntityHandler.AddEvent(seededLuke, "Used to bullseye womp rats in his T-16 Skyhopper");
            DbEntityHandler.UpdatePerson(seededLuke);
            //-------------------------------------------------------------------------------
            seededAnakin.MotherID = DbEntityHandler.FindOrCreatePerson("Shmi", "Skywalker");
            seededAnakin.BirthLocation = "Tatooine";
            seededAnakin.BirthDate = "41 BBY";
            seededAnakin.DeathDate = "4 ABY";
            seededAnakin.DeathLocation = "Death Star II";
            DbEntityHandler.AddEvent(seededAnakin, "Was denied the rank of Jedi Master by the Jedi Council");
            DbEntityHandler.AddEvent(seededAnakin, "Became Darth Sidious apprentice as Darth Vader");
            //seededAnakin.PersonHistory = new List<HistoricalEvent> { new HistoricalEvent { EventDescription = "Became Darth Sidious apprentice as Darth Vader", EventLocation = new Place { LocationName = "Coruscant" } } };
            DbEntityHandler.UpdatePerson(seededAnakin);
            //-------------------------------------------------------------------------------
            seededPadme.FatherID = DbEntityHandler.FindOrCreatePerson("Ruwee", "Naberrie");
            seededPadme.MotherID = DbEntityHandler.FindOrCreatePerson("Jobal", "Naberrie");
            seededPadme.BirthLocation = "Naboo";
            seededPadme.BirthDate = "46 BBY";
            seededPadme.DeathDate = "19 BBY";
            seededPadme.DeathLocation = "Polis Massa";
            DbEntityHandler.AddEvent(seededPadme, "Elected Queen of Naboo");
            DbEntityHandler.UpdatePerson(seededPadme);
            //-------------------------------------------------------------------------------
        }

        private static void SeedPlanets()
        {
            // Locations of class "Place" are not used anymore but they are here for posterity in case I can add the class properly at a later date.
            List<string> seedPlanets = new List<string>
            {
                "Tatooine",
                "Coruscant",
                "Dantooine",
                "Mustafar",
                "Endor",
                "Yavin IV",
                "Naboo",
                "Korriban",
                "Dagobah",
                "Dathomir",
                "Kashyyk",
                "Bespin",
                "Geonosis",
                "Hoth",
                "Kamino",
                "Alderaan",
            };
            foreach (var planet in seedPlanets)
            {
                DbEntityHandler.FindOrCreatePlanet(planet);
            }
        }

        private static void ClearDatabase()
        {
            using (var db = new GenealogyContext())
            {
                db.Database.EnsureDeleted();
            }
        }


        // If the database doesn't exists, creates it and applies all migrations onto it (without deleting it)
        private static void CreateAndMigrate()
        {
            using (var context = new GenealogyContext())
            {  
                context.Database.Migrate();
            }
        }
    }
}
