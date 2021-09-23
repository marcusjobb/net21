using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = false;
            int spelarenPix = 500;
            int saldo = 500;
            int bonus = 0;

            int spelarInsatsMin = 50;
            int spelarInsatsHögts = 500;

            int spelarInsats = 0;
            int lyckoTal = 0;

            int tärning1 = 0;
            int tärning2 = 0;
            int tärning3 = 0;


            int[] tärningarSomKastas = new int[3]
            {
                1,
                2,
                3
            };

            string[] tärningar = new string[3]
            {
             "|Result tärning 1|: ",
             "|Result tärning 2|: ",
             "|Result tärning 3|: "
            };


            do
            {
                do
                {
                    Console.WriteLine("HEJ OCH VÄLKOMMEN");
                    Console.WriteLine("Ditt saldo i Pix är: " + spelarenPix + " Px ");
                    Console.WriteLine();

                    Console.WriteLine("Hur många pix vill du satsa");

                    string input = Console.ReadLine();
                    int.TryParse(input, out spelarInsats);

                    if (spelarenPix >= 50)
                    {

                        if (spelarInsats >= spelarInsatsMin && spelarInsats <= spelarInsatsHögts)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Välj ett LyckoTal mellan 1 och 6");
                            Console.WriteLine("|(1), (2), (3), (4), (5), (6)|");

                            string input1 = Console.ReadLine();
                            Console.Clear();
                            int.TryParse(input1, out lyckoTal);


                            if (lyckoTal >= 1 && lyckoTal <= 6)
                            {

                                Console.WriteLine("Ditt lyckoTal är: " + lyckoTal);

                                Ready("READY!");

                                Random rdm = new Random();


                                foreach (int tärning in tärningarSomKastas)
                                {

                                    tärning1 = rdm.Next(1, 6);
                                    tärning2 = rdm.Next(1, 6);
                                    tärning3 = rdm.Next(1, 6);

                                }


                                Console.WriteLine();
                                Console.WriteLine(tärningar[0] + tärning1);
                                Console.WriteLine(tärningar[1] + tärning2);
                                Console.WriteLine(tärningar[2] + tärning3);
                                Console.WriteLine();


                                if (tärning1 == lyckoTal && tärning2 == lyckoTal && tärning3 == lyckoTal)
                                {
                                    Console.WriteLine("Du vinner fyra gånger så mycket :D ");
                                    bonus = (spelarInsats * 4);
                                    spelarInsats = (spelarInsats + bonus);
                                    spelarenPix = (spelarenPix + spelarInsats);

                                    Console.WriteLine();
                                    Console.WriteLine("Ditt Saldo är: " + spelarenPix);
                                    Console.WriteLine();

                                    Console.WriteLine("Vill du spela igen?");
                                    Console.WriteLine("|JA, TRYCK ETT (1)|;|NEJ, TRYCK TVÅ (2)|");
                                    string input2 = Console.ReadLine();
                                    int answer = 0;
                                    bool correct = int.TryParse(input2, out answer);


                                    if (correct)
                                    {
                                        if (answer == 1)
                                        {
                                            playAgain = true;
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                }


                                if (tärning1 == lyckoTal && tärning2 == lyckoTal)
                                {
                                    Console.WriteLine("Du vinner tre gånger så mycket :D ");
                                    bonus = (spelarInsats * 3);
                                    spelarInsats = (spelarInsats + bonus);
                                    spelarenPix = (spelarenPix + spelarInsats);

                                    Console.WriteLine();
                                    Console.WriteLine("Ditt Saldo är: " + spelarenPix);
                                    Console.WriteLine();

                                    Console.WriteLine("Vill du spela igen?");
                                    Console.WriteLine("|JA, TRYCK ETT (1)|;|NEJ, TRYCK TVÅ (2)|");
                                    string input2 = Console.ReadLine();
                                    int answer = 0;
                                    bool correct = int.TryParse(input2, out answer);


                                    if (correct)
                                    {
                                        if (answer == 1)
                                        {
                                            playAgain = true;
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                }


                                else if (tärning1 == lyckoTal && tärning3 == lyckoTal)
                                {
                                    Console.WriteLine("Du vinner tre gånger så mycket :D ");
                                    bonus = (spelarInsats * 3);
                                    spelarInsats = (spelarInsats + bonus);
                                    spelarenPix = (spelarenPix + spelarInsats);

                                    Console.WriteLine();
                                    Console.WriteLine("Ditt Saldo är: " + spelarenPix);
                                    Console.WriteLine();

                                    Console.WriteLine("Vill du spela igen?");
                                    Console.WriteLine("|JA, TRYCK ETT (1)|;|NEJ, TRYCK TVÅ (2)|");
                                    string input2 = Console.ReadLine();
                                    int answer = 0;
                                    bool correct = int.TryParse(input2, out answer);


                                    if (correct)
                                    {
                                        if (answer == 1)
                                        {
                                            playAgain = true;
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                }

                                else if (tärning2 == lyckoTal && tärning3 == lyckoTal)
                                {
                                    Console.WriteLine("Du vinner tre gånger så mycket :D ");
                                    bonus = (spelarInsats * 3);
                                    spelarInsats = (spelarInsats + bonus);
                                    spelarenPix = (spelarenPix + spelarInsats);

                                    Console.WriteLine();
                                    Console.WriteLine("Ditt Saldo är: " + spelarenPix);
                                    Console.WriteLine();

                                    Console.WriteLine("Vill du spela igen?");
                                    Console.WriteLine("|JA, TRYCK ETT (1)|;|NEJ, TRYCK TVÅ (2)|");
                                    string input2 = Console.ReadLine();
                                    int answer = 0;
                                    bool correct = int.TryParse(input2, out answer);


                                    if (correct)
                                    {
                                        if (answer == 1)
                                        {
                                            playAgain = true;
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                }


                                else if (tärning1 == lyckoTal || tärning2 == lyckoTal || tärning3 == lyckoTal)
                                {
                                    Console.WriteLine("Du vinner dubbelt så mycket :D ");
                                    bonus = (spelarInsats * 2);
                                    spelarInsats = (spelarInsats + bonus);
                                    spelarenPix = (spelarenPix + spelarInsats);

                                    Console.WriteLine();
                                    Console.WriteLine("Ditt Saldo är: " + spelarenPix);
                                    Console.WriteLine();

                                    Console.WriteLine("Vill du spela igen?");
                                    Console.WriteLine("|JA, TRYCK ETT (1)|;|NEJ, TRYCK TVÅ (2)|");
                                    string input2 = Console.ReadLine();
                                    int answer = 0;
                                    bool correct = int.TryParse(input2, out answer);


                                    if (correct)
                                    {
                                        if (answer == 1)
                                        {
                                            playAgain = true;
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Du får ingenting :C ");
                                    bonus = (spelarInsats - 50);
                                    spelarInsats = (spelarInsats - bonus);
                                    spelarenPix = (spelarenPix - spelarInsats);

                                    Console.WriteLine();
                                    Console.WriteLine("Ditt Saldo är: " + spelarenPix);
                                    Console.WriteLine();

                                    Console.WriteLine("Vill du spela igen?");
                                    Console.WriteLine("|JA, TRYCK ETT (1)|;|NEJ, TRYCK TVÅ (2)|");
                                    string input2 = Console.ReadLine();
                                    int answer = 0;
                                    bool correct = int.TryParse(input2, out answer);


                                    if (correct)
                                    {
                                        if (answer == 1)
                                        {
                                            playAgain = true;
                                        }
                                        else
                                        {
                                            break;
                                        }


                                    }
                                }




                            }
                        }



                        else if (spelarInsats < spelarInsatsMin)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du måste satsa minst 50 pix för att kunna spela");
                            Console.WriteLine("Tryck på en knapp för att forsätta.");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Du måste satsa maxt 500 pix för att kunna spela");
                            Console.WriteLine("Tryck på en knapp för att forsätta.");
                            Console.ReadLine();
                            Console.Clear();
                        }

                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du har inte tillräckligt saldo");
                        Console.WriteLine("Tryck på en knapp för att forsätta.");
                        Console.ReadLine();
                        break;
                    }




                } while (spelarInsats < 50 || spelarInsats > 500);



            } while (playAgain == true);












            static void tärningOchLyckoTal(int tärningOchLyckoTal)
            {
                int tärningarSomkKastas = 3;


            }

            static void Ready(string ready)
            {

                string A = ("||+------------+ Get! +------------+||");
                string B = ("||+----------+||" + ready + "||+----------+||");
                A = ("||+-----------+||3...||+-----------+||");
                B = ("||+-----------+||2...||+-----------+||");
                A = ("||+-----------+||1...||+-----------+||");
                B = ("||+------------+||GO!||+-----------+||");

            }







        }
    }
}