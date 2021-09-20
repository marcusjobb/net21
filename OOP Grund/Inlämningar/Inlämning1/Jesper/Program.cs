using System;

namespace Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO: Dela upp i mindre metoder. Återanvända strängar.
            Console.ForegroundColor = ConsoleColor.Red;
            //-------------------------------------------------------------------------------------------------------------
            // Sektion för ASCII grafik. Dessa sektioner är bäst att minimera. Tärningar hämtade från: "https://www.asciiart.eu/miscellaneous/dice - Art by valkyrie" och sedan modifierade.
            // "Fortuna" grafiken är tänkt att användas som en bild i en meny. Jag har dock gjort en ful-lösning, då jag skriver ut denna "bild" upprepade gånger efter Console.Clears().
            // Det hade varit bättre att få till en permanent meny, eller en funktion som skriver ut hela menyn.
            //-------------------------------------------------------------------------------------------------------------
            string fortunaGrafik = @"
 /$$$$$$$$                    /$$                                  
| $$_____/                   | $$                                  
| $$     /$$$$$$   /$$$$$$  /$$$$$$   /$$   /$$ /$$$$$$$   /$$$$$$ 
| $$$$$ /$$__  $$ /$$__  $$|_  $$_/  | $$  | $$| $$__  $$ |____  $$
| $$__/| $$  \ $$| $$  \__/  | $$    | $$  | $$| $$  \ $$  /$$$$$$$
| $$   | $$  | $$| $$        | $$ /$$| $$  | $$| $$  | $$ /$$__  $$
| $$   |  $$$$$$/| $$        |  $$$$/|  $$$$$$/| $$  | $$|  $$$$$$$
|__/    \______/ |__/         \___/   \______/ |__/  |__/ \_______/
                                                                   

