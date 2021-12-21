using Genealogi.Models;
using Microsoft.EntityFrameworkCore;

namespace Genealogi.Data
{
    public class GenealogiDbContext : DbContext
    {
        public GenealogiDbContext(DbContextOptions<GenealogiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasOne(a => a.Mother).WithMany()./*HasForeignKey<Person>(a => a.MotherId).*/OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Person>().HasOne(a => a.Father).WithMany()./*HasForeignKey<Person>(a => a.FatherId).*/OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Person> People { get; set; }
    }
}
