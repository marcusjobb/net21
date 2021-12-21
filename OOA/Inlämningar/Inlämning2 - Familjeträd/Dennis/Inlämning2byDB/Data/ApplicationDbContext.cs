using Inlämning2byDB.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlämning2byDB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
            
        public DbSet<Person> Persons { get; set; }
    }
}
