using System;

namespace fortuna
{
    class Program
    {
        static void Main(string[] args)
        {

            int Plånboken = 500;
            int MinstaSatsning = 50;
            int egenSatsning;
            int vinstSumma;
            Random rnd = new();

            while (true)
            {

                Console.Write(" Hur mycket pengar vill du satsa? Minsta summan är 50 pix:  ");
                egenSatsning = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (Plånboken < MinstaSatsning)

                    {
                        Console.WriteLine(" du har inte tillräckligt med pengar");
                        Environment.Exit(0);
                        continue;

                    }
                    else if (egenSatsning > Plånboken)

                    {
                        Console.WriteLine(" du kan inte satsa mer än vad du har");
                        continue;
                    }

                    else if (egenSatsning < MinstaSatsning)

                    {
                        Console.WriteLine($"Du måste satsa mer än {MinstaSatsning}");
                        continue;
                    }
                    else
                    {
                        Plånboken -= egenSatsning;
                        Console.Write($"Du har  {Plånboken} pix kvar.");
                        Console.ReadLine();
                        break;
                    }
                }





                Console.Write(" Välj ditt lyckotal(1 - 6):");
                int Lyckotal;
                while (true)
                {

                    if (!int.TryParse(Console.ReadLine(), out Lyckotal))
                    {
                        Console.WriteLine(" du skrev fel värde");
                        continue;
                    }

                    if (Lyckotal < 1 || Lyckotal > 6)
                    {
                        Console.WriteLine("du angav fel siffra");
                        continue;
                    }
                    break;
                }

                var randomNumber1 = rnd.Next(1, 7);
                var randomNumber2 = rnd.Next(1, 7);
                var randomNumber3 = rnd.Next(1, 7);

                int Resultat = 0;

                Console.WriteLine();



                if
                    (randomNumber1 == Lyckotal)
                {
                    Resultat++;
                    Console.WriteLine($"Din vinstsumma blir {egenSatsning * 2}");
                }

                if
                    (randomNumber2 == Lyckotal)
                {
                    Resultat++;
                    Console.WriteLine($"Din vinstsumma blir {egenSatsning * 3}");
                }

                if
                    (randomNumber3 == Lyckotal)
                {
                    Resultat++;
                    Console.WriteLine($"Din vinstsumma blir{egenSatsning * 4}");
                }



                if (Resultat == 0)
                {
                    Console.WriteLine($"du förlorar din {egenSatsning}");
                }
                else
                {
                    var multiplier = 1 + Resultat;
                    vinstSumma = egenSatsning * multiplier;

                    Console.WriteLine($"du vann {vinstSumma} pix");
                    Console.WriteLine($"du har {Plånboken += vinstSumma}");

                    Console.WriteLine($" Dina lyckotal är {randomNumber1}, {randomNumber2}, {randomNumber3} ");
                }


                Console.Write(" Vill du köra en runda till?");
                string svar = Console.ReadLine();
                while (true)
                {
                    if (svar == "ja")
                    {
                        break;
                    }
                    if (svar == "nej")
                    {
                        return;
                    }
                }
            }



        }
    }
}