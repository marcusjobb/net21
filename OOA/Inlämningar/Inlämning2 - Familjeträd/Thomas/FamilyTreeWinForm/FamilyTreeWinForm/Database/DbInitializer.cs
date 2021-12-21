// -----------------------------------------------------------------------------------------------
//  DbInitializer.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Database
{
    using FamilyTreeWF.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public static class DbInitializer
    {
        public static void Initialize(DbAccess db)
        {
            using (db)
            {
                var created = db.Database.EnsureCreated();
                if (created) MessageBox.Show("Database created.","Database");

                if (db.Cities?.Any() == true)
                {
                    return;   // DB has been seeded
                }

                var cities = new City[]
                {
                    new City {Name = "Stockholm"},//1
                    new City {Name = "Köpenhamn"},//2
                    new City {Name = "Gotha"},//3
                    new City {Name = "Heidelberg"},//4
                    new City {Name = "Porto Feliz"},//5
                    new City {Name = "Drottningholm"},//6
                    new City {Name = "Solna"},//7
                    new City {Name = "São Paulo"},//8
                    new City {Name = "Huddinge"},//9
                    new City {Name = "Aachen"},//10
                    new City {Name = "Örebro"},//11
                    new City {Name = "Täby"},//12
                    new City {Name = "London"},//13
                    new City {Name = "Danderyd"},//14
                    new City {Name = "New York"}//15
                };
                foreach (City c in cities)
                {
                    db.Cities?.Add(c);
                }
                db.SaveChanges();

                var countries = new Country[]
                {
                    new Country{Name = "Sverige" },
                    new Country{Name = "Danmark" },
                    new Country{Name = "Tyskland" },
                    new Country{Name = "Brasilien" },
                    new Country{Name = "Storbritannien" },
                    new Country{Name = "USA" }
                };
                foreach (Country c in countries)
                {
                    db.Countries?.Add(c);
                }
                db.SaveChanges();

                var people = new Person[]
                {
                    new Person{FirstName="Gustav Adolf",LastName="Bernadotte",BirthYear=1906,BirthCityId=1,BirthCountryId=1,DeathYear=1947,DeathCityId=2,DeathCountryId=2},//1
                    new Person{FirstName="Sibylla",LastName="Bernadotte",BirthYear=1908,BirthCityId=3,BirthCountryId=3,DeathYear=1972,DeathCityId=1,DeathCountryId=1},//2
                    new Person{FirstName="Walther",LastName="Sommerlath",BirthYear=1901,BirthCityId=4,BirthCountryId=3,DeathYear=1990,DeathCityId=4,DeathCountryId=3},//3
                    new Person{FirstName="Alice",LastName="Sommerlath",BirthYear=1906,BirthCityId=5,BirthCountryId=4,DeathYear=1997,DeathCityId=6,DeathCountryId=1},//4
                    new Person{FirstName="Margaretha",LastName="Bernadotte",BirthYear=1934,BirthCityId=7,BirthCountryId=1,FatherId=1,MotherId=2},//5
                    new Person{FirstName="Birgitta",LastName="Bernadotte",BirthYear=1937,BirthCityId=7,BirthCountryId=1,FatherId=1,MotherId=2},//6
                    new Person{FirstName="Désirée",LastName="Silfverschiöld",BirthYear=1938,BirthCityId=7,BirthCountryId=1,FatherId=1,MotherId=2},//7
                    new Person{FirstName="Christina",LastName="Magnusson",BirthYear=1943,BirthCityId=7,BirthCountryId=1,FatherId=1,MotherId=2},//8
                    new Person{FirstName="Carl XVI Gustav",LastName="Bernadotte",BirthYear=1946,BirthCityId=7,BirthCountryId=1,FatherId=1,MotherId=2},//9
                    new Person{FirstName="Ralf",LastName="Sommerlath",BirthYear=1929,BirthCityId=8,BirthCountryId=4,FatherId=3,MotherId=4},//10
                    new Person{FirstName="Walther",LastName="Sommerlath",BirthYear=1934,BirthCityId=8,BirthCountryId=4,DeathYear=2020,DeathCityId=9,DeathCountryId=1,FatherId=3,MotherId=4},//11
                    new Person{FirstName="Jörg",LastName="Sommerlath",BirthYear=1941,BirthCityId=4,BirthCountryId=3,DeathYear=2006,DeathCityId=10,DeathCountryId=3,FatherId=3,MotherId=4},//12
                    new Person{FirstName="Silvia",LastName="Bernadotte",BirthYear=1943,BirthCityId=4,BirthCountryId=3,FatherId=3,MotherId=4},//13
                    new Person{FirstName="Victoria",LastName="Bernadotte",BirthYear=1977,BirthCityId=7,BirthCountryId=1,FatherId=9,MotherId=13},//14
                    new Person{FirstName="Carl Philip",LastName="Bernadotte",BirthYear=1979,BirthCityId=1,BirthCountryId=1,FatherId=9,MotherId=13},//15
                    new Person{FirstName="Madeleine",LastName="Bernadotte",BirthYear=1982,BirthCityId=6,BirthCountryId=1,FatherId=9,MotherId=13},//16
                    new Person{FirstName="Daniel",LastName="Bernadotte",BirthYear=1973,BirthCityId=11,BirthCountryId=1},//17
                    new Person{FirstName="Sofia",LastName="Bernadotte",BirthYear=1984,BirthCityId=12,BirthCountryId=1},//18
                    new Person{FirstName="Christopher",LastName="O'Neill",BirthYear=1974,BirthCityId=13,BirthCountryId=5},//19
                    new Person{FirstName="Estelle",LastName="Bernadotte",BirthYear=2012,BirthCityId=7,BirthCountryId=1,FatherId=17,MotherId=14},//20
                    new Person{FirstName="Oscar",LastName="Bernadotte",BirthYear=2016,BirthCityId=7,BirthCountryId=1,FatherId=17,MotherId=14},//21
                    new Person{FirstName="Alexander",LastName="Bernadotte",BirthYear=2016,BirthCityId=14,BirthCountryId=1,FatherId=15,MotherId=18},//22
                    new Person{FirstName="Gabriel",LastName="Bernadotte",BirthYear=2017,BirthCityId=14,BirthCountryId=1,FatherId=15,MotherId=18},//23
                    new Person{FirstName="Julian",LastName="Bernadotte",BirthYear=2021,BirthCityId=14,BirthCountryId=1,FatherId=15,MotherId=18},//24
                    new Person{FirstName="Leonore",LastName="Bernadotte",BirthYear=2014,BirthCityId=15,BirthCountryId=6,FatherId=19,MotherId=16},//25
                    new Person{FirstName="Nicolas",LastName="Bernadotte",BirthYear=2015,BirthCityId=14,BirthCountryId=1,FatherId=19,MotherId=16},//26
                    new Person{FirstName="Adrienne",LastName="Bernadotte",BirthYear=2018,BirthCityId=14,BirthCountryId=1,FatherId=19,MotherId=16}//27
                };
                foreach (Person p in people)
                {
                    db.Entry(p).State = EntityState.Added;
                    db.People?.Add(p);
                }
                var result = db.SaveChanges();
                if (result > 0) MessageBox.Show("Done populating database.", "Database");
            }
        }
    }
}
