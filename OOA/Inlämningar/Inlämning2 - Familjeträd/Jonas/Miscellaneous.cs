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
    public static class Miscellaneous
    {
        public static List<(string, int)> MainMenuOptions = new List<(string, int)>
            {
            ("1. Välj första person från alla personer  ", -1 ),
            ("2. Välj första person från alla personer med förnamnsbegynnelsebokstav...  ",-2),
            ("3. Välj första person från alla personer födda kring födelseår...   ",-3),
            ("4. Välj första person från vald persons syskon ",-4),
            ("5. Välj första person från vald persons föräldrar  ",-5),
            ("6. Välj första person från vald persons  föräldrarföräldrar  ", -6),
            ("7. Välj första person från vald persons  barn  ", -7),
            ("8. Välj andra person från alla personer  ", -8 ),
            ("9. Välj andra  person från alla personer med förnamnsbegynnelsebokstav...  ",-9),
            ("10. Välj andra  person från alla personer födda kring födelseår...   ",-10),
            ("11. Gör andra  person till första persons förälder...   ",-11),

            ("12. Visa vald person   ", -12),
            ("13. Redigera vald person   ", -13),
            ("14. Ta bort vald person   ", -14),
            ("15. Lägg till och välj person   ", -15),


            };


        public static List<(string, int)> BuildMenu( string option, PersonContext db, string parameter = null, int? numericParameter=null, Person chosen = null, bool second=false)

        {

            List<(string, int)> displayPersons = new List<(string, int)>();





            {

                if (option == "all")
                {
                    foreach (var person in db.Persons)
                    {


                        (string, int) addMe = ((person.Name + " " + person.House), person.ID);
                        displayPersons.Add(addMe);
                    }
                }
                else if (option == "letter" && parameter != null)
                {
                    var letter = db.Persons.Where(a => a.Name.StartsWith(parameter));

                    foreach (var person in letter)
                    {


                        (string, int) addMe = ((person.Name + " " + person.House), person.ID);
                        displayPersons.Add(addMe);
                    }
                    if (!letter.Any())
                    {
                        (string, int) fallback = ("inget resultat", -99);
                        displayPersons.Add(fallback);
                    }
                }
                else if (option == "year" && numericParameter != null)
                {
                    int addedYears = 0;
                    int count = 0;
                    var year = db.Persons.Where(a => a.DateOfBirth.Value.Year == (int)numericParameter);
 
                    while(!year.Any() )                 // Hittar personer födda närmaste året för vilket resultat finns.
                    {

                        if (count % 2 == 0)
                        {
                            year = db.Persons.Where(a => a.DateOfBirth.Value.Year == ( (int)numericParameter + addedYears));
                            //Console.WriteLine(year.Count + " " + (int)numericParameter + addedYears);
                        }
                        else
                        {
                            year = db.Persons.Where(a => a.DateOfBirth.Value.Year == ( (int)numericParameter - addedYears));
                        }
                        count++;
                        addedYears++;
                    }

                    

                    foreach (var person in year)
                    {


                        (string, int) addMe = ((person.Name + " " + person.House), person.ID);
                        displayPersons.Add(addMe);
                    }

                }

                else if (option == "sibling" )
                {

                    var siblings = db.Persons.Where(a => a.Father == chosen.Father).Where(a => a.Mother == chosen.Mother);
                    foreach (var person in siblings)
                    {


                        (string, int) addMe = ((person.Name + " " + person.House), person.ID);
                        displayPersons.Add(addMe);
                    }
                    if (!siblings.Any())
                    {
                        (string, int) fallback = ("inget resultat", -99);
                        displayPersons.Add(fallback);
                    }
                }

                else if (option == "parent")
                {

                    var parents = db.Persons.Where(a => a.ID == chosen.Father || a.ID == chosen.Mother);
                    foreach (var person in parents)
                    {


                        (string, int) addMe = ((person.Name + " " + person.House), person.ID);
                        displayPersons.Add(addMe);
                    }
                    if (!parents.Any())
                    {
                        (string, int) fallback = ("inget resultat", -99);
                        displayPersons.Add(fallback);
                    }
                }
                else if (option == "children")
                {

                    var children = db.Persons.Where(a => a.Father == chosen.ID || a.Mother == chosen.ID);
                    foreach (var person in children)
                    {


                        (string, int) addMe = ((person.Name + " " + person.House), person.ID);
                        displayPersons.Add(addMe);
                    }
                    if (!children.Any())
                    {
                        (string, int) fallback = ("inget resultat", -99);
                        displayPersons.Add(fallback);
                    }
                }
                else if (option == "parentparent")
                {
                    var parentParents = db.Persons.Where(a => a.ID == 0);                                       //desperat försök
                   var parents = db.Persons.Where(a => a.ID ==  chosen.Father || a.ID == chosen.Mother) ;
                    foreach (var person in parents)
                    {

                          parentParents = db.Persons.Where(a => a.ID == person.Father || a.ID == person.Mother);

                        foreach (var personPerson in parentParents)
                        {
                            (string, int) addMe = ((personPerson.Name + " " + personPerson.House), personPerson.ID);
                            displayPersons.Add(addMe);
                        }
 

                    }
                    if (!parentParents.Any())
                    {
                        (string, int) fallback = ("inget resultat", -99);
                        displayPersons.Add(fallback);
                    }
                }

                return displayPersons;
            }
        }

        public static void CallAddPerson(PersonContext db)
        {
            // Name  
            // House  
            // Male  
            // Title  
            // RegnalNumber  
            // RoyalEpithet  
            // DateOfBirth  
            // DateOfDeath { get; set; }

            //  BirthPlace { get; set; }        //koppla till sep. tabell sen
            // DeathPlace { get; set; }

            Person ThrowAway = new Person();

            foreach (PropertyInfo item in ThrowAway.GetType().GetProperties())
            {
                string input;
                if (item.PropertyType == typeof(int)|| item.PropertyType == typeof(int?))
                {
                    // gör ingenting
                }
                else if (item.PropertyType == typeof(string))
                {
                    //Skriv ut property name mata in värde
                    Console.WriteLine(item.Name + ": ");
                    input = Console.ReadLine();
                    if ((String.IsNullOrEmpty(input)))
                    {
                        //Gör ingenting
                    }
                    else
                    {
                        Type myType = ThrowAway.GetType();
                        PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                        mysteriousThing.SetValue(ThrowAway, input);
                    }
                }
                else if (item.PropertyType == typeof(DateTime?))
                {
                    //DateTime
                    bool quit = false;
                    DateTime inputDateTime = new DateTime();
                    do
                    {
                        Console.WriteLine(item.Name + ": ");
                        quit = DateTime.TryParse(Console.ReadLine(), out inputDateTime);
                    } while (!quit);
                    DateTime? inputDateTimeNullable = (DateTime?)inputDateTime;
                    Type myType = ThrowAway.GetType();
                    PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                    mysteriousThing.SetValue(ThrowAway, inputDateTimeNullable);
                }

                else if (item.PropertyType == typeof(bool))
                {
                    bool quit = false;
                     
                    do
                    {
                        Console.WriteLine(item.Name + ": true eller false?");
                        input = Console.ReadLine();
                        quit = (input == "true" || input == "false");
                    } while (!quit);
                    bool truth = System.Convert.ToBoolean(input);
                    Type myType = ThrowAway.GetType();
                    PropertyInfo mysteriousThing = myType.GetProperty(item.Name);
                    mysteriousThing.SetValue(ThrowAway, truth);
                }
            }

            Modify.AddPerson(db, ThrowAway);
        }

        public static void Display(PersonContext db, Person displayMe)
        {
            foreach (PropertyInfo item in displayMe.GetType().GetProperties())
            {
                if (item.PropertyType == typeof(int) || item.PropertyType == typeof(int?))
                {
                    if (item.Name != "ID" && item.Name!="BirthPlace" && item.Name != "DeathPlace")
                    {
                        int parentId = (int)item.GetValue(displayMe);
 
                         var person =  db.Persons.FirstOrDefault(f => f.ID == parentId);
                        Console.Write(item.Name + ": "+ person.Name + " "+ person.House);
                    }
                }
                else if (item.PropertyType == typeof(string))
                {
                    Console.WriteLine(item.Name + ": " + item.GetValue(displayMe));
                }
                else if (item.PropertyType == typeof(DateTime?))
                {
                    string value = item.GetValue(displayMe) == null ? "null" : item.GetValue(displayMe).ToString();
                    Console.WriteLine(item.Name + ": " + value);
                }
                else if (item.PropertyType == typeof(bool))
                {
                    string value = item.GetValue(displayMe) == null ? "null" : item.GetValue(displayMe).ToString();
                    Console.WriteLine(item.Name + ": " + value);
                }



            }
            Console.ReadKey();
        }
     }
}
