using System;

namespace Oh_fortuna1
{
    class Program
    {
        static void Main(string[] args)

        {
            int dice1 = 0; // deklarerade variabler
            int dice2 = 0;
            int dice3 = 0;
            int pix = 500;
            int luckyNum = 0;
            int bet;
            string input;


            Console.WriteLine("Du har " + pix + " pix att betta med. Du kan betta som minst 50 pix och som mest din totala summa pix. ");

            while (pix >= 50) //while-loop som håller igång spelet när användare vill och pix är lika eller över 50.
            {

                Console.WriteLine("Skriv in hur många pix du vill betta: ");
                bool stringTry;
                inputToInt(out bet, out stringTry); // metod som gör om input till int
                if (bet >= 50)
                {
                    if (bet <= pix)
                    {
                        pix -= bet;
                    }
                    else
                    {
                        Console.WriteLine("Du har bettat mer pix än du har. Vänligen försök igen.");
                        continue;
                    }

                }
                else if (!stringTry)
                {
                    Console.WriteLine("Vänligen ange ett tal.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Du har bettat mindre pix än 50. Vänligen försök igen.");
                    continue;
                }
                bool dummy = true;
                while (dummy) //Dummy while sats för att hålla igång sekvens till vi användre break
                {
                    bool stringTryAgain;
                    Console.WriteLine("Skriv in ett lyckonummer mellan 1 och 6: ");
                    inputToInt(out luckyNum, out stringTryAgain); // metod som gör om input till int
                    if (!stringTryAgain)
                    {

                        Console.WriteLine("Vänligen ange ett tal.");
                        continue;
                    }
                    else
                    {
                        if (luckyNum < 1)
                        {
                            Console.WriteLine("Vänligen ange ett tal mellan 1 och 6");
                            continue;
                        }
                        else if (luckyNum > 6)
                        {
                            Console.WriteLine("Vänligen ange ett tal mellan 1 och 6");
                            continue;
                        }

                        else
                        {

                            dice1 = RandomMethod(); // metod för randomisering av nummer.

                            dice2 = RandomMethod();

                            dice3 = RandomMethod();

                            Console.WriteLine("Tärningarna rullar: " + dice1 + " " + dice2 + " " + dice3);
                            break;
                        }
                    }
                }




                // nedan skapar en multipel som blir 2,3,4 eller 0 beroende på utfall av dices.

                int winMult = 1;
                if (dice1 == luckyNum)
                {
                    winMult += 1;
                }
                if (dice2 == luckyNum)
                {
                    winMult += 1;
                }
                if (dice3 == luckyNum)
                {
                    winMult += 1;
                }
                else if (winMult < 2)
                {
                    winMult = 0;
                }


                pix += (bet * winMult);

                Console.WriteLine("Du har " + pix + " pix kvar.");
                if (pix >= 50)
                {
                    do
                    {
                        Console.WriteLine("Vill du spela igen ?(Y/N)");
                        input = Console.ReadLine();


                    } while (input != "Y" && input != "N");

                    if (input == "Y")
                    {
                        continue;
                    }
                    else if (input == "N")
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Du har för lite pix för att spela igen. Programmet avslutas.");
                }


                pix = 0;




            }







        }

        private static void inputToInt(out int bet, out bool stringTry)
        {
            string betStr = Console.ReadLine();
            stringTry = int.TryParse(betStr, out bet);
        }

        private static int RandomMethod()
        {

            int ran;
            Random rand = new Random();
            ran = rand.Next(1, 7);
            return ran;
        }
    }

}
