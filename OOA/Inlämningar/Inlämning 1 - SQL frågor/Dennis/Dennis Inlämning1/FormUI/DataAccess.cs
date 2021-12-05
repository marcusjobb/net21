using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FormUI
{
    public class DataAccess
    {
        // Söker ALLA.
        public List<Person> GetAll()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>($"SELECT * FROM People ORDER BY id;").ToList();
                return output;
            }
        }

        // Söker ID.
        public List<Person> GetId(string id)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetId @Id", new { Id = id }).ToList();
                return output;
            }
        }

        // Söker FÖRNAMN.
        public List<Person> GetFirstName(string firstName)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetFirstName @FirstName", new { FirstName = firstName }).ToList();
                return output;
            }
        }

        // Söker EFTERNAMN.
        public List<Person> GetLastName(string lastName)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        // Söker EMAIL.
        public List<Person> GetEMail(string email)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetEmail @Email", new { Email = email }).ToList();
                return output;
            }
        }

        // Söker ANVÄNDARNAMN.
        public List<Person> GetUserName(string username)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetUserName @UserName", new { Username = username }).ToList();
                return output;
            }
        }

        // Söker LÖSENORD.
        public List<Person> GetPassword(string password)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetPassword @Password", new { Password = password }).ToList();
                return output;
            }
        }

        // Söker SÖKER LAND.
        public List<Person> GetCountry(string country)
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("dbo.spPeople_GetCountry @Country", new { Country = country }).ToList();
                return output;
            }
        }

        // • Hur många olika länder finns representerade?
        public int GetCountryCount()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.QuerySingle<int>("select count (distinct country) from dbo.People;");
                return output;
            }
        }

        // • Lista de 10 första användarna vars efternamn börjar på bokstaven L
        public List<Person> GetFirstTenNamesL()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.Query<Person>("select top 10 * from dbo.People where last_name like 'l%' order by id asc;").ToList();
                return output;
            }
        }

        // • Är alla username och password unika?
        public bool AreUsernamesAndPasswordsUnique()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var peopleCount = connection.QuerySingle<int>("SELECT COUNT(1) FROM People");
                var distinctUsernameCount = connection.QuerySingle<int>("SELECT COUNT(DISTINCT username) FROM People");
                var distinctPasswordCount = connection.QuerySingle<int>("SELECT COUNT(DISTINCT password) FROM People");

                var uniqueUsernames = peopleCount == distinctUsernameCount;
                var uniquePasswords = peopleCount == distinctPasswordCount;

                return uniqueUsernames && uniquePasswords;
            }
        }

        // • Vilket är det vanligaste landet?
        public string MostCommonCountry()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.QuerySingle<string>("select top 1 country from dbo.People group by country order by COUNT(country) desc");
                return output;
            }
        }

        // • Hur många är från (Norden) respektive Skandinavien?
        public int GetNordicContriesCount()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.QuerySingle<int>("SELECT COUNT(country) from dbo.People where country in ('Sweden','Denmark','Norway','Finland','Iceland', 'Greenland','Faroe Islands','Åland Islands')");
                return output;
            }
        }

        // • Hur många är från Norden respektive (Skandinavien)?
        public int GetScandinaviaContriesCount()
        {
            using (IDbConnection connection = CreateConnection())
            {
                var output = connection.QuerySingle<int>("SELECT COUNT(country) from dbo.People where country in ('Sweden','Denmark','Norway')");
                return output;
            }
        }

        private IDbConnection CreateConnection()
        {
            return new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DB1"));
        }
    }
}