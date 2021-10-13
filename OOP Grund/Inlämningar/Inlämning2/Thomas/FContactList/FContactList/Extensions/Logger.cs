// -----------------------------------------------------------------------------------------------
//  Logger.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList.Extensions
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public static class Logger
    {
        #region Public Methods

        public static void LogThis(this Exception ex)
        {
            string dir = "log";
            string fileName = "log.txt";
            string logText = DateTime.Now.ToString() + " " + ex.Message + " " + ex.StackTrace;

            try
            {
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            }
            catch (Exception e)
            {
                MessageBox.Show("Kunde ej skapa katalog för logfilen.\r\n" + e.Message + "\r\n" + e.StackTrace);
            }

            try
            {
                File.AppendAllText($@"{dir}\{fileName}", logText);
            }
            catch (Exception e)
            {
                MessageBox.Show("Kunde ej skriva till logfilen.\r\n" + e.Message + "\r\n" + e.StackTrace);
            }
        }

        #endregion Public Methods
    }
}