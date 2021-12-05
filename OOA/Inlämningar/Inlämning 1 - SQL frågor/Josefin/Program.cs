using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Project1_JosefinPersson
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new(); // instansierar menyn
            menu.mainMenu(); // kör mainmenu 
        }
    }
}