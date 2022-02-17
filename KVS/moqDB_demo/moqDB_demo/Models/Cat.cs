// -----------------------------------------------------------------------------------------------
//  MyModel.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace moqDB_demo.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Colour { get; set; } = "";
}
