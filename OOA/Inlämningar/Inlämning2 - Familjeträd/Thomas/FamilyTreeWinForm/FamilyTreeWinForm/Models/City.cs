// -----------------------------------------------------------------------------------------------
//  City.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class City
    {
        [Key]
        public int CityId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [InverseProperty("BirthCity")]
        public List<Person>? PeopleBorn { get; set; }
        [InverseProperty("DeathCity")]
        public List<Person>? PeopleDead { get; set; }
    }
}
