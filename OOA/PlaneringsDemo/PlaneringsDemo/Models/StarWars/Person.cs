// -----------------------------------------------------------------------------------------------
//  Person.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace PlaneringsDemo.Models.StarWars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal enum Species
    {
        Human, Twilek, Wookie
    }

    public class BirthPlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BirthPlace BirthPlace { get; set; }
        public Species Species { get; set; } // Human, Twilek, Wookie osv
        public string FirstName { get; set; } // Namn 
        public string MiddleName { get; set; } // Namn 
        public string LastName { get; set; } // Efternamn
        public string MaidenName { get; set; } // Efternamn före äktenskap
        public int BirthDate { get; set; } // Baserad på att BBY = 0
        public int DeathDate { get; set; } // Bara för VG
        public Person MotherId { get; set; }
        public Person FatherId { get; set; }

    }
}
