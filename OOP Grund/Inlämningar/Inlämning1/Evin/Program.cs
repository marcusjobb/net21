using System;
namespace OHFORTUNA
{
    class Program {
    
        static void Main(string[] args)
        {
            int totalt = 500;
            int tillgodo = 0;
        Etiket:
            Console.Write("Insats");
            //     ConsoleKeyInfo girispara;
            tillgodo = Convert.ToInt32(Console.ReadLine());
       
            if (tillgodo >500)
            {
                Console.WriteLine("Max.- insats 500 pix");
                goto Etiket;
            }
            else if (tillgodo < 0) {
                Console.WriteLine("Min.- insats 50 pix ");
                goto Etiket;

            }
            Console.WriteLine("välj lycko siffra");
            int.TryParse(Console.ReadLine(), out int lycko_siffra);

            Console.WriteLine("Kasta tärning");
            string option = Console.ReadLine();

           //Du får 500 pix, varje gång du kastar tärningar blir det minst 50 pix per kastning.
           //När du får ett lyckotal (6) får du dubbel av satsning.
           //När du får två lyckotal (6) får du tre gånger insats.
           //När du får tre lyckotal (6) får du fyra gånger insats.
           //Regler
           //Spelaren får inte satsa mer  än vad denne har på banken.
           //Spelaren får inte fuska och satsa negativa värden.
           //Om spelarens konto understiger 50 pix avslutas spelet.
          //Efter en runda får spelaren se sitt saldo och välja om denne vill köra en runda till.

    {
    }
    {
        Random rnd = new Random();
        int tärning1 = rnd.Next(1, 7);
        int tärning2 = rnd.Next(1, 7);
        int tärning3 = rnd.Next(1, 7);  
       
                
                //object random = 0;
                Console.WriteLine("Firsta tärning = " + tärning1.ToString() );
                Console.WriteLine("Andra tärning = " + tärning2.ToString());
                Console.WriteLine("Tredje tärning = " + tärning3.ToString());

                if (tärning1.ToString() != lycko_siffra.ToString() && tärning2.ToString() !=
lycko_siffra.ToString() && tärning3.ToString() != lycko_siffra.ToString() )  {
                    totalt = totalt - tillgodo;
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else {
                        goto Etiket;
                    }

                }
                if (tärning1.ToString() == lycko_siffra.ToString() && tärning2.ToString() ==
lycko_siffra.ToString() && tärning3.ToString() == lycko_siffra.ToString() ) {

                    totalt = totalt + (tillgodo * 4);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());

                    }
                    else
                    {
                        goto Etiket;
                    }

                }

                if (tärning1.ToString() == lycko_siffra.ToString() && tärning2.ToString() ==
lycko_siffra.ToString() && tärning3.ToString() != lycko_siffra.ToString() )
                {
                    totalt = totalt + (tillgodo * 3);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else
                    {
                        goto Etiket;
                    }

                }
                if (tärning1.ToString() != lycko_siffra.ToString() && tärning2.ToString() ==
lycko_siffra.ToString() && tärning3.ToString() == lycko_siffra.ToString() )
                {
                    totalt = totalt + (tillgodo * 3);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else
                    {
                        goto Etiket;
                    }

                }

                if (tärning1.ToString() == lycko_siffra.ToString() && tärning2.ToString() !=
lycko_siffra.ToString() && tärning3.ToString() == lycko_siffra.ToString() )
                {
                    totalt = totalt + (tillgodo * 3);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else
                    {
                        goto Etiket;
                    }

                }

                if (tärning1.ToString() == lycko_siffra.ToString() && tärning2.ToString() !=
lycko_siffra.ToString() && tärning3.ToString() != lycko_siffra.ToString() )
                {
                    totalt = totalt + (tillgodo * 2);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else
                    {
                        goto Etiket;
                    }

                }

                if (tärning1.ToString() != lycko_siffra.ToString() && tärning2.ToString() ==
lycko_siffra.ToString() && tärning3.ToString() != lycko_siffra.ToString() )
                {
                    totalt = totalt + (tillgodo * 2);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());

                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else
                    {
                        goto Etiket;
                    }

                }
                if (tärning1.ToString() != lycko_siffra.ToString() && tärning2.ToString() !=
lycko_siffra.ToString() && tärning3.ToString() == lycko_siffra.ToString() )
                {
                    totalt = totalt + (tillgodo * 2);
                    Console.WriteLine("Innestående pix = " + totalt.ToString());
                    if (totalt < 50)
                    {
                        Console.WriteLine("Innestående pix = " + totalt.ToString());
                    }
                    else
                    {
                        goto Etiket;
                    }

                }
            }

     
     

        }
    }
}