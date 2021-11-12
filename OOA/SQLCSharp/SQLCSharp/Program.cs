namespace SQLCSharp
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    internal class Program
    {
        static void Main()
        {
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=People;Trusted_Connection=True;";

            var sqlQuery = "Select Top 10 * from People";
            SqlDataReader rdr = null;
            SqlConnection con = null;
            SqlCommand cmd = null;
            DataTable dta = null;
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand(sqlQuery,con);
            var adapter = new SqlDataAdapter(cmd);

            dta = new DataTable();
            adapter.Fill(dta);

            if (dta.Rows.Count>0)
            {
                foreach (DataRow person in dta.Rows)
                {
                    Console.WriteLine(person[0]+" "+person[1]);
                }
            }
            con.Open();

        }
    }
}
