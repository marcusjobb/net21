// -----------------------------------------------------------------------------------------------
//  Person.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace PlaneringsDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /* Princessan Leia
     * Född: Skywalker, adopterades av Organa, gifte sig med Solo
     */

    public class History
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string Event { get; set; }
    }

    public class Spouse
    {
        public int Id { get; set; }
        public Person SpouseA { get; set; }
        public Person SpouseB { get; set; }
    }

    public class Pet
    {
        public int Id { get; set; }
        public Person Owner { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; } // Bara för VG
        public string DeathDate { get; set; } // Bara för VG
        public Pet MotherId { get; set; }
        public Pet FatherId { get; set; }
    }

    public class Person
    {
        public int Id { get; set; } // Id <--- Behövs alltid
        public string FirstName { get; set; } // Namn 
        public string MiddleName { get; set; } // Namn 
        public string LastName { get; set; } // Efternamn
        public string MaidenName { get; set; } // Efternamn före äktenskap
        public string BirthDate { get; set; } // Bara för VG
        public string DeathDate { get; set; } // Bara för VG
        public Person MotherId { get; set; }
        public Person FatherId { get; set; }
        public List<Spouse> Spouses { get; set; } // Äktenskap
        public List<History> History { get; set; }
    }
}
