// -----------------------------------------------------------------------------------------------
//  TestDB.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace EF_minimal.Database
{

    using EF_minimal.Models;

    using Microsoft.EntityFrameworkCore;

    public class MinimalDB : DbContext
    {
        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MinDatabas;Trusted_Connection=True;");
        }
    }
}
