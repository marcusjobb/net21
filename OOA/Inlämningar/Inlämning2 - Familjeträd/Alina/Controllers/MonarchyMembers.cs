using Genealogy_Tree.Database;
using Genealogy_Tree.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogy_Tree.Controllers
{
    public class MonarchyMembers
    {
        public void Add_Monarchy_Members(ADGenealogy dbContext)
        {
            var monarchies = new List<Monarchy>
            {
                new Monarchy() { Name = "Romanov" }
            };

            if (dbContext.Monarchies.Count() > 0) return;
            dbContext.Monarchies.AddRange(monarchies);

            if(dbContext.MonarchyMembers.Count()==0)
            dbContext.MonarchyMembers.Add(new MonarchyMember()
            {


                Parents = new List<MonarchyMember>() {
                            new() {
                                FirstName = "Alexander II",
                                LastName = "Nikolajevitj",
                            },
                            new()
                            {
                                FirstName = "Maria",
                                LastName = "Alexandrovna",
                            }

                },



                Children = new List<MonarchyMember>() {

                   new MonarchyMember { FirstName = "Alexandra ", LastName = "Nikolajevna"},
                   new MonarchyMember { FirstName = "Nicholas", LastName = "Nikolajevitj" },
                   new MonarchyMember { FirstName = "Vladimir", LastName = "Nikolajevitj" },
                   new MonarchyMember { FirstName = "Maria", LastName = "Nikolajevna" },
                   new MonarchyMember {FirstName = "Alexei", LastName = "Nikolajevitj"   },
                   new MonarchyMember {FirstName = "Paul", LastName = "Nikolajevitj" },
                   new MonarchyMember {FirstName = "Sergei",  LastName = "Nikolajevitj"}
                }

            });

            dbContext.MonarchyMembers.Add(new MonarchyMember()
            {

                Parents = new List<MonarchyMember>() {
                            new(){
                                FirstName = "Alexander III",
                                LastName = "Nikolajevitj",
                            },
                            new()
                            {
                                FirstName = "Maria",
                                LastName = "Feodorovna",



                            }
                },


                Children = new List<MonarchyMember>() {

                         new MonarchyMember { FirstName = "Xenia",  LastName = " Alexandrovna" },
                         new MonarchyMember {FirstName = "Alexander", LastName = "Alexandrovitj" },
                         new MonarchyMember { FirstName = "George", LastName = "Alexandrovitj" },
                         new MonarchyMember { FirstName = "Michael", LastName = "Alexandrovitj" },
                         new MonarchyMember { FirstName = "Olga", LastName = "Alexandrovna" }
                 }

            });

            dbContext.MonarchyMembers.Add(new MonarchyMember()
            {
                Parents = new List<MonarchyMember>() {
                            new(){
                                FirstName = "Nicholas II",
                                LastName = "Alexandrovitj",
                            },
                            new()
                            {
                                FirstName = "Alexandra",
                                LastName = "Feodorovna",



                            }
                },

                Children = new List<MonarchyMember>() {
                  new MonarchyMember{ FirstName = "Olga ", LastName = " Nikolajevna" },
                  new MonarchyMember{ FirstName = "Tatiana ", LastName = "Nikolajevna" },
                  new MonarchyMember{FirstName = "Maria",LastName = "Nikolajevna"},
                  new MonarchyMember{FirstName = "Anastasia", LastName = "Nikolajevna" },
                  new MonarchyMember{FirstName = "Alexei",LastName = "Nikolajevitj" }
                }
            });

            dbContext.SaveChanges();

            




            var monarchyMember = new List<MonarchyMember>
            {
              new MonarchyMember   {PersonID = 1, FirstName = "Maria", LastName ="Alexandrovna", BirthDate = 1824 , DeathDate = 1880 },
              new MonarchyMember {PersonID = 2, FirstName = "Alexander II", LastName = "Nikolajevitj", BirthDate = 1818 , DeathDate = 1881},
              new MonarchyMember  {PersonID = 3, FirstName = "Alexandra", LastName = "Nikolajevna", BirthDate = 1842, DeathDate = 1849 },
              new MonarchyMember  {PersonID = 4, FirstName ="Nicholas" , LastName ="Nikolajevitj", BirthDate = 1843, DeathDate = 1865 },
              new MonarchyMember {PersonID = 5, FirstName = "Vladimir", LastName ="Nikolajevitj", BirthDate = 1847, DeathDate = 1909 },
              new MonarchyMember {PersonID = 6, FirstName ="Maria", LastName ="Nikolajevna", BirthDate =1853, DeathDate = 1920 },
              new MonarchyMember {PersonID = 7, FirstName = "Alexei", LastName ="Nikolajevitj", BirthDate = 1850, DeathDate = 1908  },
              new MonarchyMember {PersonID = 8, FirstName = "Paul", LastName ="Nikolajevitj", BirthDate =1860, DeathDate = 1919 },
              new MonarchyMember{PersonID = 10, FirstName ="Sergei"  , LastName ="Nikolajevitj", BirthDate = 1857, DeathDate = 1905  },
              new MonarchyMember {PersonID = 9, FirstName = "Alexander III", LastName ="Nikolajevitj", BirthDate = 1845 , DeathDate = 1894 },
              new MonarchyMember {PersonID = 11, FirstName = "Maria", LastName = "Feodorovna", BirthDate = 1847, DeathDate = 1928 },
              new MonarchyMember {PersonID = 12, FirstName = "Xenia" , LastName ="", BirthDate = 1875, DeathDate = 1960},
              new MonarchyMember {PersonID = 13, FirstName = "Alexander", LastName ="", BirthDate = 1869, DeathDate = 1870 },
              new MonarchyMember {PersonID = 14, FirstName = "George", LastName ="", BirthDate = 1871, DeathDate = 1899 },
              new MonarchyMember {PersonID = 15, FirstName ="Michael" , LastName ="", BirthDate = 1878, DeathDate = 191},
              new MonarchyMember {PersonID = 16, FirstName = "Olga", LastName ="", BirthDate = 1882,DeathDate = 1960 },
              new MonarchyMember {PersonID = 17, FirstName = "Nicholas II" , LastName = "", BirthDate = 1868, DeathDate = 1918},
              new MonarchyMember {PersonID = 18, FirstName = "Alexandra" , LastName ="Feodorovna", BirthDate = 1872, DeathDate = 1918 },
              new MonarchyMember {PersonID = 19, FirstName = "Olga" , LastName ="", BirthDate = 1895, DeathDate = 1918 },
              new MonarchyMember {PersonID = 20, FirstName = "Tatiana" , LastName ="", BirthDate = 1897, DeathDate = 1918 },
              new MonarchyMember {PersonID = 21, FirstName = "Maria" , LastName ="", BirthDate = 1899, DeathDate = 1918 },
              new MonarchyMember {PersonID = 22, FirstName = "Anastasia" , LastName ="", BirthDate = 1901, DeathDate = 1918},
              new MonarchyMember {PersonID = 23, FirstName = "Alexei" , LastName ="", BirthDate = 1904, DeathDate = 1918 }
           };

            
            dbContext.SaveChanges();
        }

    }


}




























































