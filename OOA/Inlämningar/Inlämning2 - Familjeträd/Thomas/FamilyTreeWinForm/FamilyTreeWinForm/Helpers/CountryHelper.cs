// -----------------------------------------------------------------------------------------------
//  CountryHelper.cs by Thomas Thorin, Copyright (C) 2021.
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

    public static class CountryHelper
    {
        public static int RemoveCountry(Country country)
        {
            int rows = 0;
            using (var db = new DbAccess())
            {
                if (db.Countries?.Any(c => c.CountryId == country.CountryId && c.Name == country.Name) == true)
                {
                    db.Countries.Remove(country);
                    rows = db.SaveChanges();
                }
            }
            return rows;
        }
        internal static int RenameCountry(Country country)
        {
            var result = 0;
            using (var db = new DbAccess())
            {
                db.Countries?.Update(country);
                result = db.SaveChanges();
            }
            return result;
        }
        public static Country AddCountry(Country country)
        {
            using (var db = new DbAccess())
            {
                db.Countries?.Add(country);
                db.SaveChanges();
                return country;
            }
        }
        public static Country GetCountryByName(string name)
        {
            using (var db = new DbAccess())
            {
                var country = db.Countries?.FirstOrDefault(x => x.Name == name);
                return country ?? new Country();
            }
        }
        public static Country GetCountryById(int id)
        {
            using (var db = new DbAccess())
            {
                var country = db.Countries?.FirstOrDefault(x => x.CountryId == id);
                return country ?? new Country();
            }
        }
        public static List<Country> GetAllCountries()
        {
            using (var db = new DbAccess())
            {
                if (db.Countries != null) return db.Countries.Include("PeopleBorn").Include("PeopleDead").ToList();
                else return new List<Country>();
            }
        }
        public static List<IdName> GetAllCountryNames()
        {
            using (var db = new DbAccess())
            {
                var countries = db.Countries?.Select(x => new IdName { Id = x.CountryId, Name = x.Name }).ToList();
                countries?.Insert(0, new IdName { Id = -1, Name = "" });
                return countries ?? new List<IdName>();
            }
        }
    }
}
