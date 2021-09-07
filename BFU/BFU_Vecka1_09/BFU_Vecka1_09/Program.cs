namespace BFU_Vecka1_09
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            Console.Write("Är du smart? (j/n)");
            string input = Console.ReadLine().ToUpper();

            answer = input[0] == 'J'; //första bokstaven
            
            Console.WriteLine(answer);
        }
    }
}
