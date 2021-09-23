using System;
using System.Threading;

namespace OhFortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            int pix = 500;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("* * * * * VÄLKOMMEN * * * * *");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" * * * *  VÄLKOMMEN  * * * * ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("* * * * * VÄLKOMMEN * * * * *");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" * * * *  VÄLKOMMEN  * * * * ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("* * * * * VÄLKOMMEN * * * * *");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" * * * *  VÄLKOMMEN  * * * * ");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Thread.Sleep(800); Console.Write('O'); Thread.Sleep(800); Console.Clear(); Console.Write(" H"); Thread.Sleep(800); Console.Clear(); Console.Write("   "); Thread.Sleep(800); Console.Clear(); Console.Write("   F"); Thread.Sleep(800); Console.Clear(); Console.Write("    O"); Thread.Sleep(800); Console.Clear(); Console.Write("     R"); Thread.Sleep(800); Console.Clear(); Console.Write("      T"); Thread.Sleep(800); Console.Clear(); Console.Write("       U"); Thread.Sleep(800); Console.Clear(); Console.Write("        N"); Thread.Sleep(800); Console.Clear(); Console.Write("         A"); Thread.Sleep(800); Console.Clear(); Console.WriteLine("OH FORTUNA"); Thread.Sleep(800);

            Console.WriteLine();

            bool done = false;
            while (!done && pix > 0)
            {
                Console.WriteLine("Vill du spela en runda? y/n"); // Kommer igen om de skriver annat än y eller n...
                string answer = Console.ReadLine().ToLower();
                if (answer == "n" || pix < 50)
                {
                    Console.WriteLine("Välkommen åter.");
                    done = true;
                }
                else if (answer == "y" && pix > 50)
                {
                    Console.WriteLine($"Du har {pix} pix, satsa minst 50!");

                    int userSatsning = 0;
                    try
                    {
                        userSatsning = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + "Skriva bara giltiga värden, dvs heltal!");
                    }

                    while (userSatsning > pix || userSatsning < 50) // OM INPUT EXAKT PIX - GÅR IN I LOOPEN :(
                    {
                        Console.WriteLine("Du kan inte satsa mer än du har eller under 50! Satsa igen!");
                        try
                        {
                            userSatsning = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message + "Skriva bara giltiga värden, dvs heltal!");
                        }
                    }

                    if (userSatsning <= pix)
                    {
                        pix -= userSatsning;
                        Console.WriteLine("Du satsade: " + userSatsning);

                        Console.WriteLine("Välj ett lyckotal mellan 1 och 6!");

                        int userChoice = 0;
                        try
                        {
                            userChoice = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message + "Använd bara 1, 2, 3, 4, 5 eller 6!");
                        }

                        while (userChoice < 1 || userChoice > 6) // mindre än ett ELLER större än 6
                        {
                            Console.WriteLine("Välj något mellan 1 och 6!");
                            try
                            {
                                userChoice = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message + " Använd bara 1, 2, 3, 4, 5 eller 6!");
                            }
                        }
                        if (userChoice >= 1 && userChoice <= 6) // större än ett OCH mindre än sex
                        {
                            Console.WriteLine("Du valde: " + userChoice);

                            Random dice1 = new Random();
                            int dice1number = dice1.Next(1, 7);

                            Random dice2 = new Random();
                            int dice2number = dice1.Next(1, 7);

                            Random dice3 = new Random();
                            int dice3number = dice1.Next(1, 7);
                            Console.WriteLine($"Tärningarna visar {dice1number}, {dice2number} och {dice3number}");

                            // TRE (ALLA) TÄRNINGAR VISADE RÄTT:
                            if (userChoice == dice1number && userChoice == dice2number && userChoice == dice3number)
                            {
                                Console.WriteLine("Alla tärningar visade rätt! Du får fyra gånger insatsen, dvs: " + userSatsning * 4);
                                pix += (userSatsning * 4);
                                Console.WriteLine("Det du har nu är: " + pix);
                            }

                            // TVÅ TÄRNINGAR VISADE RÄTT
                            else if (userChoice == dice1number && userChoice == dice2number || userChoice == dice1number && userChoice == dice3number || userChoice == dice2number && userChoice == dice1number || userChoice == dice2number && userChoice == dice3number || userChoice == dice3number && userChoice == dice1number || userChoice == dice3number && userChoice == dice2number)
                            {
                                Console.WriteLine("Två tärningar visade rätt, du får tre gånger insatsen, dvs: " + userSatsning * 3);
                                pix += (userSatsning * 3);
                                Console.WriteLine("Det du har nu är: " + pix);
                            }

                            // EN TÄRNING VISADE RÄTT:
                            else if (userChoice == dice1number || userChoice == dice2number || userChoice == dice3number)
                            {
                                Console.WriteLine("En tärning visade rätt. Du får dubbla insatsen, dvs: " + userSatsning * 2);
                                pix += (userSatsning * 2);
                                Console.WriteLine("Det du har nu är: " + pix);
                            }

                            // INGEN TÄRNING VISADE RÄTT:
                            else if (userChoice != dice1number && userChoice != dice2number && userChoice != dice3number)
                            {
                                Console.WriteLine("Ingen tärning visade ditt lyckotal :(");
                                Console.WriteLine("Du har: " + pix);
                            }
                        }
                    }

                    if (pix < 50)
                    {
                        done = true;
                        Console.WriteLine("Nu är du under 50 pix och får inte spela längre. Välkommen åter.");
                    }
                }
                else
                {
                    Console.WriteLine("Svrara y eller n");
                }
            }
        }
    }
}
