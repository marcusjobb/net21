using Inlämning_2_EntityFramwork.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlämning_2_EntityFramwork;

public class DBClass : DbContext
{
    private const string DatabaseName = "MHGenealogi";
    
    public DBClass() { }

    public DbSet<Person> People { get; set; } // skapar tabellen i databasen


   


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // skapar koppling till databasen.
    {
        optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
    }
}

