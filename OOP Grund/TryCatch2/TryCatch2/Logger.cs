// -----------------------------------------------------------------------------------------------
//  Logger.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;
using System.Diagnostics;

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
