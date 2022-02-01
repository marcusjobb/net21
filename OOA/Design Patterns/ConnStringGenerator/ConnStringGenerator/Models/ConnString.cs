// -----------------------------------------------------------------------------------------------
//  ConnString.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ConnStringGenerator.Models
{
   internal class ConnString
    {
        public string Server { get; set; } = "127.0.0.1";
        public string Database { get; set; } = "MyDatabase";
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
