using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL___Inlämning_1.SQLClient;
using System.Data.SqlClient;
using System.Data;

namespace SQL___Inlämning_1.SQL
{
    public class SqlCommands
    {
        public void CreateDB(SqlConnection connection, string databaseName, string path)
        {

            string str = "CREATE DATABASE " + databaseName + " ON PRIMARY " +
             "(NAME = " + databaseName + ", " +
             "FILENAME = '" + path + "" + databaseName + ".mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = " + databaseName + "_Log, " +
             "FILENAME = '" + path + "" + databaseName + ".ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            using (var q = new SqlCommand(str, connection))
            {

                try
                {


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("EXECUTING: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n" + q.CommandText);

                    q.ExecuteNonQuery();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDatabase was Created Successfully");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (System.Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR:\n" + ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        //connection.Close();
                    }
                }
            }
        }

        public void CreateTable(SqlConnection connection, string dbName)
        {
            string fileName = "MOCK_DATA.sql";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTrying to read from " + fileName);
            Console.ForegroundColor = ConsoleColor.White;

            using (StreamReader reader = new(fileName))
            {
                string str = "USE " + dbName + "; ";
                while (!reader.EndOfStream)
                {
                    str += reader.ReadLine();
                }

                using (var q = new SqlCommand(str, connection))
                {
                    try
                    {


                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nEXECUTING " + str.Length + " characters of code");
                        Console.ForegroundColor = ConsoleColor.White;

                        q.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nTable was created successfully");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (System.Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERROR:\n" + ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            //connection.Close();
                        }
                    }
                }
            }


        }

        public void DifferentCountries(SqlConnection connection, string dbName, string table)
        {
            var q = "USE " + dbName + "; SELECT count( DISTINCT country) from " + table + " ;";

            Console.WriteLine("Svar: " + SimpleSqlAnswer<int>(connection, q) + "\n");
        }

        public void UniqueUserPassoword(SqlConnection connection, string dbName, string table)
        {

            var q = "USE " + dbName + "; SELECT count( DISTINCT username ) from " + table + " ;";

            Console.WriteLine("\nÄr alla användare unika?");

            if (SimpleSqlAnswer<int>(connection, q)==1000)
                Console.WriteLine("Ja");
            else
                Console.WriteLine("Nej");


            q = "USE " + dbName + "; SELECT count( DISTINCT password ) from " + table + " ;";

            Console.WriteLine("Är alla lösenord unika?");

            if (SimpleSqlAnswer<int>(connection, q) == 1000)
                Console.WriteLine("Ja\n");
            else
                Console.WriteLine("Nej\n");

        }

        public void ManyScandinavian(SqlConnection connection, string dbName, string table)
        {
            var q = "USE " + dbName + "; SELECT COUNT( *  ) from " + table + " WHERE country='Sweden' OR country='Denmark' OR country='Norway';";

            Console.WriteLine("Antal från Skandinavien: " + SimpleSqlAnswer<int>(connection, q) + "\n");

            q = "USE " + dbName + "; SELECT COUNT( *  ) from " + table + " WHERE country='Sweden' OR country='Denmark' OR country='Norway' OR country='Finland' OR country='Iceland';";

            Console.WriteLine("Antal från Norden: " + SimpleSqlAnswer<int>(connection, q) + "\n");
        }

        public void MostCommonCountry(SqlConnection connection, string dbName, string table)
        {
            var q = "USE " + dbName + "; SELECT TOP 1 country FROM " + table + " GROUP BY country ORDER BY COUNT(*) DESC";
            Console.WriteLine("Flest användare är ifrån: " + SimpleSqlAnswer<string>(connection, q) + "\n");

        }

        public void ListUsersLastNameStartingWith(SqlConnection connection, string dbName, string table, string startingWith)
        {
            var q = "USE " + dbName + "; SELECT TOP 10 * FROM " + table + " WHERE last_name LIKE @STARTINGWITH + '%';";

            using (SqlDataAdapter da = new SqlDataAdapter())
            {

                Console.Write("Börjar på: ");
                startingWith = Console.ReadLine();

                DataTable dt = new DataTable();

                da.SelectCommand = new SqlCommand(q, connection);
                da.SelectCommand.Parameters.Add("@STARTINGWITH", SqlDbType.NVarChar, 128).Value = startingWith;

                da.Fill(dt);

                for (int y = 0; y < dt.Rows.Count; y++)
                {
                    Console.Write(y+1 + "| ");
                    for (var x = 0; x < dt.Columns.Count; x++)
                    {
                        Console.Write(dt.Rows[y][x] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }

        public void ListUsersWithNameFirstLast(SqlConnection connection, string dbName, string table)
        {
            var q = "USE " + dbName + "; SELECT* FROM " + table + " WHERE UPPER(LEFT(first_name, 1)) = UPPER(LEFT(last_name, 1))";

            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                DataTable dt = new DataTable();

                da.SelectCommand = new SqlCommand(q, connection);

                da.Fill(dt);

                for (int y = 0; y < dt.Rows.Count; y++)
                {
                    Console.Write(y + 1 + "| ");
                    for (var x = 0; x < dt.Columns.Count; x++)
                    {
                        Console.Write(dt.Rows[y][x] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }




        public T SimpleSqlAnswer<T>(SqlConnection connection, string q)
        {
            T result=default(T);
            IDataRecord dataRecord;
            SqlCommand command = new SqlCommand(q, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataRecord = (IDataRecord)reader;
                result = (T)dataRecord[0];
            }

            reader.Close();
            //connection.Close();
            return result;
        }
    }
}
