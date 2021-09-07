namespace VariablerÖvning4
{
    using System;
    /* Pseudokod:
     * 
     * Fråga om förnamn
     * Fråga om efternamn
     * Summera längden på båda
     * Skriv ut längde
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt förnamn:");
            string fname = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn:");
            string lname = Console.ReadLine();

            int length = fname.Length + lname.Length;

            Console.WriteLine(fname + " " + lname + " är " + length + " bokstäver långt");
        }
    }
}
