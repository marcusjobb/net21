using System.Data;
using System.Data.SqlClient;

namespace SQL_inlämning
{
    internal class SQLConnection
    {
        public static void SqlConnTwoRow(string sqlQuery)
        {
            //https://github.com/marcusjobb/net21/blob/main/OOA/SQLCSharp/SQLCSharp/Program.cs
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=Inlämning1;Trusted_Connection=True;";

            SqlConnection con = null;
            SqlCommand cmd = null;
            DataTable dta = null;
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlQuery, con);
            var adapter = new SqlDataAdapter(cmd);

            dta = new DataTable();
            adapter.Fill(dta);

            if (dta.Rows.Count > 0)
            {
                foreach (DataRow row in dta.Rows)
                {
                    Console.WriteLine(row[0] + " " + row[1]);
                }
            }
            con.Open();
        }
        public static void SqlConnOneRow(string sqlQuery)
        {
            //https://github.com/marcusjobb/net21/blob/main/OOA/SQLCSharp/SQLCSharp/Program.cs
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=Inlämning1;Trusted_Connection=True;";

            SqlConnection con = null;
            SqlCommand cmd = null;
            DataTable dta = null;
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlQuery, con);
            var adapter = new SqlDataAdapter(cmd);

            dta = new DataTable();
            adapter.Fill(dta);

            if (dta.Rows.Count > 0)
            {
                foreach (DataRow row in dta.Rows)
                {
                    Console.WriteLine(row[0]);
                }
            }
            con.Open();
        }
    }
}

