using Genealogi_OOA_JosefinPersson.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogi_OOA_JosefinPersson
{
    public class Database:DbContext  
    {
        private const string DatabaseName = "JPGenealogi";
        private const string ConnString = "server=(localdb)\\mssqllocaldb;integrated security=true;database = JPGenealogi";    
        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnString);   
            base.OnConfiguring(optionsBuilder);
        }
    }
}
