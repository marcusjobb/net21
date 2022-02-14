// -----------------------------------------------------------------------------------------------
//  Person.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace MoqDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqDemo.Interfaces;

public class Person : IPerson
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
}
