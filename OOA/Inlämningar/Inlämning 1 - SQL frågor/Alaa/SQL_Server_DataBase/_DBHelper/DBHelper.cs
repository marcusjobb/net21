using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;


namespace SQL_Server_DataBase._DBHelper
{
    class DBHelper
    {
        public static DataTable ExecSelect(string query)
        {
            DataTable dt = new DataTable();
            string source = "server=ALAA; integrated security = true; database = People";
            using (var conn = new SqlConnection(source))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query)
        {
            string source = "server=ALAA; integrated security = true; database = People";

            using (var conn = new SqlConnection(source))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int done = cmd.ExecuteNonQuery();
                conn.Close();
                return done;
            }
        }

        public static void rowDetail(DataTable dt)
        {
            Console.Clear();
            Console.WriteLine("\n");
            foreach (DataRow row in dt.Rows)
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write($"{row[i]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
