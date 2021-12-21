using Inlämning2_Tiia.Database;
using System;
using System.Collections.Generic;

namespace Inlämning2_Tiia
{
    class Program
    {
        static void Main(string[] args) //instansiera och starta familjeträdet
        {
            var start = new PersonCrud();
            start.Start();
        }
    }
}
