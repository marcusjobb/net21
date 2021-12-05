using System.Data;
using static SQL.Inlämning.Program;

namespace SQL.Inlämning
{
    public class GetFromTheNorthAndScandinavia
    {
        public static void TheNorthAndScandinavia()
        {
            Console.WriteLine("|[3]- How many are from the north respectively from scandinavia? |");
            var database = new Database();
            var response = database.GetDataTable("SELECT count(Distinct id) " + "as The_North_And_Scandinavia " + "from[master].[dbo].[MOCK_DATA] " + " where country in ('Sweden', 'Denmark', 'Norway', " + "'Finland', 'Iceland') ");
            if (response != null && response.Rows.Count > 0)
            {
                foreach (DataRow row in response.Rows)
                {
                    Console.WriteLine($"\n>There is {row["The_North_And_Scandinavia"]} people from " + $"the north and scandinavia.");

                }
            }
            NextQs();
        }
    }
}