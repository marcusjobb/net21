using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch2
{
    static class Logger
    {
        public static void LogThis(this Exception ex)
        {
            Debug.WriteLine(ex.Message);
            System.IO.File.AppendAllText("log.txt", DateTime.Now.ToString() + " " + ex.Message + "\r\n");
            System.IO.File.AppendAllText("log.txt", DateTime.Now.ToString() + " " + ex.Source + " " + ex.StackTrace + "\r\n");
        }
    }
}
