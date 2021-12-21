// -----------------------------------------------------------------------------------------------
//  PeopleDB.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace MVCDemo.Database
{
    using Microsoft.EntityFrameworkCore;

    using MVCDemo.Models;

    public class PeopleDB:DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSQLLocalDB;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
