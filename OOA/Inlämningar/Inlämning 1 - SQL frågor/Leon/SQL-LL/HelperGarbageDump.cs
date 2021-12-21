using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace SQL_LL
{
    // Messy, but in a good fun quirky way!(Its a feature(Help))
    internal static class HelperGarbageDump
    {

        // No Operation 0x90 and all that
        public static void NOP(double durationSeconds)
        {
            var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }

        // Returns true if there already exists a DB with given DBName
        public static bool ValidDB(string DBName, SqlConnection conn)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand($"SELECT db_id('{DBName}')", conn);

            conn.Open();
            try
            {
                result = cmd.ExecuteScalar() != DBNull.Value;
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

            return result;
        }

        // Returns true if table exists with given tableName
        public static bool ValidDBTable(string tableName, SqlConnection conn)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {tableName}", conn);

            
            try
            {
                conn.Open();
                cmd.ExecuteScalar();
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
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return result;
        }

        // If shit hits the fan shut it down
        public static void ErrorExit()
        {
            X();
            Console.Write("Something went terribly wrong! Shutting down... ___ ...");
            System.Environment.Exit(1337);
        }

        // EVERYTHING IS GOING TO BE O-KAY
        public static void O()
        {
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O");
            Console.ResetColor();
            Console.Write("] ");
        }

        // X marks the spot, dont draw one on your forehead though least you lose it :^)
        // X = BAD/HEADS UP
        public static void X()
        {
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.ResetColor();
            Console.Write("] ");
        }
    }
}
