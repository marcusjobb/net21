using Genealogy_Tree.Controllers;
using Genealogy_Tree.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogy_Tree.Database
{
    public class ADGenealogy : DbContext
    {
        public DbSet<Monarchy> Monarchies { get; set; }
        public DbSet<MonarchyMember> MonarchyMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ALMonarchy;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonarchyMember>()
                     .HasMany(m => m.Children)
                     .WithMany(m => m.Parents);
        }
    }


}



