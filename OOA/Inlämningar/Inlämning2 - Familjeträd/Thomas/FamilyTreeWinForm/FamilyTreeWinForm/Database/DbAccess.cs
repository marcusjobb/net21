// -----------------------------------------------------------------------------------------------
//  DbAccess.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Database
{
    using Microsoft.EntityFrameworkCore;
    using FamilyTreeWF.Models;
    using System;

    public class DbAccess : DbContext
    {
        private readonly string connectionString;

        public DbSet<Person>? People { get; set; }
        public DbSet<City>? Cities { get; set; }
        public DbSet<Country>? Countries { get; set; }

        public DbAccess()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var file = Path.Combine(path, @"ConnectionStrings\FamilyTreeWinForm.txt");
            if (File.Exists(file)) connectionString = File.ReadAllText(file);
            else connectionString = @"Server = (localdb)\mssqllocaldb; Database = TTGenealogi; Trusted_Connection = True;";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasMany(c => c.PeopleBorn).WithOne(p => p.BirthCity);
            modelBuilder.Entity<City>().HasMany(c => c.PeopleDead).WithOne(p => p.DeathCity);
            modelBuilder.Entity<Country>().HasMany(c => c.PeopleBorn).WithOne(p => p.BirthCountry);
            modelBuilder.Entity<Country>().HasMany(c => c.PeopleDead).WithOne(p => p.DeathCountry);
        }
    }
}
