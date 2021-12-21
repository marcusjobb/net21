using EF_Genealogy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Data
{
    public class GenealogyContext : DbContext
    {
        private const string DatabaseName = "JEGenealogi";

        public DbSet<Person> People { get; set; }

        //public DbSet<Spouse> Spouses { get; set; }

        public DbSet<HistoricalEvent> LifeEvents { get; set; }

        public DbSet<Place> Locations { get; set; }


        // Adds connectionstring by override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};trusted_connection=true");
        }
    }
}
