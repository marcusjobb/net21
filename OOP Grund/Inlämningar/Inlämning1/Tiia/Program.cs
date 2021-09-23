using System;
using System.Threading;

namespace OOP___Inlämningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variablerna
            int saldo = 500;
            int insats = 0;
            int lyckoTal = 0;

            Random rnd = new Random();
            int[] tärning = new int[3]; //skapa en array för en tärning som man senare loopar 3 gånger

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Välkommen till att spela Fortuna!");
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            VisaSaldo(saldo);

            //___________________________________________________________________________________________

            while (saldo >= 50) //så länge användaren har minst 50 pix, körs spelet
            {
                Meddelande("Välj ett lyckotal (1-6): ");
                string inputLyckotal = Console.ReadLine();
                bool lyckotalSiffra = int.TryParse(inputLyckotal, out lyckoTal);

                if (!lyckotalSiffra)
                {
                    Console.WriteLine("Hoppsan.. Ange en siffra!");
                    continue;
                }

                if (lyckoTal < 1 || lyckoTal > 6)
                {
                    Console.WriteLine("Du angav ett felaktigt lyckotal!");
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Lyckotalet: {lyckoTal}");
                }

                //___________________________________________________________________________________________


                while (true) //skapa en while loop där användaren anger insatsen
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Meddelande("Hur mycket vågar du satsa? (min 50 pix) ");
                    string inputSats = Console.ReadLine();
                    bool insatsSiffra = int.TryParse(inputSats, out insats);

                    if (insatsSiffra) //kontrollera att insatsen som matas in är en siffra
                    {
                        if (insats < 50)
                        {
                            Meddelande("Kom igen! Lite mer vågar du väl satsa? ;)");
                            continue;
                        }
                        else if (insats > saldo)
                        {
                            Meddelande("Du har för lite pix! Satsa mindre!");
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Du har satsat {insats} pix");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("NU KÖR VI! LYCKA TILL!!");
                            Console.WriteLine("________________________");

                            SekundRäknaren();
                            Console.WriteLine();
                            break;
                        }
                    }
                    else
                    {
                        Meddelande("Hoppsan.. Ange en siffra!");
                    }
                }

                //___________________________________________________________________________________________

                for (int i = 0; i < 3; i++) //loopen för tärningen som kastas 3 gånger
                {
                    tärning[i] = rnd.Next(1, 7);
                    Console.WriteLine(tärning[i]);
                    Thread.Sleep(250);
                }

                bool förstRätt = tärning[0] == lyckoTal;
                bool andraRätt = tärning[1] == lyckoTal;
                bool tredjeRätt = tärning[2] == lyckoTal;

                saldo -= insats; //innan resultatet kontrolleras, dras insatsen från saldot

                //___________________________________________________________________________________________

                for (int i = 0; i < 1; i++) //kontrollera ifall användaren har 1, 2 eller 3 rätta
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    if (förstRätt || andraRätt || tredjeRätt)
                    {
                        if (förstRätt && andraRätt && tredjeRätt)
                        {
                            saldo += insats * 4;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("!!JACKPOT!! Alla tre rätt!");
                            Console.WriteLine($"Du vann {insats * 4} pix!");
                        }
                        else if (förstRätt && andraRätt || förstRätt && tredjeRätt || andraRätt && tredjeRätt)
                        {
                            saldo += insats * 3;
                            Console.WriteLine($"Wow! TVÅ rätt! Du vann {insats * 3} pix!");
                        }
                        else
                        {
                            saldo += insats * 2;
                            Console.WriteLine($"Wow! Ett rätt! Du vann {insats * 2} pix!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Åh nej! Ingen vinst!");
                    }
                }
                //___________________________________________________________________________________________

                Console.ForegroundColor = ConsoleColor.Cyan;
                VisaSaldo(saldo);

                if (saldo >= 50) //en möjlighet att fortsätta spelet, så länge användaren har 50 pix eller mer 
                {
                    Meddelande("Sugen på en runda till? (ja/nej) ");
                    string spelaIgen = Console.ReadLine().ToLower();

                    if (spelaIgen == "ja")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (spelaIgen == "nej")
                    {
                        TackFörSpelet();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Svara 'ja' eller 'nej'");
                        spelaIgen = Console.ReadLine().ToLower();
                        Console.Clear();
                    }
                }
                //___________________________________________________________________________________________

                if (saldo < 50) //spelet avslutas när användaren har för lite pix
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("---------GAME OVER------------");
                    Console.WriteLine("-----du har för lite pix------");
                    Console.WriteLine("_______________________________");

                    TackFörSpelet();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                }
                //___________________________________________________________________________________________

                VisaSaldo(saldo);
            }
        }

        private static void TackFörSpelet()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tack för att du spelade!");
        }

        private static void VisaSaldo(int saldo)
        {
            Console.WriteLine($"Ditt saldo är {saldo} pix");
        }

        private static void SekundRäknaren()
        {
            Console.Write("Ready..");
            Thread.Sleep(500);
            Console.Write(".set..");
            Thread.Sleep(500);
            Console.Write(".GO!!");
            Thread.Sleep(500);
        }

        private static void Meddelande(string message)
        {
            Console.WriteLine();
            Console.Write(message);
        }
    }
}


