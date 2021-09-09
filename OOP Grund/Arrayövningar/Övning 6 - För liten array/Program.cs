namespace Övning_6___För_liten_array
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Instansiera randomizer
            Random rnd = new Random();
            // skapa array för 10 tal
            int[] nuffror = new int[10];
            // lägg till slumpade värden i listan
            for (int i = 0; i < 10; i++)
            {
                nuffror[i] = rnd.Next(0, 100);
            }
            // skapa temporär array för 20 tal
            int[] tmp= new int[20];
            // kopiera nuffer arrayen till temp
            Array.Copy(nuffror, tmp, nuffror.Length);
            // kopiera tmp arrayen till nuffror
            // egentligen döp om tmp till nuffror
            nuffror = tmp;

            // loopa igenom 5 värden och stoppa in i listan
            for (int i = 10; i < 16; i++)
            {
                nuffror[i] = rnd.Next(0, 100);
            }

            // skriv ut listan
            foreach (var nuffra in nuffror)
            {
                Console.WriteLine(nuffra);
            }
            // värden som inte fyllts på blir noll vid utskrift
        }
    }
}
