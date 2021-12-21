using System;
using Genealogy_Tree.Controllers;
using Genealogy_Tree.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genealogy_Tree.Database;

namespace Genealogy_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var monarchyMembers = new MonarchyMembers();
            


            using (var dbContext = new ADGenealogy())
            {
                monarchyMembers.Add_Monarchy_Members(dbContext);
               

                var member = dbContext.MonarchyMembers.FirstOrDefault(x => x.FirstName =="Alexander II");

                PrintParents(member.Parents);

                Console.WriteLine($"{member.FirstName} {member.LastName}");
               

                PrintChildren(member.Children);


                foreach (var m in dbContext.MonarchyMembers.ToList()) 
                {
                    
                    Console.WriteLine($"{m.PersonID} {m.FirstName} {m.LastName}");
                    Console.WriteLine($"{m.BirthDate} {m.DeathDate}");
                    PrintParents(m.Parents);
                    PrintChildren(m.Children);
                    
                }


            }

        }

        public static void PrintParents(IEnumerable<MonarchyMember> parents)
        {
           
           foreach (var parent in parents)
           {
                Console.WriteLine($" P {parent.FirstName} {parent.LastName}");
                
               

            }
        }

        public static void PrintChildren(IEnumerable<MonarchyMember> children)
       {
           
         foreach (var child in children)
           {
               Console.WriteLine($"C {child.FirstName} {child.LastName}");
                
             
            }
       }
        public static void PrintTheList(List<MonarchyMember> list )
        { }










    }

}
