namespace OOA_Inlamning1
{
    using Helpers;
    using System.Data;
    using System.Data.SqlClient;

    internal class SqlNoDapper
    {
        internal string ConnectionString { get; set; } = @"Server={1};Database={0};Trusted_Connection=True;";
        internal string DatabaseName { get; set; } = "TT_Net21_People";
        public string Server { get; set; } = @"(localdb)\mssqllocaldb";

        internal string CnnString
        {
            get { return string.Format(ConnectionString, DatabaseName, Server); }
        }

        public SqlNoDapper()
        {
            DatabaseName = DbCheckHelper.DbName;
        }

        internal DataTable GetDataTable(string sql, (string name, string value)[] parameters)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(CnnString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var (paramName, paramValue) in parameters)
                        {
                            if (paramName != null && paramValue != null) cmd.Parameters.AddWithValue(paramName, paramValue);
                        }
                    }
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        internal void ExecuteSQL(string sql, (string pName, string pValue)[] parameters)
        {
            using (var conn = new SqlConnection(CnnString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var (paramName, paramValue) in parameters)
                        {
                            if (paramName != null && paramValue != null) cmd.Parameters.AddWithValue(paramName, paramValue);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}