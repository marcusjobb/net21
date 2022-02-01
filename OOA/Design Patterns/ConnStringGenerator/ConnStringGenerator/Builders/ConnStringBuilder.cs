// -----------------------------------------------------------------------------------------------
//  ConnStringBuilder.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace ConnStringGenerator.Builders
{
    using ConnStringGenerator.Models;

internal class ConnStringBuilder
{
    public string Server { get; set; } = "127.0.0.1";
    public string Database { get; set; } = "MyDatabase";
    public string Username { get; set; }
    public string Password { get; set; }
    public ConnStringBuilder SetServer (string server)
    {
        if (server != null)
            Server = server;
        return this;
    }
    public ConnStringBuilder SetDatabase (string database)
    {
        if (database != null)
            Database = database;
        return this;
    }

    public ConnStringBuilder SetUsername (string username)
    {
        if (username != null)
            Username = username;
        return this;
    }

    public ConnStringBuilder SetPassword (string password)
    {
        if (password != null)
            Password= password;
        return this;
    }

    public string Build ()
    {
        if (Username == null)
            return $"Server={Server}\\v11.0;Integrated Security=true;Database={Database}";
        else
            return $"Server={Server};Database={Database};User Id={Username};Password={Password};";
    }
}
}
