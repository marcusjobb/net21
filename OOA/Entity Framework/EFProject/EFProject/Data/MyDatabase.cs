// -----------------------------------------------------------------------------------------------
//  MyDatabase.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace EFProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;
    using Microsoft.EntityFrameworkCore;

    internal class MyDatabase: DbContext
    {
        private const string DatabaseName = "MyDatabase";
        private const string ConnString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database={0}";

        DbSet<MyModel> ModelData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn=string.Format(ConnString, DatabaseName);
            optionsBuilder.UseSqlServer(conn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
