// -----------------------------------------------------------------------------------------------
//  People.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstracts
{
    public abstract class AbstractPerson
    {
        public abstract void Read();
        public abstract void Save();

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNr { get; set; }
        public void PrintPerson()
        {
            Console.WriteLine($"{Name}, born on {BirthDate.ToString("yyyy-MM-dd")} has PhoneNr {PhoneNr}");
        }
    }
}


