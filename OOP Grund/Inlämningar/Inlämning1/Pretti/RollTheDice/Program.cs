using System;

namespace PlaynPay
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            double Maxvalue = 500;

            double enemyPoints = Maxvalue;
            double playerPoints = Maxvalue;

            int random = new Random().Next(1, 6);

            int[] dice = new int[5];
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine("Press any key to roll the dice."); // message telling to press any key to roll the dice

                Console.ReadKey();

                playerRandomNum = random;
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random;
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else 
                {
                    Console.WriteLine("Draw!");
                }

                   Console.WriteLine("The score is now - Player : " + playerPoints + "pix" + " . Enemy: " + enemyPoints + "pix" + ".");
                Console.WriteLine();
            }

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");

            }else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            Console.ReadKey();
        }
    }
}
