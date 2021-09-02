namespace VariablerÖvning3
{
    using System;

    /* Pseudokod:
     * 
     * Deklarera namn
     * ta reda på namnets längd
     * Skriv ut längden
     */

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Marcus Medina";
            int length = name.Length;
            Console.WriteLine(name + " är " + length + " bokstäver långt");
        }
    }
}
