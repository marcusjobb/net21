using Genealogy_Tree.Controllers;
using Genealogy_Tree.Database;
using Genealogy_Tree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogy_Tree
{
    class CRUD_klassen
    {




        public void AddPerson(int personid, string firstname, string lastname, int birthdate, int deathdate)
        {}


        public void Update(int PersonID)
        { }

        public void Delete(int PersonID)
        { }



        public void Read(int PersonID)
        {
            using (var db = new ADGenealogy())
            {
                
                var person = db.MonarchyMembers.Find(new MonarchyMember() { PersonID = PersonID }); 
                
                if (person != null)
                {
                    Console.WriteLine("First_Name: {0}", person.FirstName);
                    Console.WriteLine("Last_Name: {0}", person.LastName);
                    Console.WriteLine("Birth_Date: {0}", person.BirthDate);
                    Console.WriteLine("Death_Date: {0}", person.DeathDate);
                    
                }
            }


        }

       public void Read(string firstName, string lastName)
        {

            Monarchy person = null;
            using (var db = new ADGenealogy())
            {

                if (person != null)
                {
                    Console.WriteLine("Search first name and last name");
                    Console.Write("First Name and last name:  ");
                    var input5 = Console.ReadLine();
                  
                }
            }
        }
                

     

       

       

        
       

       





      



    }
}
