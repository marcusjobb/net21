using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Inlämning2byDB.Models
{
    public class Person
    {
        [Key] // Primary Key.
        public int Id { get; set; } // Id.

        [DisplayName("First Name")]
        public string FirstName { get; set; } // Förnamn.

        [DisplayName("Last Name")]
        public string LastName { get; set; } // Efternamn.

        [DisplayName("Mother Id")]
        public int? MotherId { get; set; } // Mamma Id (Allows Null).

        [DisplayName("Father Id")]
        public int? FatherId { get; set; } // Pappa Id (Allows Null).
    }
}
 