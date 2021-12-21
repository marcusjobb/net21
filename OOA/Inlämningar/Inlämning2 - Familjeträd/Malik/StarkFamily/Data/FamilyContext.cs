using Microsoft.EntityFrameworkCore;
using StarkFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarkFamily.Data
{
    public class FamilyContext : DbContext
    {
        public FamilyContext(DbContextOptions<FamilyContext> options) : base(options)
        {
        }

        public DbSet<Person> Personos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Persons");
        }
    }
}
