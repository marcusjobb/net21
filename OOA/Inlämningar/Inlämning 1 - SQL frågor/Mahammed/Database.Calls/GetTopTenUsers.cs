using System.Data;
using static SQL.Inlämning.Program;

namespace SQL.Inlämning
{
    public class GetTopTenUsers
    {
        public static void TopTenUsers()
        {
            Console.WriteLine("|[5]- List the top 10 users whose name starts with L  |");
            var database = new Database();
            var response = database.GetDataTable("SELECT top 10 * " + "from[master].[dbo].[MOCK_DATA] " + "where last_name LIKE 'L%'");
            if (response != null && response.Rows.Count > 0)
            {

                foreach (DataRow row in response.Rows)
                {
                    Console.WriteLine($"\n>{row["first_name"]} {row["last_name"]} " + $"from {row["country"]}");
                }

            }
            NextQs();
        }
    }
}