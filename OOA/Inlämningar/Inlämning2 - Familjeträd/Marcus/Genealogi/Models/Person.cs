using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Genealogi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? DeathPlace { get; set; }
        public int? MotherId { get; set; }
        public Person? Mother { get; set; }
        public int? FatherId { get; set; }
        public Person? Father { get; set; }
        public Byte[]? Image { get; set; }
    }
}
