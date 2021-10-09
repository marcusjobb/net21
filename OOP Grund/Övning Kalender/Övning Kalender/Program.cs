// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Övning_Kalender
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Deklaration 1
            // -----------------------------------------------------------------------------
            int month = 0;
            int year = DateTime.Now.Year; // detta år

            // -----------------------------------------------------------------------------
            // Svenska namn
            // -----------------------------------------------------------------------------
            string[] monthNames = { "Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "December" };
            string[] dayNames = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };

            // -----------------------------------------------------------------------------
            // Skaffa grunddata
            // -----------------------------------------------------------------------------
            Console.WriteLine("Kalender");
            Console.Write("Ange månad: ");
            string input = Console.ReadLine().Trim().ToLower();
            int.TryParse(input, out month);

            if (month < 1 || month > 12)
            {
                month = DateTime.Now.Month;
            }

            DateTime startDate = new DateTime(year, month, 1, 13, 37, 0);
            DayOfWeek weekDay = startDate.DayOfWeek;
            int startFrom = (int)weekDay;
            startFrom -= 1;
            if (startFrom < 0) startFrom = 6;

            int monthLength = DateTime.DaysInMonth(year, month);

            // -----------------------------------------------------------------------------
            // Deklaration 2,
            // detta borde finnas i början av koden, men slarvar lite och skriver det
            // här i rent pedagogisk syfte.
            // -----------------------------------------------------------------------------
            int pageWidth = Console.WindowWidth - 1;
            int dayWidth = pageWidth / 7;
            int titleWidth = dayWidth * 7;
            dayWidth -= 1;
            titleWidth -= 1;
            // -----------------------------------------------------------------------------
            // Skriver ut namnet på månaden
            // -----------------------------------------------------------------------------
            Console.Clear();
            string output = monthNames[month - 1] + " " + year + " ";
            output = output.PadLeft(titleWidth); // Se till att max antal mellanslag finns

            Console.WriteLine("+" + new string('-', titleWidth) + "+");
            Console.WriteLine("|" + output + "|");

            string topLine = "";
            for (int i = 0; i < 7; i++)
            {
                topLine += "+" + new string('-', dayWidth);
            }
            topLine += "+";

            // -----------------------------------------------------------------------------
            // Skapa en mall för veckodagarna
            // -----------------------------------------------------------------------------
            string dataline = "|(0)|(1)|(2)|(3)|(4)|(5)|(6)|";

            // -----------------------------------------------------------------------------
            // Skriver veckodagarna
            // -----------------------------------------------------------------------------
            Console.WriteLine(topLine);
            string dayLine = dataline; //  |(0)|(1)|(2)|(3)|(4)|(5)|(6)|
            string infoLine = dataline; // |(0)|(1)|(2)|(3)|(4)|(5)|(6)|
            for (int i = 0; i < 7; i++)
            {
                string number = "(" + i + ")";
                output = " " + dayNames[i].PadRight(dayWidth);
                output = output.Substring(0, dayWidth);
                dayLine = dayLine.Replace(number, output);
            }
            Console.WriteLine(dayLine); // skriver ut raden med dagar
            Console.WriteLine(topLine); // skriver ut separator

            int pos = startFrom;

            // Nollställ dagraden till mallen igen
            // När man kopierar en string på detta sätt så kopieras
            // innehållet, inte minnesplatsen till skillnad från objekt och arrays
            dayLine = dataline; //  |(0)|(1)|(2)|(3)|(4)|(5)|(6)|
            infoLine = dataline; // |(0)|(1)|(2)|(3)|(4)|(5)|(6)|

            string emptyLine = new string(' ', dayWidth);
            for (int day = 0; day < startFrom; day++)
            {
                string number = "(" + day + ")";
                dayLine = dayLine.Replace(number, emptyLine);
                infoLine = infoLine.Replace(number, emptyLine);
            }

            for (int day = 1; day <= monthLength; day++)
            {
                string number = "(" + pos + ")";
                output = " " + day.ToString().PadRight(dayWidth).Substring(0, dayWidth - 1);
                dayLine = dayLine.Replace(number, output);
                //TODO: Lägg till viktiga datum istället för tom rad
                infoLine = infoLine.Replace(number, emptyLine);
                pos++;
                if (pos > 6)
                {
                    pos = 0;
                    // Skriv ut raderna
                    Console.WriteLine(dayLine);
                    Console.WriteLine(infoLine);
                    Console.WriteLine(topLine);
                    // Nollställ raderna till mallen
                    dayLine = dataline; //  |0|1|2|3|4|5|6|
                    infoLine = dataline; // |0|1|2|3|4|5|6|
                }
            }
            if (pos > 0)
            {
                for (int day = pos; day < 7; day++)
                {
                    string number = "(" + day + ")";
                    dayLine = dayLine.Replace(number, emptyLine);
                    infoLine = infoLine.Replace(number, emptyLine);
                }
                Console.WriteLine(dayLine);
                Console.WriteLine(infoLine);
                Console.WriteLine(topLine);
            }

            Console.ReadLine();
        }
    }
}
