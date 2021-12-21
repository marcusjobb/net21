using EF_inlämning_2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_inlämning_2.Data
{
    public class DataContext : DbContext
    {
        private const string DatabaseName = "MYGenealogi1";
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\MSSQLLocalDB;Database={DatabaseName};trusted_connection=true");
        }
    }
}