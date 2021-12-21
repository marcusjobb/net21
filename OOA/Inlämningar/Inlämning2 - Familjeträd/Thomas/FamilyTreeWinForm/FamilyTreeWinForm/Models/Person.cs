// -----------------------------------------------------------------------------------------------
//  Person.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; } = "";
        [MaxLength(50)]
        public string LastName { get; set; } = "";
        public int BirthYear { get; set; }
        public int? BirthCityId { get; set; }
        [ForeignKey("BirthCityId")]
        public City? BirthCity { get; set; }
        public int? BirthCountryId { get; set; }
        [ForeignKey("BirthCountryId")]
        public Country? BirthCountry { get; set; }
        public int? DeathYear { get; set; }
        public int? DeathCityId { get; set; }
        [ForeignKey("DeathCityId")]
        public City? DeathCity { get; set; }
        public int? DeathCountryId { get; set; }
        [ForeignKey("DeathCountryId")]
        public Country? DeathCountry { get; set; }
        public int? FatherId { get; set; }
        [ForeignKey("FatherId")]
        public Person? Father { get; set; }
        public int? MotherId { get; set; }
        [ForeignKey("MotherId")]
        public Person? Mother { get; set; }
        [NotMapped]
        public string FullName { get => $"{FirstName} {LastName}"; }
        [NotMapped]

        public string FullNameAndLifeTime { get => $"{FirstName} {LastName} ({BirthYear}{(DeathYear == null || DeathYear == 0 ? "" : ", " + DeathYear)})"; }
    }
}
