using System;

namespace FarmerAndTheGoatAndTheWolfAndTheLettuce
{
    using System;
    using System.Collections.Generic;

    // Delarera saker i spelet
    enum Thingies
    {
        Farmer,
        Goat,
        Lettuce,
        Wolf,
    }

    internal class Program
    {
        //Deklarera globala variabler
        static List<Thingies> Beach = new List<Thingies>();
        static List<Thingies> Dinghy = new List<Thingies>();
        static List<Thingies> Island = new List<Thingies>();
        // Översättningslista
        static string[] Translator = { "Bonden", "Geten", "Salladen", "Vargen" };
        private static void Main(string[] args)
        {
            Intro();

            // --------------------------------------------------------------------------------------------------
            // Använd kommandot MoveThingie (sak, från, till) enbart för att lösa pusslet 
            // Du har fyra objekt : Bonden, Salladen, Geten och Vargen
            // Du har tre platser Stranden, Ekan och ön.
            // Ekan har bara två platser  
            //
            // Som exemplet nedan
            // --------------------------------------------------------------------------------------------------
            MoveThingie(Thingies.Lettuce, Beach, Dinghy); // Flytta bonden från stranden till ekan
            MoveThingie(Thingies.Farmer, Beach, Dinghy); // Flytta salladen från stranden till ekan

            //Väl framme i ön
            MoveThingie(Thingies.Lettuce, Dinghy, Island); // Flytta bonden från ekan till ön
            MoveThingie(Thingies.Farmer, Dinghy, Island); // Flytta salladen från ekan till ön

        }

        private static void Intro()
        {
            Console.WriteLine("En bonde ska föra över en varg, en get och ett salladshuvud");
            Console.WriteLine("från stranden till en ö. Det finns ingen bro :(");
            Console.WriteLine("Tyvärr är hans eka rätt sunkig och han får bara plats med");
            Console.WriteLine("sig själv och en sak i taget.");
            Console.WriteLine("Vargen kan äta upp geten om den får vara själv med den.");
            Console.WriteLine("Geten kan äta salladshuvudet om den får vara själv med den.");
            Console.WriteLine("Vargen tycker inte om salladen.");
            Console.WriteLine();

            // Sätt alla objekt vid sin startpunkt
            Beach.AddRange(new Thingies[] { Thingies.Farmer, Thingies.Goat, Thingies.Lettuce, Thingies.Wolf });
        }

        // Kontrollerar förflyttning av saker
        private static void MoveThingie(Thingies thing, List<Thingies> from, List<Thingies> to)
        {
            // Ekan måste alltid användas, annars funkar inte spelet
            if (!(from == Dinghy || to == Dinghy))
            {
                Console.WriteLine("Du kan bara flytta från stranden/ön till ekan");
                Console.WriteLine("Eller från ekan till/från stranden/ön");
                Console.WriteLine("Att slänga en varg eller en get från stranden till");
                Console.WriteLine("Ön skulle vara djumisshandel!");
                Console.WriteLine("I övrigt skulle salladen gå sönder.");
            }
            
            // Kolla om saken man vill flytta finns på platsen
            if (!from.Contains(thing))
            {
                Console.Write(Translator[(int)thing] + " finns inte på ");
                GetLocationName(from);
                return;
            }
            else if (to == Dinghy)
            {
                // Kontrollera antal platser i ekan
                if (Dinghy.Count > 1)
                {
                    Console.WriteLine("Det finns inte plats på ekan");
                    return;
                }
            }
            // Flytta på saker
            from.Remove(thing);
            to.Add(thing);
            Console.Write("Flyttade " + Translator[(int)thing] + " till ");
            GetLocationName(to);
            
            // Kolla så att alla överlever förändringarna
            CheckStatus();
        }

        // Skriver ut namnet på platsen
        private static void GetLocationName(List<Thingies> from)
        {
            if (from == Beach) Console.WriteLine("Stranden");
            else if (from == Dinghy) Console.WriteLine("Ekan");
            else if (from == Island) Console.WriteLine("Ön");
        }

        // Kollar status
        private static void CheckStatus()
        {
            bool success = CheckForDanger(Beach) && CheckForDanger(Island) && CheckForDanger(Dinghy);
            if (!success)
            {
                Console.WriteLine("Du failade :(");
                Environment.Exit(0); // Avsluta programmet
            }
        }

        // Kollar om det finns några faror för spelets varelser
        private static bool CheckForDanger(List<Thingies> list)
        {
            // Kollar var saker finns
            bool hasFarmer = list.Contains(Thingies.Farmer);
            bool hasGoat = list.Contains(Thingies.Goat);
            bool hasLettuce = list.Contains(Thingies.Lettuce);
            bool hasWolf = list.Contains(Thingies.Wolf);
            // Kollar var saker finns
            if (!hasFarmer)
            {
                if (hasGoat && hasLettuce)
                {
                    // Fail geten åt salladen
                    Console.WriteLine("Geten åt salladen :(");
                    return false;
                }
                else if (hasWolf && hasGoat)
                {
                    // Fail Vargen åt geten
                    Console.WriteLine("Vargen åt upp geten... meh");
                    return false;
                }
            }
            else
            {
                // Yay! Du vann!
                if (list == Island && hasFarmer && hasLettuce && hasGoat && hasWolf)
                {
                    Console.WriteLine("Du lyckades!");
                    Console.WriteLine("Vargen åt nu upp bonden, sen blev den mätt och la sig att sova");
                    Console.WriteLine("och då passade geten på att äta upp salladen.");
                    Console.WriteLine("Senare så vaknade vargen och åt upp geten");
                    Console.WriteLine("sen lärde den sig att fiska och levde lycklig i alla sina dagar");
                    Environment.Exit(0);
                }
            }

            return true;
        }
    }
}
