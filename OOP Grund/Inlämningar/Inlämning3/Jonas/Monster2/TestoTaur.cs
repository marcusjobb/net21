using System;
using System.Threading;
using System.Collections.Generic;


//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;
//using System.Collections.Generic;

namespace TheGame001
{
    public class TestoTaur : Monster
    {
        //private Stack<(int, int)> Path = new Stack<(int, int)>();
        //private bool[,] visited;
        //bool[,] visited = new bool[myGame.Labyrint.GetLength(0), myGame.Labyrint.GetLength(1)];
        Random rnd = new Random();
        public (int, int) myCurrent = (0,0) ;
        //int timesInvoked = 0;

        // myCurrent.Item1=något  // VARFÖR FUNKAR INTE DETTA?!?
        public List<(int, int)> Path = new List<(int, int)>();
        public Queue<(int, int)> MyPath = new Queue<(int, int)>();

        public override void Move(Game myGame, Player player)
        {

            if (myGame.GetDistance(player, this) > 45)
            {
                // Gör ingenting  
            }
            else { 
                myCurrent.Item1 = position[0];
            myCurrent.Item2 = position[1];
            bool[,] visited = new bool[myGame.Labyrint.GetLength(0), myGame.Labyrint.GetLength(1)];
            bool found = false;
            (int, bool) returnMe = (0, false);
            Generate(myCurrent, player);



            foreach (var item in Path)
            {
                MyPath.Enqueue(item);
            }


            //Console.ReadLine();
            if (MyPath.Count > 0)
            {
                (int, int) newPos = MyPath.Dequeue();
                if (Math.Abs(this.Position[0] - newPos.Item1) <= 1 && Math.Abs(this.Position[1] - newPos.Item2) <= 1)
                {
                    this.position[0] = newPos.Item1;
                    this.position[1] = newPos.Item2;
                }
                else
                {
                    MyPath.Clear();
                }
            }

            Path.Clear();

            (int, bool) Generate((int, int) current, Player player) ///GENERATE BÖRJAR HÄR///////////////////////////////////////
            {
                //if (current.Item1 == player.Position[0] && current.Item2 == player.Position[1])
                //{
                //    found = true;
                //}


                while// if else istället, list<intint> path add if match remove if no
                    (
                      (
                       (myGame.Labyrint[current.Item1 + 1, current.Item2] == ' ' && visited[current.Item1 + 1, current.Item2] == false) ||
                       (myGame.Labyrint[current.Item1 - 1, current.Item2] == ' ' && visited[current.Item1 - 1, current.Item2] == false) ||
                       (myGame.Labyrint[current.Item1, current.Item2 + 1] == ' ' && visited[current.Item1, current.Item2 + 1] == false) ||
                       (myGame.Labyrint[current.Item1, current.Item2 - 1] == ' ' && visited[current.Item1, current.Item2 - 1] == false)
                      )
                    )

                {
                    visited[current.Item1, current.Item2] = true;



                    if (current.Item1 == player.Position[0] && current.Item2 == player.Position[1])
                    {
                        found = true;
                    }

                    int val = rnd.Next(1, 5);
                    switch (val)
                    {
                        case 1:
                            if (myGame.Labyrint[current.Item1 + 1, current.Item2] == ' ' && visited[current.Item1 + 1, current.Item2] == false)
                            {
                                visited[current.Item1 + 1, current.Item2] = true;
                                current.Item1 = current.Item1 + 1;
                                myCurrent = current;
                                if (found == false)
                                {
                                    Path.Add(current);
                                }
                                returnMe = Generate(current, player);
                            }

                            break;
                        case 2:
                            if (myGame.Labyrint[current.Item1 - 1, current.Item2] == ' ' && visited[current.Item1 - 1, current.Item2] == false)
                            {
                                visited[current.Item1 - 1, current.Item2] = true;
                                current.Item1 = current.Item1 - 1;
                                myCurrent = current;
                                if (found == false)
                                {
                                    Path.Add(current);
                                }
                                returnMe = Generate(current, player);
                            }

                            break;

                        case 3:

                            if (myGame.Labyrint[current.Item1, current.Item2 + 1] == ' ' && visited[current.Item1, current.Item2 + 1] == false)
                            {
                                visited[current.Item1, current.Item2 + 1] = true;
                                current.Item2 = current.Item2 + 1;
                                myCurrent = current;
                                if (found == false)
                                {
                                    Path.Add(current);
                                }

                                returnMe = Generate(current, player);
                            }

                            break;

                        case 4:

                            if (myGame.Labyrint[current.Item1, current.Item2 - 1] == ' ' && visited[current.Item1, current.Item2 - 1] == false)
                            {
                                visited[current.Item1, current.Item2 - 1] = true;
                                current.Item2 = current.Item2 - 1;
                                myCurrent = current;
                                if (found == false)
                                {
                                    Path.Add(current);
                                }

                                returnMe = Generate(current, player);
                            }

                            break;


                    }

                }
                if (returnMe.Item2 == false && returnMe.Item1 > 0)
                {
                    Path.RemoveAt(returnMe.Item1 - 1);
                }


                if (current.Item1 == player.Position[0] && current.Item2 == player.Position[1])
                {
                    found = true;
                }


                return (Path.Count, found);

            }

          }
        }


            public TestoTaur (string myName, char sign, int Exp) : base(myName, sign, Exp)
            {
 



            }

        

    }
}





