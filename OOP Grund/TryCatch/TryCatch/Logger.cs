// -----------------------------------------------------------------------------------------------
//  Logger.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;

namespace TryCatch
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
