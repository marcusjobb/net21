using System;

namespace OOPDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceGame dc = new DiceGame(100);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dc.RollDice());
            }

        }
    }
}
