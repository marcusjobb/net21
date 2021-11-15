namespace SQLFromCSharpDemo
{
    using System;
    using System.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SQL!");
            //var db = new SqlDatabase();
            //db.DatabaseName = "People";

            //var allParameters = new ParamData[2];
            //allParameters[0] = new ParamData { Name = "@fname", Data = "Clark" };
            //allParameters[1] = new ParamData { Name = "@lname", Data = "Kent" };

            //var dt = db.GetDataTable("Select * from MOCK_DATA Where first_name=@fname AND last_name=@lname", allParameters);
            //foreach (DataRow item in dt.Rows)
            //{
            //    Console.WriteLine(item[0]+" "+item[1]);
            //}

        }
    }
}
