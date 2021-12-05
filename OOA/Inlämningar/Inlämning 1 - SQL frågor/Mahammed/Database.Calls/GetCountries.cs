using System.Data;
using static SQL.Inlämning.Program;

namespace SQL.Inlämning
{
    public class GetCountries
    {
        public static void Countries()
        {
            Console.Clear();
            var database = new Database();
            Console.WriteLine("|[1]- How many countries are represented? |");
            var response = database.GetDataTable("SELECT COUNT (DISTINCT country) as Countries " +
                "FROM[master].[dbo].[MOCK_DATA]");
            if (response != null && response.Rows.Count > 0)
            {
                foreach (DataRow row in response.Rows)
                {
                    Console.WriteLine($"\n> {row["Countries"]} Countries represented.");
                    
                }
            }
            NextQs();
        }
    }
}