using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace SQL_Inlämning_1
{
    class Program
    {
        
        private static void Main(string[] args)
        {
            

            

            

            Console.WriteLine("Ange ett namn");
            var input = Console.ReadLine();
            var sql = "Select first_name, last_name from MOCK_DATA WHERE first_name LIKE @param";
            var dt = GetDataTable(sql, (name: "@param", value: input));
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine($"{item["country"]} {item["last_name"]}");
            }

            Console.WriteLine("Länder som är representerade: ");

            sql = "Select country, COUNT(*) count FROM MOCK_DATA GROUP by country ORDER BY 2 DESC";
            dt = GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine($"{item["country"]}: {item["count"]}");
            }

            Console.ReadLine();
            Console.WriteLine("Unika username och password:");
            sql = "SELECT DISTINCT username, password FROM MOCK_DATA ORDER BY username, password";
            dt = GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine($"{item["username"]} {item["password"]}");
            }

            Console.ReadLine();
            Console.WriteLine("Länder från Norden och Skandinavien:");
            sql = "SELECT  last_name, country FROM MOCK_DATA WHERE country IN ('Denmark', 'Finland', 'Iceland', 'Norway', 'Sweden','Faroe Islands','Greenland','Åland Islands')";
            dt = GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine($"{item["last_name"]} {item["country"]}");
            }

            Console.WriteLine(" 10 första efternamn, som börjar med 'L':");
            sql = " SELECT TOP 10 last_name FROM MOCK_DATA WHERE last_name LIKE 'L%'";
            dt = GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["last_name"]);
            }

            Console.WriteLine("Vanligaste länder:");
            sql = "SELECT country, COUNT(country) as amount FROM MOCK_DATA Group By country";
            dt = GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["country"]);
            }

            Console.WriteLine();
            sql = "SELECT first_name, last_name FROM MOCK_DATA WHERE LEFT(first_name, 1) = LEFT(last_name, 1)";
            dt = GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine($"{item["first_name"]} {item["last_name"]}");
            }
        }

        private static void PrintRow(DataTable dt)
        {
            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine(item["first_name"] + " " + item["last_name"]);
                Console.WriteLine(item["country"]);
                Console.WriteLine(item["username"]);
                Console.WriteLine(item["password"]);
            }   

        }

       







        private static DataTable GetDataTable(string sql, params (string name, string value)[] p)
        {
            var connectionString =
           "server=(localdb)\\mssqllocaldb;integrated security=true; database=DataFromPeople";
            var dt = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    foreach (var param in p)
                    {
                        command.Parameters.AddWithValue(param.name, param.value);
                    }

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;

        }
    }

}

