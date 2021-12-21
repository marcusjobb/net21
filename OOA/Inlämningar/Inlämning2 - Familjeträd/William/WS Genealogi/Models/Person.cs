using System.ComponentModel.DataAnnotations;

namespace WS_Genealogi.Models
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Mother { get; set; }
        public string? Father { get; set; }
        public int Birthday { get; set; }

        public override string ToString()
        {
            return $"{Name ?? "Saknas"} {LastName ?? "Saknas"} {Mother} {Father} {Birthday}";
        }
    }
}
