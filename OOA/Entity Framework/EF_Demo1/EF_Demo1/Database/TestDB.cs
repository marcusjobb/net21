// -----------------------------------------------------------------------------------------------
//  TestDB.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace EF_Demo1.Database
{

    using EF_Demo1.Models;

    using Microsoft.EntityFrameworkCore;

    public class TestDB:DbContext
    {
        public DbSet<HiScore> HiScores { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Dbtest1;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
