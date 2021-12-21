using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeApp._Model
{
    public enum status { single, married, divorced, widow, unknown }
    public enum gender { male, female, unknown }

    class person
    {
        [Key]
        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public gender Gender { get; set; }
        public status Status { get; set; }
        public spouse Spouse { get; set; }
        public father Father { get; set; }
        public mother Mother { get; set; }
        public ICollection<children> Childrens { get; set; }
        public ICollection<sibling> Siblings { get; set; }
        public ICollection<grandFather> GrandFather { get; set; }
        public ICollection<grandMother> GrandMother { get; set; }
        public ICollection<aunt> Aunt { get; set; }
        public ICollection<uncle> Uncle { get; set; }
        public ICollection<cousin> Cousin { get; set; }

        public address Address { get; set; }

    }

    class spouse
    {
        [Key]
        public int spouseID { get; set; }
        public string spouseFirstName { get; set; }
        public string spouseLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public person Person { get; set; }


    }


    class father

    {
        [Key]
        public int fatherID { get; set; } = 0;
        public string fatherFirstName { get; set; }
        public string fatherLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public person Person { get; set; }

    }

    class mother

    {
        [Key]
        public int motherID { get; set; }
        public string motherFirstName { get; set; }
        public string motherLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public person Person { get; set; }

    }

    class children
    {
        [Key]
        public int childID { get; set; }
        public string childFirstName { get; set; }
        public string childLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }
    }


    class sibling
    {
        [Key]
        public int siblingID { get; set; }
        public string siblingFirstName { get; set; }
        public string siblingLastName { get; set; }
        
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }

    }

    class grandFather
    {
        public int grandFatherID { get; set; }
        public string grandFatherFirstName { get; set; }
        public string grandFatherLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }

    }

    class grandMother
    {
        public int grandMotherID { get; set; }
        public string grandMotherFirstName { get; set; }
        public string grandMotherLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }
    }

    class aunt
    {
        public int auntID { get; set; }
        public string auntFirstName { get; set; }
        public string auntLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }

    }


    class uncle
    {
        public int uncleID { get; set; }
        public string uncleFirstName { get; set; }
        public string uncleLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }
    }


    class cousin
    {
        public int cousinID { get; set; }
        public string cousinFirstName { get; set; }
        public string cousinLastName { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public ICollection<person> people { get; set; }

    }

   
    class address
    {
        [Key]
        public int addressID { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int BirthDate { get; set; }
        public int DethDate { get; set; }
        public int personIDFK { get; set; }
        [ForeignKey(nameof(personIDFK))]
        public person Person { get; set; }

    }
}
