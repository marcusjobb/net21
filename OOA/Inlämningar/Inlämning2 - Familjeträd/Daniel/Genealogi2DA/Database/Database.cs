using Genealogi2DA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi2DA.Models

{
    public class Database : DbContext
    {
        public DbSet<Person> People { get; set; }
        private const string DatabaseName = "Genealogi2DA";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Genealogi2DA;Trusted_Connection=True;");
        }
    }
}

