using System;

namespace ClassPOCO_DTO
{
    /// <summary>
    /// Demo av POCOs och DTOs
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        static void Main()
        {
            Person person = new Person();
            person.Name = "Bruce";
            person.Lastname = "Willis";
            person.BirthDate = DateTime.Parse("1955, march 19");
            person.Address.City = "Duckville";
            person.Address.Street = "Long street 45";
            Console.WriteLine(person);
        }
    }

    /// <summary>
    /// Person object that calculates age
    /// </summary>
    internal class Person // Plain Old Class Object
    {
        /// <summary>
        /// The name of the subject
        /// </summary>
        public string Name { get; set; } = ""; // property som agerar som variabel
        /// <summary>
        /// The last name of the subject
        /// </summary>
        public string Lastname { get; set; } = ""; // property som agerar som variabel
        /// <summary>
        /// The birth date of the subject
        /// </summary>
        public DateTime BirthDate { get; set; } = DateTime.Now; // property som agerar som variabel
        /// <summary>
        /// The age of the subject (based on today and birth date)
        /// </summary>
        public int Age // Fejkad property, den returnerar en beräkning
        {
            get
            {
                return (int)((DateTime.Now - BirthDate).Days / 365.25);
            }
        }

        public Address Address { get; set; } = new Address(); // Sätt alltid standardvärde på properties

        public override string ToString()
        {
            return Name + " " + Lastname + " born on " +
                   BirthDate.ToString("yyyy MMM dd, ddd") + 
                   ", is " + Age + " old" +
                   "\nLives on " + Address.Street+ ", " + Address.City;
        }
    }

    /// <summary>
    /// DTO example
    /// </summary>
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}
