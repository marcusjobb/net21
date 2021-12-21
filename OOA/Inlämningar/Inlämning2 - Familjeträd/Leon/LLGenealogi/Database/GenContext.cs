using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LLGenealogi.Models
{
    public class LLGenContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;");
        }

    }
}
