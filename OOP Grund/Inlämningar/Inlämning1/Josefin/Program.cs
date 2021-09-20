using System;
using System.Collections.Generic;
using System.Threading;

namespace Oh_Fortuna_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int userPix = 500;

            int userLuckyNum = 0;
            bool isInputGuessNumber;
            string inputStringGuess;

            int userBet = 0;
            bool isInputBetNumber;
            string inputStringBet;

            int dice = 0;

            int correctGuesses = 0;

            while (userPix > 50) // spelet körs så länge som spelaren har minst 50 pix
            {
                correctGuesses = 0;  // återställer antal korrekta gissningar inför varje omgång

                Console.WriteLine("Nu spelar vi Oh Fortuna! Skåda in i stjärnorna och välj ett lyckotal mellan 1-6...");
                inputStringGuess = Console.ReadLine();
                isInputGuessNumber = int.TryParse(inputStringGuess, out userLuckyNum);

                if (!isInputGuessNumber)  // om det inte är sant att input är en siffra
                {
                    wrongMessage("Ange en siffra!");
                    continue;
                }

                if (userLuckyNum <= 6 && userLuckyNum >= 1)
                {
                    Console.WriteLine("Du valde lyckonummer: " + userLuckyNum + "... Nu kör vi!!!");
                }
                else
                {
                    wrongMessage("Felaktigt värde! Välj ett tal mellan 1-6...");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Ange din insats... Du får ej satsa mer än " + userPix + " Pix.");
                    inputStringBet = Console.ReadLine();
                    isInputBetNumber = int.TryParse(inputStringBet, out userBet);

                    if (!isInputBetNumber)
                    {
                        wrongMessage("Ange en siffra!");
                        continue;
                    }

                    if (userBet > userPix)
                    {
                        wrongMessage("Satsa en mindre summa!");
                        continue;
                    }
                    else if (userBet < 50)
                    {
                        wrongMessage("Satsa mer, snåljåp!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Modig satsning! Nu kör vi...");
                        Thread.Sleep(1000);  // pausar programmet för ökad spänning..!
                        break;
                    }
                }

                for (int i = 0; i < 3; i++) // en tärning som kastas tre gånger per omgång
                {
                    dice = rnd.Next(1, 7);
                    Console.WriteLine("Tärningen visar: " + dice);

                    if (dice == userLuckyNum) // räknar antal korrekta gissningar/ korrekta tärningar
                    {
                        correctGuesses++;
                    }
                }

                switch (correctGuesses)
                {
                    case 1:
                        happyMessage("Grattis, ett rätt!");
                        userPix = userBet * (correctGuesses + 1) + userPix;  // satsningen gånger antal korrekta gissningar+1 + användarens nuvarande pix
                        Console.WriteLine("Du har nu " + userPix + " Pix!");
                        break;
                    case 2:
                        happyMessage("Grattis, TVÅ rätt!");
                        userPix = userBet * (correctGuesses + 1) + userPix;
                        Console.WriteLine("Du har nu " + userPix + " Pix!");
                        break;
                    case 3:
                        happyMessage("WOHOO, ALLA RÄTT!!!");
                        userPix = userBet * (correctGuesses + 1) + userPix;
                        Console.WriteLine("Du har nu " + userPix + " Pix!");
                        break;
                    default:
                        wrongMessage("Sorry, inga rätt...");
                        userPix -= userBet;
                        Console.WriteLine("Du har nu " + userPix + " Pix kvar.");

                        if (userPix < 50)
                        {
                            wrongMessage("Du förlorade, spelet är slut.");
                        }
                        break;
                }

                if (userPix > 50)
                {
                    Console.WriteLine("Vågar du fortsätta spelet? Svara 'Ja' eller 'Nej'. På ditt saldo finns: " + userPix + " Pix.");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "Ja")
                    {
                        Console.Clear();  // rensar konsollen mellan varje omgång
                        continue;
                    }
                    else if (userAnswer == "Nej")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Svara 'Ja' eller 'Nej'");
                        userAnswer = Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }

        private static void wrongMessage(string message) // metod för felmeddelanden
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void happyMessage(string message) // metod för glada meddelanden
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

