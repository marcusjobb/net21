// See https://aka.ms/new-console-template for more information
using EFDemo2.Models;

using Microsoft.EntityFrameworkCore;

public class DbDemo2 : DbContext
{
    public DbSet<Person>? People { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBDemo2;Trusted_Connection=True;");
    }
}