using System.Data;
using System.Data.SqlClient;
using static SQL_LL.HelperGarbageDump;

namespace SQL_LL
{
    // Like my naming conventions? ◕‿↼
    internal static class FetchDBStuff
    {
        // Returns false if Query successfully went wrong :^)
        public static bool ExecuteNonQuery(string str, SqlConnection conn)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand(str, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (System.Exception ex)
            {
                X();
                Console.Write("Error: " + ex.Message);
                result = false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return result;
        }

        // Send in a query and out pops data! Wonderfull
        public static string FetchDataStr(string str, SqlConnection conn, bool silent = false)
        {
            SqlCommand cmd = new SqlCommand(str, conn);
            string data = "";
            try
            {
                conn.Open();
                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    data = data + " " + (sqlReader.GetValue(0).ToString());
                }
                sqlReader.Close();
                if (!silent)
                {
                    foreach (string c in data.Split(' '))
                    {
                        Console.Write(c + " ");
                        NOP(0.01);
                    }
                    NOP(1);
                    Console.Clear();
                }
            }
            catch (System.Exception ex)
            {
                X();
                Console.Write("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return data;
        }
    }
}
