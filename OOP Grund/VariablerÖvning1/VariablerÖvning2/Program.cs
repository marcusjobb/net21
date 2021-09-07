namespace VariablerÖvning2
{
    using System;

    /* Pseudokod:
     * 
     * Deklarera hundålder
     * Deklarera personålder
     * Beräkna personålder * hundålder
     * Skriv ut ålder
     */

    class Program
    {
        static void Main(string[] args)
        {
            int dogAge = 7;
            int age = 51;
            int doggieAge = age * dogAge;
            Console.WriteLine(age + " människoår " + "blir " + doggieAge + " hundår");
        }
    }
}
