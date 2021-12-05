using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//using static  System.Data.SqlClient.SqlParameter;
//using Microsoft.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace sqlinl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
 
            string filePath = Path.Combine(userFolder, "MOCK_DATA.sql");
 
            Console.WriteLine("Hello SQL!");
 
            var ih8sql = new SqlDatabase(); // { DatabaseName = "testDb2" };


            var fiatLux = new ParamData[1];
            fiatLux[0] = new ParamData { Name = "@dbName", Data = "ih8sql" };// parametrarna gör ingenting, men måste inkluderas...

            ih8sql.ExecuteSQL("CREATE DATABASE ih8sql", fiatLux);

            ih8sql.DatabaseName = "ih8sql";

            ih8sql.ExecuteSQLNoParams(@"
                

            create table MOCK_DATA 
            ( 
            id INT,
            first_name VARCHAR(50),
            last_name VARCHAR(50),
            email VARCHAR(50),
            username VARCHAR(50),
            password VARCHAR(50),
            country VARCHAR(50))"
               );

            if (File.Exists(filePath))
            {

                string[] lines = System.IO.File.ReadLines(filePath).ToArray();

                for (int i = 9; i < lines.Length; i++)
                {
                    ih8sql.ExecuteSQLNoParams(lines[i]);
                    //Thread.Sleep(100);
                    Console.WriteLine(i + lines[i]);
                }
            }

            var nullParamenter = new ParamData[1];


            ////--Hur många olika länder finns representerade?//////////////////////////////////////////////////////////

 

            int countries = ih8sql.GetANumber("SELECT  Count(DISTINCT country) FROM MOCK_DATA  ", nullParamenter);
            Console.WriteLine( "det finns "+countries+" länder");

            //// --Är alla username och password unika ? (samma för username)///////////////////////////////////////////////

            int numPasswords = ih8sql.GetANumber("SELECT COUNT (DISTINCT password) FROM MOCK_DATA", nullParamenter);

            int totalPasswords = ih8sql.GetANumber("SELECT   COUNT(password) FROM MOCK_DATA", nullParamenter);
            int totalNulls = ih8sql.GetANumber("SELECT COUNT(id) FROM MOCK_DATA WHERE password is NULL", nullParamenter);

            if (totalPasswords == numPasswords && totalNulls == 0)
            {
                Console.WriteLine("Alla passwords är distinkta");
            }
            else
            {
                Console.WriteLine("några passwords är samma eller några är null");
            }

            ////////////////////////////////
            int numUsernames = ih8sql.GetANumber("SELECT COUNT (DISTINCT password) FROM MOCK_DATA", nullParamenter);

            int totalUsernames = ih8sql.GetANumber("SELECT   COUNT(username) FROM MOCK_DATA", nullParamenter);
           totalNulls = ih8sql.GetANumber("SELECT COUNT(id) FROM MOCK_DATA WHERE password is NULL", nullParamenter);

            if (totalPasswords == numUsernames && totalNulls == 0)
            {
                Console.WriteLine("Alla usernames är distinkta");
            }
            else
            {
                Console.WriteLine("några usernames är samma eller några är null");
            }


            ////--Hur många är från Norden respektive Skandinavien?//////////////////////////////////////////////////////////////    

            var skandi = new ParamData[3];
            skandi[0] = new ParamData { Name = "@no", Data = "Norway" };
            skandi[1] = new ParamData { Name = "@se", Data = "Sweden" };
            skandi[2] = new ParamData { Name = "@dk", Data = "Denmark" };

            var plusNord = new ParamData[2];
            plusNord[0] = new ParamData { Name = "@fi", Data = "Finland" };
            plusNord[1] = new ParamData { Name = "@is", Data = "Iceland" };

            int numSkandi = ih8sql.GetANumber(" SELECT  Count(country) FROM MOCK_DATA  WHERE country=@no OR country=@se OR country=@dk", skandi);
            int numPlusNord = ih8sql.GetANumber(" SELECT  Count(country) FROM MOCK_DATA  WHERE country=@fi OR country=@is", plusNord);

 
            Console.WriteLine("Det finns " + (numSkandi + numPlusNord) + "från  nordiska länder, varav " + numSkandi + " skandinaviska");
 

            ////   --Vilket är det vanligaste landet?/////////////////////////////////////////////       

            var ettLand = ih8sql.GetDataTable(" SELECT country, COUNT(*) AS Frequency FROM MOCK_DATA GROUP BY country ORDER BY COUNT(*) DESC OFFSET 0 ROWS  FETCH NEXT 1 ROWS ONLY --att hitta rätt syntax för detta tog mig ~5h  ", nullParamenter);
            Console.Write ("Vanligaste landet: "  );
            printDataTable(ettLand, new int[] { 0 });

            ////  Lista de 10 första användarna vars efternamn börjar på bokstaven L /////////////////////////////////////////////////
            ///

            var letterL = new ParamData[1];
            letterL[0]= new ParamData { Name = "@letter", Data = "L" };

             
            var firstTenL = ih8sql.GetDataTable(" SELECT * FROM MOCK_DATA WHERE SUBSTRING (last_name, 1, 1) = @letter order by id  offset 0 ROWS fetch next 10 ROWS ONLY", letterL);
            Console.WriteLine("-----------------");
            printDataTable(firstTenL, new int[] { 0,1,2,3 });
            Console.WriteLine("_________________");
            ////--Visa alla användare vars för- och efternamn har samma begynnelsebokstav/////////////////////////////////////////

             
            var doubleTrouble = ih8sql.GetDataTable("SELECT * FROM MOCK_DATA WHERE SUBSTRING (last_name, 1, 1) = SUBSTRING (first_name, 1, 1) order by id ", nullParamenter);
             
            printDataTable(doubleTrouble, new int[] { 1, 2, 3});














        }

        public static void printDataTable( DataTable dt, int[] cols)
        {
            foreach (DataRow item in dt.Rows)
            {

                foreach (var num in cols)
                {
                    if (num < dt.Columns.Count && num >= 0)
                    {

                        Console.Write(item[num]+" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
