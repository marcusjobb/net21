using SQL___Inlämning_1.SQL;
using SQL___Inlämning_1.SQLClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL___Inlämning_1.SqlCommander
{
    internal class SqlCommandMenu
    {
        public string DbName { get; set; }
        public string Table { get; set; }
        int Choice = 0;
        List<String> MenuItems = new List<String>();

        public SqlCommandMenu(string dbName, string table)
        {
            DbName = dbName;
            Table = table;

            MenuItems.Add("Hur många olika länder finns representerade?");

            MenuItems.Add("Är alla username och password unika?");

            MenuItems.Add("Hur många är från Norden respektive Skandinavien ?");

            MenuItems.Add("Vilket är det vanligaste landet?");

            MenuItems.Add("Lista de 10 första användarna vars efternamn börjar på bokstaven");

            MenuItems.Add("Visa alla användare vars för - och efternamn har samma begynnelsebokstav");
        }

        public void Show(string strParameter = "")
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{i+1}. " + MenuItems[i]);
            }

            while (!int.TryParse(Console.ReadLine(), out Choice) || Choice<1 || Choice > MenuItems.Count)
            {
                Console.WriteLine("Ogiltligt val");
            }

            ExecuteSqlCommands(Choice-1, strParameter);
        }

        public void ExecuteSqlCommands(int choice, string strParameter="")
        {
            SqlCommands commands = new();

            switch (choice)
            {
                case 0: commands.DifferentCountries(SqlConnectorClient.C, DbName, Table);
                    break;
                case 1: commands.UniqueUserPassoword(SqlConnectorClient.C, DbName, Table);
                    break;
                case 2: commands.ManyScandinavian(SqlConnectorClient.C, DbName, Table);
                    break;
                case 3: commands.MostCommonCountry(SqlConnectorClient.C, DbName, Table);
                    break;
                case 4: commands.ListUsersLastNameStartingWith(SqlConnectorClient.C, DbName, Table, strParameter);
                    break;
                case 5: commands.ListUsersWithNameFirstLast(SqlConnectorClient.C, DbName, Table);
                    break;
                default:
                    Show();
                    break;
            }
        }
    }
}
