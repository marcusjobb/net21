using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FamilyTreeApp._Model;

namespace FamilyTreeApp._TestDbContext
{
    class TestDbContext : DbContext
    {
        public DbSet<person> Persons { get; set; }
        public DbSet<spouse> Spouses { get; set; }
        public DbSet<father> Fathers { get; set; }
        public DbSet<mother> Mothers { get; set; }
        public DbSet<children> Children { get; set; }
        public DbSet<sibling> Siblings { get; set; }
        public DbSet<grandFather> GrandFathers { get; set;}
        public DbSet<grandMother> GrandMothers { get; set; }
        public DbSet<aunt> Aunts { get; set; }
        public DbSet<uncle> Uncles { get; set; }
        public DbSet<cousin> Cousins { get; set; } 

        public DbSet<address> Addresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

           options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=AlaaGeneology;Trusted_Connection=True");


    }
}
