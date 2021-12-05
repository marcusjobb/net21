using System.Data;
using static SQL.Inlämning.Program;
namespace SQL.Inlämning
{

    public class GetUserWithSameLetter
    {
        public static void SameLetter()
        {
            Console.WriteLine("|[6]- List all the users whose firstname and lastname starts with same letter|");
            var database = new Database();
            var response = database.GetDataTable("SELECT first_name, last_name " + "FROM[master].[dbo].[MOCK_DATA] " + "WHERE LEFT(first_name, 1) = LEFT(last_name, 1) " + "AND first_name <> last_name");
            if (response != null && response.Rows.Count > 0)
            {

                foreach (DataRow row in response.Rows)
                {
                    Console.WriteLine($"\n>{row["first_name"]} {row["last_name"]}");
                }

            }
            NextQs();
        }
    }
}
