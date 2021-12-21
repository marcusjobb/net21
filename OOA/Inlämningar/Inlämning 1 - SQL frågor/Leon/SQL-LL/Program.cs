// Setup stuff yada yada
// Dumpster fire in terms of so called "Clean Code" but whatever it works right?
using System.Data.SqlClient;
using static SQL_LL.HelperGarbageDump;
using static SQL_LL.FetchDBStuff;

// Strings
string dir = Directory.GetCurrentDirectory();
string tableName = "[SQL_LL].[dbo].[MOCK_DATA]";
String strCreateDB = "CREATE DATABASE SQL_LL ON PRIMARY " +
     "(NAME = SQL_LL, " +
     $"FILENAME = '{dir}\\DB\\SQL_LL.mdf', " +
     "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
     "LOG ON (NAME = SQL_LL_Log, " +
     $"FILENAME = '{dir}\\DB\\SQL_LL.ldf', " +
     "SIZE = 1MB, " +
     "MAXSIZE = 5MB, " +
     "FILEGROWTH = 10%)",
    strSeedTable = File.ReadAllText("MOCK_DATA_TABLE.sql"),
    strSeed = File.ReadAllText("MOCK_DATA.sql"),
    strConn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;";

SqlConnection conn = new SqlConnection(strConn);

Console.ResetColor();
O();
Console.Write("Setting up...");
Thread.Sleep(1000);

// No DB dir? Create one.
Directory.CreateDirectory("DB");

// Create DB with extreme (prejudice) safety
O();
Console.Write("Checking DB status...");
if (System.IO.File.Exists($"{dir}\\DB\\SQL_LL.mdf") || System.IO.File.Exists($"{dir}\\DB\\SQL_LL.ldf"))
{
    X();
    Console.Write($"Mdf or ldf file already exists, skipping DB creation...");
}
else
{
    if(!ValidDB("SQL_LL", conn))
    {
        X();
        Console.Write("DB not found! Creating DB...");
        if (ExecuteNonQuery(strCreateDB, conn))
        {
            O();
            Console.Write("DB created successfully.");
        }
        else
        {
            ErrorExit();
        }
    }
    else
    {
        X();
        Console.Write("DB already exists, skipping DB creation...");
    }
}
Thread.Sleep(1000);

// Seeding DB with safety
O();
Console.Write("Checking DB seed status...");
if (!ValidDBTable(tableName, conn))
{
    X();
    Console.Write("DB not seeded! Seeding...");
    ExecuteNonQuery(strSeedTable, conn);
    ExecuteNonQuery(strSeed, conn);
    O();
    Console.Write("DB seeded.");
}
else
{
    X();
    Console.Write("DB already seeded, skipping seeding...");
}

Thread.Sleep(1000);

O();
Console.Write("Setup done.");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\nPress Enter to Continue.");
Console.ResetColor();
Console.ReadLine();

// Setup done. Start main program
SQL_LL.Menu.Start(tableName, conn);

