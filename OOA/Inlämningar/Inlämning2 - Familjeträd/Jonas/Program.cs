using System;
using System.Collections.Generic;

using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Family.Models;
using Family.Database;
 

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Database!");
            using (var db = new PersonContext())
            {
                //Family.NotMain.Populate(db);
                Family.NotMain.MainLoop(db);
            }
        }
    }
}
