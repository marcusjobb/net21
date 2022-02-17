// -----------------------------------------------------------------------------------------------
//  CatCrud.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace moqDB_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using moqDB_demo.Data;
using moqDB_demo.Models;

public class CatCrud
{
    CatsContext context;
    public CatCrud(CatsContext context)
    {
        this.context = context;
    }

    public void AddCat(Cat cat)
    {
        context.MyCats.Add(cat);
    }

    public void DeleteCat(Cat cat)
    {
        context.MyCats.Remove(cat);
    }
}
