using System;

namespace NET21_inlämning1
{
    class Program
    {
        //=============Start Main====================
        static void Main()
        {
            //set up our variables
            int bet = 0;
            int minBet = 50;
            Random dice = new Random();
            int startPix = 500;
            int currentPix = startPix;
            bool keepPlaying = true;
            int diceToRoll = 3;
            int[] diceResult = new int[diceToRoll];
            
            

            //clear screen and print instructions
            Console.Clear();
            Console.WriteLine("Hej och välkommen till Fortuna-spelet,");
            Console.WriteLine("");
            Console.WriteLine("Det går till så att du väljer ditt lyckotal och en summa att satsa,");
            Console.WriteLine("efter det så rullar vi tre tärningar och beroende på hur många av dom");
            Console.WriteLine("som blev samma (om någon) så vinner du enligt följande:");
            Console.WriteLine("");
            Console.WriteLine("En tärning samma som ditt tal: dubbla insatsen.");
            Console.WriteLine("Två tärningar samma som ditt tal: tre gånger insatsen.");
            Console.Write("Tre tärningar samma som ditt tal:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" .oO !!JACKPOT!! Oo. ");
            Console.ResetColor();
            Console.WriteLine("FYRA gånger insatsen!");
            Console.WriteLine("(Minsta insats är 50 pix)\n");
            Console.WriteLine("Du börjar med 500 pix.");

            //main game loop
            while (keepPlaying)
            {
                
                //loop to check bet amount to make sure its more then min bet and less then current pixamount
                do
                {
                    bet = GetIntInput("Hur mycket vill du satsa? ");
                    if (bet < minBet)
                    {
                        Console.WriteLine("Minsta insatsen är 50 pix, var god försök igen.");
                    }
                    else if (bet > currentPix)
                    {
                        Console.WriteLine($"Du kan inte satsa fler pix än du har. Ditt nuvarande pix-saldo är {currentPix}.");
                        Console.WriteLine("Var god försök igen.");
                    }

                } while (bet > currentPix || bet < minBet);
                //remove bet from account
                currentPix -= bet;

                //loop to ask for number user wants to bet on, we want to make sure its a number between 1 and 6
                int luckyNumber = 0;
                do
                {
                    luckyNumber = GetIntInput("Vilket är ditt lyckotal? ");
                    //GetIntInput only returns positive numbers so we only need to make sure its 6 or lower
                    if (luckyNumber > 6)
                    {
                        Console.WriteLine("Ditt tal behöver vara mellan 1 och 6, försök igen.");
                    }
                } while (luckyNumber < 0 || luckyNumber > 6);

                //generate dice results and check for match against users number
                int sameNumber = 0;
                for (int i = 0; i < diceToRoll; i++)
                {
                    diceResult[i] = dice.Next(1, 7);
                    if (diceResult[i] == luckyNumber)
                    {
                        sameNumber++;
                    }
                }

                //print the dice result in a pretty way
                PrintDice(diceResult);

                //display result to user and calculate winnings if any and add them to pix account
                if (sameNumber > 0)
                {
                    int winnings = (sameNumber + 1) * bet;
                    currentPix += winnings;
                    Console.WriteLine($"\nGrattis!! Du hade {sameNumber} rätt, du vann {winnings} pix!");
                }
                else
                {
                    Console.WriteLine("\nTyvärr, inga rätt, bättre lycka nästa gånga!");
                }
                Console.WriteLine($"Nuvarand pix-saldo är: {currentPix}");

                //check if user has enough pix to match min bet
                if (currentPix < minBet)
                {
                    Console.WriteLine("\nTyvärr, du har för lite pix på ditt saldo för minsta insatsen, bättre lycka nästa gång.");
                    Console.WriteLine("Hej då och på återseende!");
                    keepPlaying = false;
                }
                else //ask if user wants to play again
                {
                    Console.Write("\nSpela igen ([J]/n)? ");
                    string input = (Console.ReadLine().ToLower()).Trim();
                    if (input == "n" || input == "nej") //make it easy too keep playing, everything besides n and nej starts a new round of the game
                    {
                        Console.WriteLine("Hoppas du har haft det kul! :)");
                        Console.WriteLine("Hej då och på återseende!");
                        keepPlaying = false;
                    }
                }
            }
            //hold code to not end the program to abrubtly
            Console.WriteLine("\nTryck på valfri knapp för att avsluta programmet.");
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
        }
        //============End of Main======================
        
        //==================Start int GetIntInput(string "question") method==============
        //simple method to ask for a int and make sure we can convert the input
        //to int
        static int GetIntInput(string question = "Vänligen ange ett positivt heltal: ")
        {
            bool converted = false;
            int intValue = 0;

            Console.Write(question);
            string input = Console.ReadLine();

            //loop til we have valid conversion
            while (!converted)
            {
                converted = int.TryParse(input, out intValue);

                //we only want a positive value
                if (converted && intValue < 1)
                {
                    converted = false;
                    Console.Write("Vänligen ange ett tal över 0: ");
                    input = Console.ReadLine();
                }
                //if we couldnt convert, ask for a new value
                else if (!converted)
                {
                    Console.Write("Vänligen använd bara siffror och ange ett positivt tal: ");
                    input = Console.ReadLine();
                }
            }
            //return the converted value
            return intValue;
        }
    //==================end int GetIntInput(string "question") method==============

    //==================Start void PrintDice(int[]) method==============
    static void PrintDice(int[] diceResult)
        {
            int numberOfDice = diceResult.Length;
            int diceHeight = 5;
            int diceWidth = 7;
            int spaceBetweenDice = 1;
            int startRow = Console.CursorTop;
            int startColumn = Console.CursorLeft;

            Console.WriteLine("");
            
            for (int dice = 0; dice < numberOfDice; dice++)
            {
                if (dice > 0) startColumn += diceWidth + spaceBetweenDice;                

                for (int diceRow = 0; diceRow < diceHeight; diceRow++)
                {
                    Console.SetCursorPosition(startColumn, startRow+diceRow);
                    if (diceRow == 0) Console.Write("┌─────┐");
                    if (diceRow == 1)                  
                    {
                        if (diceResult[dice] == 1) Console.Write("│     │");
                        else if (diceResult[dice] == 2 || diceResult[dice] == 3) Console.Write("│o    │");
                        else Console.Write("│o   o│");
                    }
                    if (diceRow == 2)
                    {
                        if (diceResult[dice] == 4 || diceResult[dice] == 2) Console.Write("│     │");
                        else if (diceResult[dice] == 6) Console.Write("│o   o│");
                        else Console.Write("│  o  │");
                    }
                    if (diceRow == 3)
                    {
                        if (diceResult[dice] == 3 || diceResult[dice] == 2) Console.Write("│    o│");
                        else if (diceResult[dice] == 1) Console.Write("│     │");
                        else Console.Write("│o   o│");
                    }
                    if (diceRow == 4) Console.Write("└─────┘");
                }
                if (dice == numberOfDice-1) Console.WriteLine("");
            }
        }
        //==================end void PrintDice(int[]) method==============
    }
}
