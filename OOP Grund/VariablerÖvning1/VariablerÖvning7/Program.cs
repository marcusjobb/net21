namespace VariablerÖvning7
{
    using System;

    /* Pseudokod:
     * 
     * definiera procent
     * definiera pris på stad långt bort
     * definiera pris på stad nära
     * definiera kostnad för bränsle per liter
     * definiera bränsleförbrukning per 10 mil
     * 
     * Beräkna bränslekostnad 
     *
     * Dra av procent från priset för stad långt bort
     * Addera bränslekostnad till priset, två gånger (fram och tillbaka resa)
     * 
     * Skriv ut båda priserna
     */


    class Program
    {
        static void Main(string[] args)
        {
            double percent = 15/100.0;
            double tvVarberg = 6990;
            double tvGöteborg = 7220;
            double fuel = 16.53;
            double km = 76;
            double fuelPerMile = 8.0 / 10.0;

            double fuelCost = fuel * (km / 10.0) * fuelPerMile;

            tvVarberg *= (1 - percent); // pris efter rabatt
            double tvVarbergFuel = tvVarberg + fuelCost * 2; // dubbla bränslekostnaden för resa fram och tillbaka

            Console.WriteLine("Varberg pris               :" + Math.Round(tvVarberg, 2));
            Console.WriteLine("Varberg pris (inkl bränsle):" + Math.Round(tvVarbergFuel, 2));
            Console.WriteLine("Göteborgspris              :" + Math.Round(tvGöteborg, 2));
        }
    }
}
