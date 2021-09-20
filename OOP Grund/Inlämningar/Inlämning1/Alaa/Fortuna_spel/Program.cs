//program för att skapa ett Fortuna-spel till spelmaskiner.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna_spel
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera 
            int balance = 500;
            int bet = 50;
            int luckyN = 0;
            bool flag = true;

            while (flag)
            {
                Random rnd = new Random(); //skapa tre slumptal mellan 1-6
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int dice3 = rnd.Next(1, 7);
                //Console.Write("{0}\t{1}\t{2}", dice1, dice2, dice3); //denna rad för att kalibrera spelet

                //fråga spelaren om hur mycket vill han satsa och ge honom möjlighet att avbryta 
                Console.WriteLine("\nVill du fortsätta spela...eller trycka på 'X' för att avsluta.");
                Console.Write("Hur mycket vill du satsa: ");
                string str1 = Console.ReadLine();
                if (int.TryParse(str1, out bet))
                {
                    //fråga spelaren om insatsen 
                    if (bet < 50) Console.WriteLine("Minst insats är 50 pix.");
                    else if (bet <= balance)
                    {
                        //fråga spelaren om lyckonummret och ge honom möjlighet att avbryta
                        Console.WriteLine("vill du fortsätta spela...eller trycka på 'X' för att avsluta.");
                        Console.Write("Välja ett lyckotal mellan 1 och 6: ");
                        string str2 = Console.ReadLine();
                        if (int.TryParse(str2, out luckyN))
                        {
                            if (luckyN >= 1 && luckyN <= 6)
                            {
                                if (luckyN == dice1)
                                {
                                    if (luckyN == dice2)
                                    {
                                        if (luckyN == dice3)
                                        {
                                            //tre tärningar visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade tre tärningar.\tB R A V O ", luckyN);
                                            balance = balance + (4 * bet);
                                        }
                                        else
                                        {
                                            //två tärningar visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade två tärningar.\tG O D ", luckyN);
                                            balance = balance + (3 * bet);
                                        }
                                    }
                                    else
                                    {
                                        if (luckyN == dice3)
                                        {
                                            //två tärningar visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade två tärningar.\tG O D ", luckyN);
                                            balance = balance + (3 * bet);
                                        }
                                        else
                                        {
                                            //en tärning visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade en tärningar.\tB R A ", luckyN);
                                            balance = balance + (2 * bet);
                                        }
                                    }
                                }
                                else
                                {
                                    if (luckyN == dice2)
                                    {
                                        if (luckyN == dice3)
                                        {
                                            //två tärningar visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade två tärningar.\tG O D ", luckyN);
                                            balance = balance + (3 * bet);
                                        }
                                        else
                                        {
                                            //en tärning visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade en tärningar.\tB R A ", luckyN);
                                            balance = balance + (2 * bet);
                                        }
                                    }
                                    else
                                    {
                                        if (luckyN == dice3)
                                        {
                                            //en tärning visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade en tärningar.\tB R A ", luckyN);
                                            balance = balance + (2 * bet);
                                        }
                                        else
                                        {
                                            //ingen tärning visar lyckotalet
                                            Console.WriteLine("\nFörsta tärning: {0}\tAndra Tärning: {1}\tTredje tärning: {2}", dice1, dice2, dice3);
                                            Console.WriteLine("Ditt lyckonumret: {0} - Du gissade ingen tärningar och förlorade din insats. .\tO T U R ", luckyN);
                                            balance -= bet;
                                        }
                                    }
                                }
                                //Visa spelaren saldo
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\t\tDitt saldo är: {0} PIX\n", balance);
                                Console.ResetColor();
                                if (balance <= 50) break;
                            }
                            else Console.WriteLine("Du måste välja ett nummer mellan 1 och 6.");
                        }
                        else if (str2 == "x") break;
                    }
                    else Console.WriteLine("Du får inte satsa högre än ditt saldo.");
                }
                else if (str1 == "x") break;
                else Console.WriteLine("Du angav ett felaktigt värde.....Försök igen");
            }
            Console.ReadLine();
        }
    }
}