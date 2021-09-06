using System;

namespace ForLoopDemo
{
    class Program
    {
        static void Main()
        {
            for (int counter = 10; counter > 0; counter--)
            {
                if (counter == 4) continue;
                Console.WriteLine(counter);
            }
        }
    }
}
