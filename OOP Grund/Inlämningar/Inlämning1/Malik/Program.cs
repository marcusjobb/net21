using System;

namespace Inlämninsuppgift_01
{
    class Program
    {
        static void Main()
        {
            //Grundtat
            int account = 500;
            int luckyNumber;
            int gambling;
            int increase;
            bool playAgain = false;
            string input;
            int[] Dice = new int[3];


            do
            {
                playAgain = false;
                increase = 0;
                Console.Clear();

                if (account >= 50)
                {
                    //Fråga om insatsen.
                    DisplayBalance(account);
                    gambling = AskQuestion("Hur mycket pix vill du satsa? ");

                    while (gambling < 50 || gambling > account)
                    {
                        Console.WriteLine($"DU angett fel värde. Ditt insats måste vara minst [50] pix och max [{account }] pix");

                        gambling = AskQuestion("Ange igen hur Hur mycket pix vill du satsa");
                    }
                        
                    //Fråga om lykotal.
                    luckyNumber = AskQuestion("Ange ditt Lyckotal:");

                    while (luckyNumber < 1 || luckyNumber > 6)
                    {
                        Console.WriteLine("Ditt lyckotal måste vara mellan 1 och 6");
                        luckyNumber = AskQuestion("Ange ditt Lyckotal igen:");
                    }

                    //Skapa, vissa och jämföra tärningar nummer
                    Random randNum = new Random();

                    for (int i = 0; i < Dice.Length; i++)
                    {
                        Dice[i] = randNum.Next(1, 7);
                        Console.WriteLine($"Tärning {i + 1} : [{Dice[i]}]");

                        if (luckyNumber == Dice[i])
                        {
                            increase++;
                        }
                    }

                    //Lägga till eller tar bort saldo.
                    if (increase != 0)
                    {
                        gambling *= (increase + 1);
                        account += gambling;
                    }
                    else account -= gambling;

                    DisplayBalance(account);

                    //Fråga om spela igen.
                    if (account >= 50)
                    {

                        Console.WriteLine("Vill du spela igen? Tryck [Y] eller tryck [N] för att avsluta");
                        input = Console.ReadLine();
                        playAgain = (input.ToUpper() == "Y");
                    }
                    else Console.WriteLine("Du får inte spela igen, ditt saldo är mindre än [50] pix");
                }
                else Console.WriteLine("Du får inte spela, ditt saldo är mindre än [50] pix");

            } while (playAgain);

        }

        static int AskQuestion(string question)
        {
            Console.Write(question);
            string inputGambling = Console.ReadLine();
            int.TryParse(inputGambling, out int gambling);

            return gambling;
        }

        static void DisplayBalance(int balance)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Ditt saldo [{balance}] pix");
            Console.WriteLine("---------------------");
        }
    }
}