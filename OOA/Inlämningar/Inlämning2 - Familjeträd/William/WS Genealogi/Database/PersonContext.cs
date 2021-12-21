using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Genealogi.Models;

namespace WS_Genealogi.Database
{
    internal class PersonContext : DbContext
    {
        private const string DatabaseName = "WSGenealogi";
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
        }
    }
}
