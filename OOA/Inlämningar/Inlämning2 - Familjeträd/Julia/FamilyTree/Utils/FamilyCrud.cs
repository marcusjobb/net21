using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyTree.Models;
using FamilyTree.Database;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Utils
{
    public class FamilyCrud
    {
        //-----------------(1a) Lägg till person i databasen
        public static Person FindOrCreatePerson(string fname, string lname, string bdate)
        {
            using (var db = new FamilyContext()) // Metoden kmr att söka efter personens för- eller
                                                 // efternamn, personen skapas om den inte finns
            {
                var person = db.People.
                            FirstOrDefault(
                                h => h.FirstName == fname && // Sök på namnet
                                h.LastName == lname
                                );
                if (person == null) // om personen inte finns, skapa den
                {
                    person = new Person { FirstName = fname, LastName = lname, BirthDate = bdate };
                    Console.WriteLine("\nWoho, you just created {0} {1}", fname, lname);
                    db.People.Add(person);
                    db.SaveChanges(); // objektet uppdateras med ID efter save
                }
                else Console.WriteLine("This person already exist!");
                return person;
            }
        }

        //-----------------(1b) Lägg till födelseplats i databasen
        public static BirthPlace CreateBP(string _name, string _country)
        {
            using (var db = new FamilyContext())
            {
                var bp = db.BirthPlaces.
                            FirstOrDefault(
                                h => h.Name == _name &&
                                h.Country == _country
                                );
                if (bp == null)
                {
                    bp = new BirthPlace { Name = _name, Country = _country };
                    Console.WriteLine("\nWoho, you just created {0} {1}", _name, _country);

                    db.BirthPlaces.Add(bp);
                    db.SaveChanges();
                }
                else Console.WriteLine("This place already exist!");
                return bp;
            }
        }

        //-----------------(1c) Lägg till dödsplats i databasen
        public static DeathPlace CreateDP(string _name, string _country)
        {
            using (var db = new FamilyContext())
            {
                var dp = db.DeathPlaces.
                            FirstOrDefault(
                                h => h.Name == _name &&
                                h.Country == _country
                                );
                if (dp == null)
                {
                    dp = new DeathPlace { Name = _name, Country = _country };
                    Console.WriteLine("\nWoho, you just created {0} {1}", _name, _country);

                    db.DeathPlaces.Add(dp);
                    db.SaveChanges();
                }
                else Console.WriteLine("This place already exist!");
                return dp;
            }
        }

        //-----------------(2) Hitta en mor till en person
        public static Person FindMother(string fname, string lname)
        {
            using (var db = new FamilyContext())
            {
                //Sök person, hämta ID
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                if (person != null)
                {
                    var currentMother = person.MotherId;
                    var currentMotherName = db.People.FirstOrDefault(mom => mom.ID == currentMother);
                    Console.WriteLine($"\n{person}s current mother is {currentMotherName}");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");
                return person;
            }
        }

        //-----------------(2b)Koppla en mor till en person
        public static Person SetMother(string fname, string lname, string mfname, string mlname)
        {
            using (var db = new FamilyContext())
            {
                //Sök person, hämta ID
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                if (person != null)
                {
                    //Sök persons mamma, hämta mamma ID
                    var mom = db.People.FirstOrDefault(m => m.FirstName == mfname && m.LastName == mlname);

                    if (mom != null) //Om mor finns, uppdatera ID kopplingen
                    {
                        var currentMother = person.MotherId;
                        Console.WriteLine($"\nYou just changed {person}'s mother to {mom}!");
                        person.MotherId = mom.ID;
                        db.SaveChanges();
                    }
                    else Console.WriteLine($"You have to enter a person that exist in the family tree to become {fname} {lname}'s mom!");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");
                return person;
            }
        }

        //-----------------(3a) Hitta en far till en person
        public static Person FindFather(string fname, string lname)
        {
            using (var db = new FamilyContext())
            {
                //Sök person, hämta ID
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                if (person != null)
                {
                    var currentFather = person.FatherId;
                    var currentFatherName = db.People.FirstOrDefault(dad => dad.ID == currentFather);
                    Console.WriteLine($"\n{person}s current father is {currentFatherName}");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");
                return person;
            }
        }

        //-----------------(3b)Koppla en far till en person
        public static Person SetFather(string fname, string lname, string dfname, string dlname)
        {
            using (var db = new FamilyContext())
            {
                //Sök person, hämta ID
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                if (person != null)
                {
                    //Sök persons pappa, hämta pappa ID
                    var dad = db.People.FirstOrDefault(m => m.FirstName == dfname && m.LastName == dlname);

                    if (dad != null) //Om far finns, uppdatera ID kopplingen
                    {
                        var currentFather = person.FatherId;
                        Console.WriteLine($"\nYou just changed {person}'s father to {dad}!");
                        person.FatherId = dad.ID;
                        db.SaveChanges();
                    }
                    else Console.WriteLine($"You have to enter a person that exist in the family tree to become {fname} {lname}'s dad!");
                }
                else Console.WriteLine("The person you searched for doesn't exist!");
                return person;
            }
        }

        //-----------------(4a)Uppdatera en persons för- och efternamn
        public static Person UpdatePerson(string pfname, string plname, string fname, string lname)
        {
            using (var db = new FamilyContext())
            {
                //Hämta entity via id
                var update = db.People.FirstOrDefault(n => n.FirstName == pfname && n.LastName == plname);

                //Validate entity is not null
                if (update != null)
                {
                    //Make changes on entity
                    update.FirstName = fname;
                    update.LastName = lname;

                    //Call SaveChanges
                    db.SaveChanges();
                }
                else Console.WriteLine("This person doesn't exist!");
                return update;
            }
        }

        //-----------------(4b)Uppdatera en persons födelseår
        public static Person UpdateYear(string pfname, string plname, string pyear)
        {
            using (var db = new FamilyContext())
            {
                var update = db.People.FirstOrDefault(n => n.FirstName == pfname && n.LastName == plname);

                if (update != null)
                {
                    update.BirthDate = pyear;
                    db.SaveChanges();
                }
                else Console.WriteLine("This person doesn't exist!");
                return update;
            }
        }

        //-----------------(4c)Uppdatera en persons dödsår
        public static Person UpdateDeath(string pfname, string plname, string dyear)
        {
            using (var db = new FamilyContext())
            {
                var update = db.People.FirstOrDefault(n => n.FirstName == pfname && n.LastName == plname);

                if (update != null)
                {
                    update.DeathDate = dyear;
                    db.SaveChanges();
                }
                else Console.WriteLine("This person doesn't exist!");
                return update;
            }
        }

        //-----------------(4d)Uppdatera en persons födelseplats
        public static BirthPlace UpdateBP(string fname, string lname, string _name, string _countryname)
        {
            using (var db = new FamilyContext())
            {
                var update = db.BirthPlaces.FirstOrDefault(n => n.Name == _name && n.Country == _countryname);

                if (update != null)
                {
                    var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                    update.People = new List<Person> { person };
                    db.SaveChanges();
                }
                else Console.WriteLine("This place doesn't exist! You have to create one first...");
                return update;
            }
        }

        //-----------------(4e)Uppdatera en persons dödsplats
        public static DeathPlace UpdateDP(string fname, string lname, string _name, string _countryname)
        {
            using (var db = new FamilyContext())
            {
                var update = db.DeathPlaces.FirstOrDefault(n => n.Name == _name && n.Country == _countryname);

                if (update != null)
                {
                    var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                    update.People = new List<Person> { person };
                    db.SaveChanges();
                }
                else Console.WriteLine("This place doesn't exist! You have to create one first...");
                return update;
            }
        }

        //-----------------(5a)Ta bort en person via id
        public static Person RemovePerson(int id)
        {
            using (var db = new FamilyContext())
            {
                //Hämta entity via namn
                var remove = db.People.FirstOrDefault(n => n.ID == id);

                //Validate entity is not null
                if (remove != null)
                {
                    //Make changes on entity
                    db.People.Remove(remove);

                    //Call SaveChanges
                    db.SaveChanges();
                }
                return remove;
            }
        }

        //-----------------(5b)Ta bort en person via för- och efternamn
        public static Person RemovePerson(string fname, string lname)
        {
            using (var db = new FamilyContext())
            {
                //Hämta entity via namn
                var remove = db.People.FirstOrDefault(n => n.FirstName == fname && n.LastName == lname);

                //Validate entity is not null
                if (remove != null)
                {
                    //Make changes on entity
                    db.People.Remove(remove);

                    //Call SaveChanges
                    db.SaveChanges();
                }
                else Console.WriteLine("This person doesn't exist!");
                return remove;
            }
        }

        //-----------------(6a)Visa alla efter ID
        public static void ShowEverybody()
        {
            using var db = new FamilyContext();
            Console.WriteLine("======List of everybody in the database ordered by lastname======\n");

            var BP = db.BirthPlaces.Include("People");
            if (BP != null)
            {
                foreach (var bp in BP)
                {
                    foreach (var p in bp.People)
                    {
                        Console.WriteLine("ID: " + p.ID + " - " + p.FirstName + " " + p.LastName + " was born year " + p.BirthDate + " in " + bp.Name + ".");
                    }
                }
            }
        }

        //-----------------(6b)Visa alla efter efternamn
        public static void ShowEverybodyOrder()
        {
            using var db = new FamilyContext();
            Console.WriteLine("======List of everybody in the database ordered by lastname======\n");

            int index = 1;
            foreach (var p in db.People.OrderBy(n => n.LastName).ThenBy(n => n.FirstName))
            {
                Console.WriteLine(index + ". " + p.FirstName + " " + p.LastName);
                index++;
            }
        }

        //-----------------(6c)Visa alla enligt land
        public static void ShowBP()
        {
            using var db = new FamilyContext();
            Console.WriteLine("======List of everybody in the database ordered by birth place======\n");

            int index = 1;
            var BP = db.BirthPlaces.Include("People");
            if (BP != null)
            {
                foreach (var p in BP.OrderBy(n => n.Name))
                {
                    foreach (var d in p.People)
                    {
                        Console.WriteLine(index + ". " + d.FirstName + " " + d.LastName + " was born in " + p.Name);
                        index++;
                    }
                }
            }
         }

        //-----------------(7a)Hitta person(er) med viss bokstav i sitt efternamn
        public static void FindLastName(string inputL)
        {
            using var db = new FamilyContext();
            var person = db.People.Where(n => n.LastName.Contains(inputL)).ToList();
            if (person != null)
            {
                foreach (var p in person.OrderBy(x => x.LastName).ThenBy(x => x.FirstName))
                    Console.WriteLine(p.FirstName + " " + p.LastName);
            }
            else Console.WriteLine("No name found.");
        }

        //-----------------(7b)Hitta person(er) födda visst årtal
        public static void FindYear(string inputY)
        {
            using var db = new FamilyContext();
            var person = db.People.Where(n => n.BirthDate == inputY).ToList();
            if (person.Count > 0)
            {
                int index = 1;
                Console.WriteLine($"\nThe following people are born {inputY}");
                foreach (var p in person.OrderBy(x => x.LastName).ThenBy(x => x.FirstName))
                {
                    Console.WriteLine(index + ". " + p.FirstName + " " + p.LastName);
                    index++;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No one is born that year.");
            }
        }

        //-----------------(8)Visa mor-/farföräldrar till en person
        public Person CheckGrandParents(string fname, string lname)
        {
            using (var db = new FamilyContext())
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);

                if (person != null)
                {
                    List<Person> parentsList = GetParents(person);

                    if (parentsList.Count > 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"{fname} {lname}'s grandparents are:\n ");
                        foreach (Person p in parentsList)
                        {
                            List<Person> grandParentsList = GetParents(p);
                            if (grandParentsList.Count > 0)
                            {
                                foreach (Person gp in grandParentsList)
                                {
                                    Console.WriteLine(" - " + gp.FirstName + " " + gp.LastName + " - ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Parent: " + p.FirstName + " " + p.LastName + " has no known parents");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(person.FirstName + " " + person.LastName + " has no known parents");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Person does not exist.");
                }
                return person;
            }
        }

        //-----------------Helper för ShowGrandParents()
        private static List<Person> GetParents(Person p)
        {
            List<Person> parentsList = new List<Person>();

            using (var db = new FamilyContext())
            {
                parentsList = db.People.Where(n => n.ID == p.FatherId || n.ID == p.MotherId).ToList();
            }
            return parentsList;
        }

        //-----------------(9)Visa syskonen till en person
        public static Person CheckSiblings(string fname, string lname)
        {
            using var db = new FamilyContext();
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                if (person != null)
                {
                    List<Person> parentsList = GetParents(person);

                    if (parentsList.Count > 0)
                    {
                        var sameMom = person.MotherId;
                        var sameDad = person.FatherId;
                        var siblings = db.People.Where(p => p.MotherId == sameMom || p.FatherId == sameDad);
                        Console.Clear();
                        Console.WriteLine("=====The following people are siblings and/or half-siblings=====\n");

                        foreach (var sibling in siblings.OrderBy(s => s.LastName).ThenBy(s => s.FirstName))
                        {
                            Console.WriteLine("- " + sibling);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"No siblings were found for {fname} {lname}... :(");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This person doesn't exist!");
                }
                return person;
            }
        }

        //-----------------(9)Visa barn till en person
        public static Person CheckChildren(string fname, string lname)
        {
            using var db = new FamilyContext();
            {
                var person = db.People.FirstOrDefault(p => p.FirstName == fname && p.LastName == lname);
                if (person != null)
                {
                    var children = db.People.Where(p => p.MotherId == person.ID || p.FatherId == person.ID);
                    Console.Clear();
                    Console.WriteLine($"=====The following people are children to {fname} {lname}=====\n");

                    foreach (var child in children.OrderBy(s => s.LastName).ThenBy(s => s.FirstName))
                    {
                        Console.WriteLine("- " + child);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"No children were found for {fname} {lname}... :(");
                }
                return person;
            }
        }
    }
}
