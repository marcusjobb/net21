// -----------------------------------------------------------------------------------------------
//  EFDBContextClass1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace EFProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using EFProject.Models;

    internal class EFDBContextClass1 : DbContext
    {
        private const string DatabaseName = "EFDBContextClass1";
        private const string ConnString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database={0}";

        DbSet<MyModel> ModelData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = string.Format(ConnString, DatabaseName);
            optionsBuilder.UseSqlServer(conn);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
