using SQL___Inlämning_1.SQL;
using SQL___Inlämning_1.SQLClient;
using SQL___Inlämning_1.SqlCommander;

var dbName = "Test1";
var table = "MOCK_DATA";

Select Selection = new Select();
SqlCommands commands = new SqlCommands();
SqlCommandMenu commandMenu = new(dbName, table);

Selection.Logins();

if (SqlConnectorClient.GenerateConnection())
{
    commands.CreateDB(SqlConnectorClient.C, dbName, "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\");
    commands.CreateTable(SqlConnectorClient.C, dbName);

    while (true)
    {
        commandMenu.Show();
    }
}

SqlConnectorClient.C.Close();