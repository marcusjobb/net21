using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        public int Id { get; set; } = 0; // Id (Primary Key).
        public string First_Name { get; set; } = ""; // Förnamn.
        public string Last_Name { get; set; } = "";// Efternamn.
        public string Email { get; set; } = ""; // Email.
        public string Username { get; set; } = ""; // Användarnamn.
        public string Password { get; set; } = ""; // Lösenord.
        public string Country { get; set; } = ""; // Land.


        // Skriver ut hela infon om personen inuti peopleFoundListBox.
        public string FullInfo
        {
            get 
            { 
                return $"Id: {Id} │ Firstname: { First_Name } | Lastname: { Last_Name } | E-mail: {Email} | Username: {Username} | Password: {Password} | Country: {Country}";
            }
        }
    }
}
