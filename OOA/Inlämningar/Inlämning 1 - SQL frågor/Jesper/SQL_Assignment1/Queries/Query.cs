using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Assignment1.Database;
using static SQL_Assignment1.Queries.QueryHelper;

namespace SQL_Assignment1.Queries
{
    internal class Query
    {
        
        internal static SQLDatabase currentDB = InitializeNewDB.dt;

        /// <summary>
        /// Selects all the unique countries in the database table, and displays it to the user.
        /// </summary>
        internal static void GetDifferentCountries()
        {
            string sqlQuery = "SELECT COUNT(DISTINCT country) FROM MOCKUP_DATA";
            var dt = currentDB.GetDataTable(sqlQuery,null);
            var dbList = DataTableToStringList(dt);
            Console.WriteLine($"There are [{dbList[0]}] unique countries in the database");
        }


        /// <summary>
        /// Checks whether all the usernames and passwords are unique. Compares the amount of unique usernames and passwords to the total amount of unique users.
        /// </summary>
        internal static void CheckUniqueUsernamePassword()
        {
            string sqlQuery = "SELECT COUNT(DISTINCT username), COUNT(DISTINCT password), COUNT(id) FROM MOCKUP_DATA";
            var dt = currentDB.GetDataTable(sqlQuery, null);
            var dbList = DataTableToStringList(dt);
            var userNames = dbList[0];
            var userPasswords = dbList[1];
            var uniqueIDs = dbList[2];
            Console.WriteLine($"There are [{userNames}] unique usernames out of [{uniqueIDs}] users.");
            Console.WriteLine($"\nThere are [{userPasswords}] unique passwords out of [{uniqueIDs}] users.");

            if (userNames != uniqueIDs)
            {
                Console.WriteLine("Not all usernames are unique.");
            }
            else if (userPasswords != uniqueIDs)
            {
                Console.WriteLine("Not all passwords are unique.");
            }
            else
            {
                Console.WriteLine("\nAll usernames and passwords are unique.");
            }
        }

        /// <summary>
        /// Does two queries to get the population from Scandinavia and The Nordics.
        /// </summary>
        internal static void GetNordicVSScandinavia()
        {
            string sqlQueryNordics = "SELECT id FROM MOCKUP_DATA WHERE country IN('Sweden', 'Norway', 'Denmark', 'Finland', 'Iceland', 'Greenland', 'Åland Islands', 'Faroe Islands')";
            var dtNordics = currentDB.GetDataTable(sqlQueryNordics, null);
            string sqlQueryScand = "SELECT id FROM MOCKUP_DATA WHERE country IN('Sweden', 'Norway', 'Denmark'); ";
            var dtScandinavia = currentDB.GetDataTable(sqlQueryScand, null);

            var nordicList = DataTableToStringList(dtNordics);
            var scandinaviaList = DataTableToStringList(dtScandinavia);
            Console.WriteLine($"In this database there are [{nordicList.Count}] people living in the Nordic countries and [{scandinaviaList.Count}] people living in Scandinavia");
        }

        /// <summary>
        /// Finds the most common country, by selecting unique users in each country, and then grouping them by country in descending order. Top of the list will have the most unique users per country.
        /// </summary>
        internal static void GetMostCommonCountry()
        {   
            string sqlQuery = "SELECT COUNT(id), country FROM MOCKUP_DATA Group BY country ORDER by COUNT(id) desc;";
            var dt = currentDB.GetDataTable(sqlQuery, null);
            var dbList = DataTableToStringList(dt);
            // SQL query orders by desc, so the top two items will be country and unique ID's in the most common country.
            var commonCountry = dbList[1];
            var commonCountryUsers = dbList[0];
            Console.WriteLine($"The most common country is {commonCountry} with [{commonCountryUsers}] unique users.");
        }

        /// <summary>
        /// Finds and prints all the users in the DB whose last name starts with an "L"
        /// </summary>
        internal static void GetTopTenUsersStartingWithL()
        {
            string sqlQuery = "SELECT top 10 first_name, last_name FROM MOCKUP_DATA WHERE LEFT(last_name, 1) LIKE 'L'";
            var dt = currentDB.GetDataTable(sqlQuery, null);
            PrintFormatedRows(dt);
        }

        /// <summary>
        /// Finds and prints all the users in the DB whose first name and last name starts with the same letter. Eg. Bob Builder
        /// </summary>
        internal static void GetSameFirstnameLastnameLetter()
        {
            string sqlQuery = "SELECT first_name, last_name FROM MOCKUP_DATA WHERE LEFT(first_name,1) LIKE LEFT(last_name,1);";
            var dt = currentDB.GetDataTable(sqlQuery, null);
            PrintFormatedRows(dt);
        }

    }
}
