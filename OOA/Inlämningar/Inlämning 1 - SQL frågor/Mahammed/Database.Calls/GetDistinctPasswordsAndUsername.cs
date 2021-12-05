using System.Data;
using static SQL.Inlämning.Program;

namespace SQL.Inlämning
{
    public class GetDistinctPasswordsAndUsername
    {
        public static void PasswordsAndUsername()
        {
            Console.WriteLine("|[2]- Are all Usernames and Passwords Unique? |");
            var database = new Database();
            var response = database.GetDataTable("SELECT count(*) as UAP " + "from[master].[dbo].[MOCK_DATA] " + "group by username, password " + "having count(*) > 1");
            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    Console.WriteLine("All Passwords and usernames are not unique");
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"\n>{row["passwords"]} {row["userName"]}");
                       
                    }
                    
                }
                
                else
                {
                    Console.WriteLine("All Passwords and Usernames are unique.");
                    
                }
            }
            NextQs();
        }
    }
}