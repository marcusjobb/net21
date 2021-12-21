using System.ComponentModel.DataAnnotations;

namespace Inlämning_2_EntityFramwork.Models
{
    public class Person //Propertyclass för People-listan
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? BirthYear { get; set; }
        public int? DeathYear { get; set; }
        public int? Father { get; set; }
        public int? Mother { get; set; }
    }
}