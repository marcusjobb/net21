// -----------------------------------------------------------------------------------------------
//  CityHelper.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Helpers
{
    using FamilyTreeWF.Database;
    using FamilyTreeWF.DTO;
    using FamilyTreeWF.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CityHelper
    {
        public static int RemoveCity(City city)
        {
            int rows = 0;
            using (var db = new DbAccess())
            {
                if ((db.Cities?.Any(c => c.CityId == city.CityId && c.Name == city.Name)) == true)
                {
                    db.Cities.Remove(city);
                    rows = db.SaveChanges();
                }
            }
            return rows;
        }
        public static City AddCity(City city)
        {
            using (var db = new DbAccess())
            {
                db.Cities?.Add(city);
                db.SaveChanges();
                return city;
            }
        }
        public static City GetCityByName(string name)
        {
            using (var db = new DbAccess())
            {
                var city = db.Cities?.FirstOrDefault(x => x.Name == name);
                return city ?? new City();
            }
        }
        internal static City? GetCityById(int id)
        {
            using (var db = new DbAccess())
            {
                var city = db.Cities?.FirstOrDefault(x => x.CityId == id);
                return city ?? (City?)new City();
            }
        }
        /// <summary>
        /// Method for getting a list with all the countries and
        /// related information.
        /// </summary>
        /// <returns>List of City</returns>
        public static List<City> GetAllCities()
        {
            using (var db = new DbAccess())
            {
                if (db.Cities != null) return db.Cities.Include("PeopleBorn").Include("PeopleDead").ToList();
                else return new List<City>();
            }
        }

        internal static int RenameCity(City city)
        {
            var result = 0;
            using (var db = new DbAccess())
            {
                db.Cities?.Update(city);
                result = db.SaveChanges();
            }
            return result;
        }

        /// <summary>
        /// Returns a List of IdName DTO containing countryId and names.
        /// </summary>
        /// <returns>List containing country ids and names.</returns>
        public static List<IdName> GetAllCityNames()
        {
            using (var db = new DbAccess())
            {
                var cities = db.Cities?.Select(x => new IdName { Id = x.CityId, Name = x.Name }).ToList();
                cities?.Insert(0, new IdName { Id = -1, Name = "" });
                return cities ?? new List<IdName>();
            }
        }
    }
}
