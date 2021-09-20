using System;

namespace Play_n_Pay_inlämning
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPix = 500; // Användares Saldo
            int dices = 3;// Antal tärningar
            Random rnd = new Random();
            int matchingNumbers = 0;
            int bet = 0;
            string playAgain;
            int timesPlayed = 0;



            Console.Write("Välkommen till casino Play'n'Pay. ");
            while (true)
            {
                if (timesPlayed > 0)
                {
                    // Frågar om användaren vill spela igen
                    Console.Write("Vill du spela igen? Mata in n (nej) eller j (ja): ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "n")
                    {
                        Console.WriteLine("Välkommen åter!");
                        break;
                    }
                    else if (playAgain == "j")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("System error 404: dumheter found.");
                        continue;
                    }
                }

                timesPlayed++;

                //Frågar hur mycket användaren vill satsa
                Console.Write(" Ditt saldo är " + playerPix + ", Hur mycket vill du satsa? (minst 50 pix): ");
                string inputB = Console.ReadLine();
                int.TryParse(inputB, out bet);

                //Kollar så att talet är godkänt
                if (bet < 50)
                {
                    timesPlayed = 0;
                    Console.WriteLine("Du måste minst satsa 50 pix");
                    continue;
                }
                if (bet > playerPix)
                {
                    timesPlayed = 0;
                    Console.WriteLine("Så mycket pengar har du inte, försök igen");
                    continue;
                }

                //Användaren får skriva in sitt lyckotal
                Console.Write("Skriv in ditt lyckotal mellan 1-6: ");
                string inputL = Console.ReadLine();
                int.TryParse(inputL, out int luckyNumber);

                //kollar så att talet är godkänt
                if (luckyNumber < 1)
                {
                    timesPlayed = 0;
                    Console.WriteLine("Talet måste vara mellan 1-6");
                    continue;
                }
                if (luckyNumber > 6)
                {
                    timesPlayed = 0;
                    Console.WriteLine("Talet måste vara mellan 1-6");
                    continue;
                }

                playerPix -= bet;

                //slumpa tärningar
                int dice = rnd.Next(1, 7);

                Console.WriteLine("Tärningarna landade på:");

                for (int i = 0; i < dices; i++)
                {
                    dice = rnd.Next(1, 7);
                    Console.WriteLine(dice);

                    if (luckyNumber == dice)
                    {
                        matchingNumbers++;
                    }
                }

                //Kolla om tärningarna matchade användarens nummer
                if (matchingNumbers > 0)
                {
                    Console.WriteLine("Bra gissning! Du vann: " + (bet + matchingNumbers * bet));
                    playerPix += bet * matchingNumbers + bet; // Min riktigt bra formel för att räkna ut vinst
                }
                else
                {
                    Console.WriteLine("Tyvärr ingen siffra matchade");
                }

                // Återställ så inte värderna följer med till nästa runda
                matchingNumbers = 0;
                bet = 0;

                if (playerPix < 50)
                {
                    Console.WriteLine("Aj då, nu är det tomt på kontot. Bättre lycka nästa gång!");
                    break;
                }
            }
        }
    }
}
