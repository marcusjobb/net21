using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Family.Models;
using Family.Database;

namespace Family
{
    public static class Modify
    {
        public static void AddPerson (PersonContext db, string name, string house, DateTime dateOfBirth, DateTime dateOfDeath, bool male, string title = null, string regnalNumber = null, string royalEpithet = null , int? placeOfBirth=null, int? placeOfDeath=null)
        {
            var doppelganger = db.Persons.FirstOrDefault(f => f.Name == name && f.House == house && f.DateOfBirth == dateOfBirth && f.DateOfDeath == dateOfDeath);
 
            if (doppelganger == null)
            {
 
                db.Persons.Add(new Models.Person
                {
                    Name = name,
                    House = house,
                    Male = male,
                    Title = title,
                    RegnalNumber = regnalNumber,
                    RoyalEpithet = royalEpithet,
                    BirthPlace = placeOfBirth,
                    DeathPlace = placeOfDeath,
                    DateOfBirth = dateOfBirth,
                    DateOfDeath = dateOfDeath
                });
            }

            db.SaveChanges();
        }

        public static void AddPerson(PersonContext db, Person person)
        {
            var doppelganger = db.Persons.FirstOrDefault(f => f.Name == person.Name && f.House == person.House && f.DateOfBirth == person.DateOfBirth && f.DateOfDeath == person.DateOfDeath);
            if (doppelganger == null)
            {
                db.Persons.Add(person);
            }

            db.SaveChanges();
        }

        public static void AddParent(PersonContext db, Person child, Person parent)
        {

            if (child != null && parent != null)
            {
                if (parent.Male)
                {
                    child.Father = parent.ID;
                }
                else
                {
                    child.Mother = parent.ID;
                }
            }
            db.SaveChanges();
        }
        //static void Update(PersonContext db, Person upDateMe, string name=null, string house = null, bool? male = null, DateTime? dateOfBirth= null, DateTime? dateOfDeath=null, string title = null, string regnalNum = null, string royalEpithet = null, int? birthPlace=null, int? deathPlace=null)
        //{
            
        //    upDateMe.Name = name == null ? upDateMe.Name : name;
        //    upDateMe.House = house == null ? upDateMe.House : house;
        //    upDateMe.Male = male == null ? upDateMe.Male : (bool)male;
        //    upDateMe.DateOfBirth = dateOfBirth == null ? upDateMe.DateOfBirth : dateOfBirth;
        //    upDateMe.DateOfDeath = dateOfDeath == null ? upDateMe.DateOfDeath : dateOfDeath;
        //    upDateMe.Title = title == null ? upDateMe.Title : title;
        //    upDateMe.Title = title == null ? upDateMe.Title : title;
        //    upDateMe.RegnalNumber = regnalNum == null ? upDateMe.RegnalNumber : regnalNum;
        //    upDateMe.RoyalEpithet = royalEpithet == null ? upDateMe.RoyalEpithet : royalEpithet;
        //    upDateMe.BirthPlace = birthPlace == null ? upDateMe.BirthPlace : birthPlace;

        //    db.SaveChanges();


        //}

        public static void Update(PersonContext db, Person upDateMe)
        {
            foreach (PropertyInfo item in upDateMe.GetType().GetProperties())
            {
                string input;
                if (item.PropertyType == typeof(int) || item.PropertyType == typeof(int?))
                {
                    // gör ingenting
                }
                else if (item.PropertyType == typeof(string))
                {
                    //Skriv ut property name mata in värde
                    Console.WriteLine(item.Name + ": "+ item.GetValue(upDateMe)+ " <RETURN> lämna oförändrad");
                    input = Console.ReadLine();
                    if ((String.IsNullOrEmpty(input)))
                    {
                        //Gör ingenting
                    }
                    else
                    {
                        Type myType = upDateMe.GetType();
                        PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                        mysteriousThing.SetValue(upDateMe, input);
                    }
                }
                else if (item.PropertyType == typeof(DateTime?))
                {
                    //DateTime
                    bool quit = false;
                    DateTime inputDateTime = new DateTime();
                    do
                    {
                        string value = item.GetValue(upDateMe) == null ? "null" : item.GetValue(upDateMe).ToString();
                        Console.WriteLine(item.Name + ": " + value + " <RETURN> lämna oförändrad");
                        input = Console.ReadLine();
                        quit =( DateTime.TryParse(input, out inputDateTime) || String.IsNullOrEmpty(input)   );
                        
                    } while (!quit);
                    if (!String.IsNullOrEmpty(input))
                    {
                        DateTime? inputDateTimeNullable = (DateTime?)inputDateTime;
                        Type myType = upDateMe.GetType();
                        PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                        mysteriousThing.SetValue(upDateMe, inputDateTimeNullable);
                    }
                }

                else if (item.PropertyType == typeof(bool))
                {
                    bool quit = false;

                    do
                    {
                        string value = item.GetValue(upDateMe) == null ? "null" : item.GetValue(upDateMe).ToString();
                        Console.WriteLine(item.Name + ": " + value + "  <RETURN> lämna oförändrad");
                        input = Console.ReadLine();
                        quit = (input == "true" || input == "false" || String.IsNullOrEmpty(input));
                    } while (!quit);
                    if (!String.IsNullOrEmpty(input))
                    {
                        bool truth = System.Convert.ToBoolean(input);
                        Type myType = upDateMe.GetType();
                        PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                        mysteriousThing.SetValue(upDateMe, truth);
                    }
                }


            }
            db.SaveChanges();

        }

        public static void Delete(PersonContext db, Person deleteMe)
        {

            if (deleteMe != null)
                db.Persons.Remove(deleteMe);
            db.SaveChanges();
        }

    }


}
