using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Assignment1.Queries
{
    internal class QueryHelper
    {
        /// <summary>
        /// Gets all the rows and stores them in a string list.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        internal static List<string> DataTableToStringList(DataTable dt)
        {
            List<string> dataRows = new();
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dataRows.Add(row[i].ToString());
                }
            }
            return dataRows;
        }

        /// <summary>
        /// Prints all the columns in each database row in a box.
        /// </summary>
        /// <param name="dt"></param>
        internal static void PrintFormatedRows(DataTable dt)
        {
            //TODO: Print two columns?

            foreach (DataRow row in dt.Rows)
            {

                Console.WriteLine("┌───────────────────────────────────┐");
                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    var lastitem = dt.Columns.Count - 1;
                    string padding = " ";
                    var maxPadding = 14;
                    var nameLength = row[i].ToString().Length;
                    
                    var paddingCount =  maxPadding - nameLength;
                    // Loop to adjust the padding
                    for (int addedPadd = 0; addedPadd < paddingCount; addedPadd++)
                    {
                        padding += " ";
                    }

                    // Adds a "|" character to the start and end of each row, instead of each column.
                    if (i == lastitem)
                    {
                        Console.Write($"{row[i]} {padding}  │");
                    }
                    else
                    {
                        Console.Write($"│{padding} {row[i]} ");
                    }
                        
                }
                Console.WriteLine();
                Console.WriteLine("└───────────────────────────────────┘");


            }
            
        }
    }
}
