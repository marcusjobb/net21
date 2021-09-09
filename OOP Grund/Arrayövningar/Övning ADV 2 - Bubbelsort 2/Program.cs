namespace Övning_ADV_2___Bubbelsort_2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // skapa array för 10 tal
            int[] numbers = new int[10];
            // Flagga för att se om arrayen ändrats
            // om den inte ändrats vid en iteration då är allt
            // sorterat
            bool changed;
            // Instansiera randomizer
            Random rnd = new Random();
            // lägg till slumpade värden i listan
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = rnd.Next(0, 100);
            }

            do
            {
                // nollställ flaggan 
                changed = false;
                // loopa igenom alla värden
                for (int pos = 0; pos < numbers.Length - 1; pos++)
                {
                    for (int jmf = 0; jmf < numbers.Length - pos - 1; jmf++)
                    {
                        // om värdet är större än nästa värde
                        if (numbers[jmf] > numbers[jmf + 1])
                        {
                            // swap
                            int tmp = numbers[jmf];
                            numbers[jmf] = numbers[jmf + 1];
                            numbers[jmf + 1] = tmp;
                            changed = true;
                        }
                    }
                }
            } while (changed);

            // skriv ut alla talen
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

