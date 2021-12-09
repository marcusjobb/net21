// -----------------------------------------------------------------------------------------------
//  ConnStringBuilder.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace ConnStringGenerator.Builders
{
    using ConnStringGenerator.Models;

    internal class ConnStringBuilder
    {
        public ConnString ConnectionString { get; set; } = new ConnString();
        public ConnStringBuilder SetServer(string server)
        {
            if (server == null) return this;
            ConnectionString.Server = server;
            return this;
        }
        public ConnStringBuilder SetDatabase(string database)
        {
            if (database == null) return this;
            ConnectionString.Database = database;
            return this;
        }

        public string Build()
        {
            return $"Server={ConnectionString.Server}\\v11.0;Integrated Security=true;Database={ConnectionString.Database}";
        }

    }
}
