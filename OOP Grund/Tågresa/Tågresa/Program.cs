namespace Tågresa
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            {
                // Definiera värden
                int startTimme = 8;
                int startMinut = 24;
                int frammeTimme = 11;
                int frammeMinut = 33;

                // Dra av timmar först
                int resTimmar = frammeTimme - startTimme;
                // Dra av minuter sen
                int resMinuter = frammeMinut - startMinut;
                // Om minuter är mindre än noll, öka minuter med 60
                // och minska timmen med 1 
                while (resMinuter < 0)
                {
                    resMinuter += 60;
                    resTimmar--;
                }
                // Skriv ut resultatet
                Console.WriteLine($"Resan tar {resTimmar:00}:{resMinuter:00}");
            }

            {
                // Definiera värden
                DateTime idag = DateTime.Now;
                int startTimme = 8;
                int startMinut = 24;
                int frammeTimme = 11;
                int frammeMinut = 33;

                DateTime start = new DateTime(idag.Year, idag.Month, idag.Day, startTimme,startMinut, 00);
                DateTime framme = new DateTime(idag.Year, idag.Month, idag.Day, frammeTimme,frammeMinut, 00);
                TimeSpan resTid = framme - start;
                // Skriv ut resultatet
                Console.WriteLine($"Resan tar {resTid.Hours:00}:{resTid.Minutes:00}");
            }



        }
    }
}
