namespace ListExempel // Hus
{
    using System;
    using System.Collections.Generic;

    class Program // Rum
    {
        static void Main() // Möbler
        {
            int[] extras= new int[] { 32, 98, 76, 53 };

            List<int> nuffror = new List<int>(extras)
            {
                10,
                22,
                23,
                11,
                95,
                45
            };
            nuffror.Insert(1, 55);
            nuffror.RemoveAt(2);
            nuffror.Remove(10);

            nuffror.Sort();
            nuffror.Add(44);


            foreach (var nuffra in nuffror)
            {
                Console.WriteLine(nuffra);
            }
            Console.WriteLine("Finns nummer 22 i listan? " + nuffror.Contains(22));

            Console.WriteLine();
        }
    }
}
