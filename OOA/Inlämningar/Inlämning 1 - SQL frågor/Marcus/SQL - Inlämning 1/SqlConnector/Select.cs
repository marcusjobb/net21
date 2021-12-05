using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL___Inlämning_1.SQLClient
{
    internal class Select
    {
        public void Logins()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*Reading logins from login.xml*\n");

            LoginXMLReader reader = new LoginXMLReader();
            reader.Read();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select one of following logins\n");

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < reader.logins.Count; i++)
            {
                string passLength = "";

                for (int p = 0; p < reader.logins[i].Password.Length; p++)
                {
                    passLength += "*";
                }

                Console.WriteLine(i + 1 + ". Name: " + reader.logins[i].Name + "\n\tServer: " + reader.logins[i].Server + "\n\tPassword: " + passLength);
            }

            int select = 0;
            while (!int.TryParse(Console.ReadLine(), out select) || select > reader.logins.Count || select <= 0)
            {
                Console.WriteLine("Invalid input.");
            }

            SqlConnectorClient.LoginInfo.Name = reader.logins[select - 1].Name;
            SqlConnectorClient.LoginInfo.Server = reader.logins[select - 1].Server;
            SqlConnectorClient.LoginInfo.Password = reader.logins[select - 1].Password;

            Console.WriteLine("\nSelected login:\n\tName: " + SqlConnectorClient.LoginInfo.Name + "\n\tServer: " + SqlConnectorClient.LoginInfo.Server);
        }
    }
}
