

namespace OOA_Inlamning1.Extensions
{
    using System;
    using System.IO;

    public static class Logger
    {
        #region Public Methods

        public static void LogThis(this Exception ex)
        {
            string dir = "log";
            string fileName = "log.txt";
            string logText = DateTime.Now.ToString() + " " + ex.Message + " " + ex.StackTrace+"\n";

            try
            {
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not create direcory for log file.\r\n" + e.Message + "\r\n" + e.StackTrace);
            }

            try
            {
                File.AppendAllText($@"{dir}\{fileName}", logText);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not write to log.\r\n" + e.Message + "\r\n" + e.StackTrace);
            }
        }

        #endregion Public Methods
    }
}