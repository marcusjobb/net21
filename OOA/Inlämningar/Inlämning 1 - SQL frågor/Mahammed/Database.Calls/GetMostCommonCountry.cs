using System.Data;
using static SQL.Inlämning.Program;
namespace SQL.Inlämning
{

    public class GetMostCommonCountry
    {
        public static void CommonCountry()
        {
            Console.WriteLine("|[4]- Whats the most common country in this database? |");
            var database = new Database();
            var response = database.GetDataTable("SELECT top 1 country, count(id) AS users " + "FROM[master].[dbo].[MOCK_DATA] " + "GROUP BY country " + "order by count(id) desc");
            if (response != null && response.Rows.Count > 0)
            {
                foreach (DataRow row in response.Rows)
                {
                    Console.WriteLine($"\n>Its {row["country"]} With {row["users"]} Many Users");
                }

            }
            NextQs();
        }
    }
}
