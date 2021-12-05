namespace OOA_Inlamning1
{
    internal class Person
    {
        public int id { get; set; }
        public string first_name { get; set; } = "";
        public string last_name { get; set; } = "";
        public string email { get; set; } = "";
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string country { get; set; } = "";

        public string FullName
        {
            get { return first_name + " " + last_name; }
        }
        public string AllInfo
        {
            get { return $"<{id,3}> {first_name,-10} {last_name,-14} {email,-30} {username,-13} {password,-13} {country,-15}"; }
        }
    }
}