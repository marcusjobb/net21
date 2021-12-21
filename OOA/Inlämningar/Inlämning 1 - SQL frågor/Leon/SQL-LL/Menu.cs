using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CertifiedIdiot.InputHandler;
using static SQL_LL.HelperGarbageDump;
using static SQL_LL.FetchDBStuff;
using System.Data.SqlClient;

namespace SQL_LL
{
    internal static class Menu
    {
        public static void Start(string tableName, SqlConnection conn)
        {
            // Prepare to bleach your eyes
            // Menu loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("What information do you wish to display?\n");
                Console.ResetColor();
                Console.WriteLine("0) How many different countries exsist within the DB?\n" +
                    "1) Are all usernames and passwords unique?\n" +
                    "2) How many countries are from the Nordic group and how many are from Scandinavia?\n" +
                    "3) Which is the most common country in the DB?\n" +
                    "4) List the ten first users whoes name begin with L.\n" +
                    "5) List all users who have the same first letter in both first name and surname.\n" +
                    "6) Add duplicate to DB. (DEBUG)");

                int intChoice = 10;
                while (intChoice > 6)
                {
                    intChoice = ConsoleToInt();
                }
                switch (intChoice)
                {
//===============================================================================================================================================
                    case 0:
                        FetchDataStr($"SELECT country FROM {tableName}", conn);
                        string data = FetchDataStr("SELECT DISTINCT country FROM " + tableName, conn, true);
                       
                        int intCountryCount = data.Count(c => c == ' ');
                        O();
                        Console.Write($"There are {intCountryCount + 1} different countries in the DB.");
                        break;
//===============================================================================================================================================
                    case 1:
                        FetchDataStr($"SELECT username, password FROM {tableName}", conn);
                        string strUserData = FetchDataStr($"SELECT username, password FROM {tableName} WHERE username IN " +
                            $"(SELECT username FROM {tableName} GROUP BY username HAVING COUNT(*) > 1)", conn);
                        string strPassData = FetchDataStr($"SELECT password, username FROM {tableName} WHERE password IN " +
                            $"(SELECT password FROM {tableName} GROUP BY password HAVING COUNT(*) > 1)", conn);
                        if(strUserData.Length == 0 && strPassData.Length == 0)
                        {
                            O();
                            Console.Write("All USERNAMES and PASSWORDS are UNIQUE");
                        }
                        else
                        {
                            X();
                            Console.Write("Some USERNAMES and PASSWORDS are NOT UNIQUE");
                        }
                        break;
//===============================================================================================================================================
                    case 2:
                        int nordicCount = 0, scandiCount = 0; 
                        string strData = FetchDataStr($"SELECT country FROM {tableName}", conn);
                        string[] arrData = strData.Split(' ');
                        
                        foreach(string c in arrData)
                        {
                            if(c == "Sweden" || c == "Norway" || c == "Denmark")
                            {
                                scandiCount++;
                            }
                        }
                        foreach (string c in arrData)
                        {
                            if (c == "Sweden" || c == "Norway" || c == "Denmark" || c == "Finland" || c == "Iceland")
                            {
                                nordicCount++;
                            }
                        }
                        O();
                        Console.Write($"There are {nordicCount} Nordic countries in the DB.\n");
                        O();
                        Console.Write($"There are {scandiCount} Scandinavaian countries in the DB.");
                        break;
//===============================================================================================================================================
                    case 3:
                        FetchDataStr($"SELECT country FROM {tableName}", conn);
                        string mostCommonCountry = (FetchDataStr($"SELECT TOP 1 country, COUNT(country) AS country_occurrence FROM {tableName}" +
                            $" GROUP BY country ORDER BY country_occurrence DESC", conn));
                        O();
                        Console.Write($"The most common country in the DB is:\n{mostCommonCountry}.");
                        break;
//===============================================================================================================================================
                    case 4:
                        FetchDataStr($"SELECT first_name, last_name FROM {tableName}", conn);
                        string topTenLUsers = FetchDataStr($"SELECT TOP 10 first_name FROM {tableName} WHERE first_name LIKE 'L%' ORDER BY first_name", conn, true);
                        O();
                        Console.Write($"Top then users whoes name begin with L:\n{topTenLUsers}");
                        break;
//===============================================================================================================================================
                    case 5:
                        FetchDataStr($"SELECT first_name, last_name FROM {tableName}", conn);
                        // https://stackoverflow.com/a/19799401
                        string userWithSameLetter = FetchDataStr($"SELECT first_name, last_name FROM {tableName} WHERE UPPER(LEFT(first_name, 1)) = UPPER(LEFT(last_name, 1))", conn);
                        O();
                        Console.Write($"Users with same first letter and firt name and last name:\n{userWithSameLetter}");
                        break;
//===============================================================================================================================================
                    case 6:
                        ExecuteNonQuery(File.ReadAllText("MOCK_DATA_DUPLICATE.sql"), conn);
                        O();
                        Console.Write("Duplicate user added to DB.");
                        break;
//===============================================================================================================================================
                    default:
                        ErrorExit();
                        break;
//===============================================================================================================================================
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress Enter to Continue.");
                Console.ReadLine();
                Console.ResetColor();
            }
        }
    }
}
