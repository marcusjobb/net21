using Microsoft.EntityFrameworkCore;

namespace Inlämning2_Tiia.Database
{
    public class PersonContext : DbContext
    {
        private const string DatabaseName = "TTGenealogi";
        public DbSet<Person> People { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
        }
    }
}
