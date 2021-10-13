using System.Collections.Generic;

namespace Inlämning_2_ChatUp
{
    internal class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }

        public bool isGhosted { get; set; }
        public bool isBlocked { get; set; }

    }
}