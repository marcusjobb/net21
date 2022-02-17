// -----------------------------------------------------------------------------------------------
//  MyDatabase.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace moqDB_demo.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Models;

public class CatsContext : DbContext
{
    private const string DatabaseName = "CatsDB";
    private const string ConnString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database={0}";

    public virtual DbSet<Cat> MyCats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conn = string.Format(ConnString, DatabaseName);
        optionsBuilder.UseSqlServer(conn);
        base.OnConfiguring(optionsBuilder);
    }
}
