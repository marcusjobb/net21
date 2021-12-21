using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyTree.Models;

namespace FamilyTree.Database
{
    public class FamilyContext : DbContext
    {
        private const string DatabaseName = "JTGenealogi";
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<BirthPlace> BirthPlaces { get; set; }
        public virtual DbSet<DeathPlace> DeathPlaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
        }
    }
}
