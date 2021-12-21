using Inlämning2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2.Database
{
   public  class FamilyTreeContext: DbContext
    {
        private const string DatabaseName = "AAGenealogi";
        public DbSet<Person> People { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database={DatabaseName};Trusted_Connection=True;");
        }
    }
}
