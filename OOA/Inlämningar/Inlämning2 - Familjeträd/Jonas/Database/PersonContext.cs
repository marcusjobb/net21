using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Family.Models;

namespace Family.Database
{
    public class PersonContext : DbContext
    {
        public const string DatabaseName = "Persons";


        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;" + "MultipleActiveResultSets=True");
        }

    }
}