";
            string tärningGrafik1 = @"
                                 _______ 
                      ______    | .   . |\
                     /     /\   |   .   |.\
                    /  '  /  \  | .   . |.'|
                   /_____/. . \ |_______|.'|
                   \ . . \    /  \ ' .   \'|
                    \ . . \  /    \____'__\|
                     \_____\/  ______
                              /     /\
                             /  '  /  \
                            /_____/. . \
                            \ . . \    /  
                             \ . . \  /
                              \_____\/";
            string tärningGrafik2 = @"

                                   ____
                        ____      /\' .\
                       /\' .\    /: \___\
                      /: \___\   \' / . /
                      \' / . / ___\/___/
                       \/___/ / .  /\
                             /____/..\
                             \'  '\  /
                              \'__'\/
                                                             ";

            string tärningGrafik3 = @"


                      ____    
                     /\' .\    _____     ____
                    /: \___\  / .  /\   /\' .\
                    \' / . / /____/..\ /: \___\
                     \/___/  \'  '\  / \' / . /
                              \'__'\/   \/___/  ";
            //-------------------------------------------------------------------------------------------------------------
            // Slut på grafik
            //-------------------------------------------------------------------------------------------------------------


            //-------------------------------------------------------------------------------------------------------------
            //  Variabler utanför loop.
            //-------------------------------------------------------------------------------------------------------------
            // Saldo med valuta.
            int pixSaldo = 500;
            bool spelaIgen = true;
            string spelaIgenSvar = "";

            //Huvudloop för hela programmet.
            while (pixSaldo >= 50 && spelaIgen)
            {

                
                int pixInsats = 0;
                int gissning = 0;

                //-------------------------------------------------------------------------------------------------------------
                //  Sektion för random samt tärningar
                //-------------------------------------------------------------------------------------------------------------
                Random random = new Random();
                
                //Tre tärningar skapas och kopplas till random funktionen. Slumpat tal mellan 1 och 7 (vilket motsvarar 1-6 på en tärning, då det är UPP till 7).
                int tärning1 = random.Next(1, 7);
                int tärning2 = random.Next(1, 7);
                int tärning3 = random.Next(1, 7);
                
                int[] tärningar = { tärning1, tärning2, tärning3 };
                // Räknare för att hålla koll på hur många tärningar som användaren gissade rätt på.
                int tärningKorrekt = 0;



                Console.WriteLine(fortunaGrafik);
                Console.WriteLine($"Ditt nuvarande saldo är: [ { pixSaldo} ] pix!");

                //-------------------------------------------------------------------------------------------------------------
                //  Sektion för att ta emot användarens satsning. 
                //-------------------------------------------------------------------------------------------------------------
                //  TODO: Texten i if-satserna hamnar ovanför den existerande texten på grund av console.clear.
                //  Kan lösas via en console.readkey innan en clear på slutet, för att låta användaren hinna läsa meddelandet innan clear, men då löper programmet inte på lika bra.
                Console.WriteLine("Hur många pix vill du satsa?\nMinsta insats: 50px");
                while (!int.TryParse(Console.ReadLine(), out pixInsats) || pixInsats <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(fortunaGrafik);
                    Console.WriteLine("Du angav inte en gilltig siffra. Siffran måste vara positiv. Försök igen: ");
                }
                
                if (pixInsats > pixSaldo)
                {
                    Console.Clear();
                    Console.WriteLine($"Du kan inte satsa mer än vad du har. Du har: [ {pixSaldo} ]");
                    
                }
                else if (pixInsats < 50)
                {
                    Console.Clear();
                    Console.WriteLine("Du behöver satsa minst 50px!");
                }

                //-------------------------------------------------------------------------------------------------------------
                //  Sektion för att hantera tärningarna, samt användarens lyckotal. Hänger ihop med if-satsen ovan.
                //-------------------------------------------------------------------------------------------------------------
                else
                {
                    Console.Clear();
                    Console.WriteLine(fortunaGrafik);
                    Console.WriteLine($"Okej! Du har valt att satsa: [ {pixInsats} ]");
                    //  Insatsen tas bort från saldot.
                    pixSaldo -= pixInsats;
                    Console.WriteLine("Tre tärningar ska rullas. Gissa på ditt lyckotal och se hur många tärningar som matchar!\nVälj ditt lyckotal mellan 1-6!");
                    //  Loop körs medan Try.Parse är falsk, eller gissning är lika med eller under 0, eller när gissning är större än 6. Låter användaren försöka upprepade gånger.
                    while (!int.TryParse(Console.ReadLine(), out gissning) || gissning <= 0 || gissning > 6)
                    {
                        Console.Clear();
                        Console.WriteLine(fortunaGrafik);
                        Console.WriteLine("Du angav inte en gilltig siffra.\n\nKom ihåg att siffran inte kan vara större än 6 eller mindre än 0, då vi spelar med vanliga tärningar.\nFörsök igen!");
                        Console.Write("\nSkriv in ditt lyckotal: ");
                    }
                    Console.Clear();

                    //-------------------------------------------------
                    //  ASCII tärningar skrivs ut för skojs skull.
                    //-------------------------------------------------
                    string[] tärningGrafik = { tärningGrafik1, tärningGrafik2, tärningGrafik3 };
                    Console.CursorVisible = false;
                    for (int i = 0; i < tärningGrafik.Length; i++)
                    {
                        Console.WriteLine(fortunaGrafik);
                        Console.WriteLine(tärningGrafik[i]);
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                    }
                    Console.CursorVisible = true;
                    Console.WriteLine(fortunaGrafik);
                    //-------------------------------------------------

                    Console.WriteLine($"Du valde *{gissning}* som ditt lyckonummer.\n\nTärningarna rullade: [{tärning1}] [{tärning2}] [{tärning3}]");
                    //  For loop som går igenom tärningar-vektorns alla element, dvs alla separata tärningar. Jämför nuvarande indexplats (tärning) med variabeln tal.
                    //  För varje matchad tärning så ökas tärningKorrekt variabeln.
                    for (int i = 0; i < tärningar.Length; i++)
                    {
                        if (tärningar[i] == gissning)
                        {
                            tärningKorrekt++;
                        }
                    }

                    //-------------------------------------------------------------------------------------------------------------
                    //  If/else-if satser som tar hand om vinsterna, beroende på hur många korrekta gissningar användaren gjorde.
                    //-------------------------------------------------------------------------------------------------------------
                    if (tärningKorrekt > 0)
                    {

                        Console.WriteLine("Grattis! Tärningar som matchade din gissning: " + tärningKorrekt);
                        
                        if (tärningKorrekt == 1)
                        {
                            pixSaldo += pixInsats * 2;
                            Console.WriteLine("Du vann: " + pixInsats * 2 + " pix!");
                        }
                        else if (tärningKorrekt == 2)
                        {
                            pixSaldo += pixInsats * 3;
                            Console.WriteLine("Du vann: " + pixInsats * 3 + " pix!");
                        }
                        else if (tärningKorrekt == 3)
                        {
                            pixSaldo += pixInsats * 4;
                            Console.WriteLine("Du vann: " + pixInsats * 4 + " pix!");
                        }

                        //  Fråga om användaren vill spela igen.
                        Console.WriteLine($"\nDitt nuvarande saldo är: [ { pixSaldo} ]");

                        while (spelaIgenSvar != "J" || spelaIgenSvar != "N")
                        {
                            Console.WriteLine("\nVill du spela igen? J/N");
                            spelaIgenSvar = Console.ReadLine().ToUpper();
                            if (spelaIgenSvar == "J" || spelaIgenSvar == "JA")
                            {
                                Console.Clear();
                                break;
                            }
                            else if (spelaIgenSvar == "N" || spelaIgenSvar == "NEJ")
                            {
                                Console.Clear();
                                Console.WriteLine(fortunaGrafik);
                                Console.WriteLine("Välkommen åter!\nProgrammet avslutas.");
                                Console.ReadKey();

                                spelaIgen = false;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(fortunaGrafik);
                                Console.WriteLine($"Vänligen skriv in \"J\" för att spela igen, eller \"N\" för att avsluta programmet.\nDitt nuvarande saldo är: [ { pixSaldo} ]");
                            }

                        }

                    }

                    //-------------------------------------------------------------------------------------------------------------
                    //  Sektion som körs vid en förlust.
                    //-------------------------------------------------------------------------------------------------------------
                    else
                    {

                        Console.WriteLine($"\nÅh nej, du förlorade {pixInsats} pix!\n\nDitt nuvarande saldo är: [ { pixSaldo} ]");
                        // Om pix är över 50, få val om att spela igen. Annars avsluta direkt.
                        if (pixSaldo >= 50)
                        {
                            while (spelaIgenSvar != "J" || spelaIgenSvar != "N")
                            {
                                Console.WriteLine("\nVill du spela igen? J/N");
                                spelaIgenSvar = Console.ReadLine().ToUpper();
                                if (spelaIgenSvar == "J" || spelaIgenSvar == "JA")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else if (spelaIgenSvar == "N" || spelaIgenSvar == "NEJ")
                                {
                                    Console.Clear();
                                    Console.WriteLine(fortunaGrafik);
                                    Console.WriteLine("Välkommen åter!\nProgrammet avslutas.");
                                    Console.ReadKey();
                                    spelaIgen = false;
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(fortunaGrafik);
                                    Console.WriteLine($"Vänligen skriv in \"J\" för att spela igen, eller \"N\" för att avsluta programmet.\nDitt nuvarande saldo är: [ { pixSaldo} ]");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDitt saldo understeg 50. Programmet avslutas nu. \n\nVälkommen åter!");
                            Console.ReadKey();
                        }

                    }


                }

            }
          
        }

    }
}
