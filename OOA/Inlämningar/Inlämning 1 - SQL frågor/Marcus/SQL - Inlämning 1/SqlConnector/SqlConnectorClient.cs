using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SQL___Inlämning_1.SQL;

namespace SQL___Inlämning_1.SQLClient
{
    internal static class SqlConnectorClient
    {
        public static SqlConnection? C { get; set; }
        public static LoginDetails LoginInfo { get; set; } = new LoginDetails();

        public static bool GenerateConnection()
        {
            LoginXMLReader XmlReader = new();
            List<LoginDetails> logins = XmlReader.Read();

            if (!XmlReader.IsNull(LoginInfo))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nBuilding connecting string with:");


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\tUsername: " + LoginInfo.Name);
                Console.WriteLine("\tServer: " + LoginInfo.Server + "\n\n");
                

                string cStr = "Server=" + LoginInfo.Server + ";" +
                                "User id=" + LoginInfo.Name + ";" +
                                "Password=" + LoginInfo.Password + ";" +
                                "Integrated security=SSPI;" +
                                "database=master";

                Console.WriteLine("\tConnection String=" + cStr);

                Console.ForegroundColor = ConsoleColor.White;

                C = new("Server=" + LoginInfo.Server + "; " +
                    "User id=" + LoginInfo.Name + "; " +
                    "Password=" + LoginInfo.Password + "; " +
                    "Integrated security=SSPI; " +
                    "database=master"
                    );

                if (C is null)
                {
                    Console.WriteLine("Failed to login");
                }
            }
            else
            {
                Console.WriteLine("Error reading login-data");

                return false;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nManaged to generate connection string\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTrying to connect...");

            try
            {
                SqlConnectorClient.C.Open();
                SqlCommands command = new();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Connected to " + command.SimpleSqlAnswer<string>(C, "SELECT @@VERSION"));
                Console.ForegroundColor = ConsoleColor.White;

                return true;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Couldn't connect to database. Wrong login details in login.xml?");
                Console.ForegroundColor = ConsoleColor.White;

                return false;
            }
        }
    }
}
