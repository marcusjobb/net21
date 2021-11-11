using System;
using System.Collections.Generic;
using System.Threading;


namespace TheGame001
{
    public class Game
    {
        //private char[,] overlay;
        public char[,] Labyrint { get; set; }//  
        //public char[,] Overlay { get=> overlay; set 
        //    {
        //        overlay = value;
        //    }
        //}//  

        //public Random Rand = new Random();


 
        public List<Monster> Monsters { get; set; } = new List<Monster>();
        public List<Shop> Shops { get; set; }  = new List<Shop>();


        public void NewGame(Player player)              // Kanske inte player här heller
        {                                               // fast kanske ändå..?,

            TestoTaur Minotauren = new TestoTaur("MINOTAUREN", '¤', 10000);
            //Minotauren.Position[0] = Labyrint.GetLength(0) / 2;
            //Minotauren.Position[1] = Labyrint.GetLength(1) / 2;
            //(int, int) middle = (Labyrint.GetLength(0) / 2, Labyrint.GetLength(1) / 2);
            int y = Labyrint.GetLength(0) / 2;
            int x = Labyrint.GetLength(1) / 2;
            Monsters.Add(new Monster("minitaur", 'µ', 250));
            Monsters.Add(new Monster("minitaur", 'µ', 250));
            Monsters.Add(new Monster("minitaur", 'µ', 250));
            Monsters.Add(new Monster("minitaur", 'µ', 250));
            Monsters.Add(new Monster("minitaur", 'µ', 250));
            Monsters.Add(new Monster("miditaur", 'ð', 500));
            Monsters.Add(new Monster("miditaur", 'ð', 500)); 
            Monsters.Add(new Monster("miditaur", 'ð', 500));
            Monsters.Add(new Monster("maxitaur", 'þ', 1000));
            Monsters.Add(Minotauren);
            //Monsters.Add(new TestoTaur("MINOTAUREN", '¤', 10000));
            ////{ Position={ y, x });
            //Monsters.Add(new TestoTaur{  Name="MINOTAUREN", Symbol='¤', XP=10000 , Position={ y, x });


            Shops.Add(new Shop { Name = "Frodo's Supermarket", Gold = 1000, Inventory=Miscellaneous.AllTheThings  , WantsToBuy = Miscellaneous.AllTheThings, WantsToSell = Miscellaneous.AllTheThings, Position = new int[] { 5, 5 } });
            Shops.Add(new Shop { Name = "Frodo's Andra Cornershop", Gold = 1000, Inventory = Miscellaneous.AllTheThings, WantsToBuy = Miscellaneous.AllTheThings, WantsToSell = Miscellaneous.AllTheThings, Position = new int[] { Labyrint.GetLength(0)-6, 5 } });
            Shops.Add(new Shop { Name = "Frodo's Cornershop", Gold = 1000, Inventory = Miscellaneous.AllTheThings, WantsToBuy = Miscellaneous.AllTheThings, WantsToSell = Miscellaneous.AllTheThings, Position = new int[] { 5, Labyrint.GetLength(1) - 6 } });




            PlaceMonster(player, 5, 10, 5, 10, player);
            foreach (var item in Monsters)
            {
                PlaceMonster(item, 5, Labyrint.GetLength(0)-20, 5, Labyrint.GetLength(1)-20, player);
            }
            Console.Clear();
            Minotauren.Position[0] = Labyrint.GetLength(0) / 2;
            Minotauren.Position[1] = Labyrint.GetLength(1) / 2;
            PrintLabyrint(player);

            while (player.IsAlive && player.XP < 10000 )
            {
               
                List<Monster> tmpList = new List<Monster>();
                foreach (var beast in Monsters)                         // man slipper tydligen den här sortens
                {                                                       // krångel med linq, men...
                    if (!beast.IsAlive) tmpList.Add(beast);
                }
                foreach (var creature in tmpList)
                {
                    Monsters.Remove(creature);
                }

                //PrintMonster(player);

                foreach (var critter in Monsters)
                {
                    
                    if (GetDistance(player,critter) <= 1) 
                    {
                        if (critter.IsAlive && critter.IsHostile) Fight(player, critter);
 
                    }
                }
                if ( Labyrint.GetLength(0) - player.Position[0] < 10 && Labyrint.GetLength(1) - player.Position[1] < 10)
                {
                    Console.WriteLine("Du har hittat ut ur labyrinten! +10000 XP");
                    player.XP += 10000;
                    Console.ReadLine();
                }


                ConsoleKey readKey = Console.ReadKey().Key;
                if (readKey == ConsoleKey.LeftArrow && Labyrint[player.Position[0],(player.Position[1] -1)] ==' ')
                {
                    EraseMonster(player);
                    player.Position[1]--;
                    //player.Position[0]--;
                }
                else if (readKey == ConsoleKey.RightArrow && Labyrint[player.Position[0], (player.Position[1] + 1)] == ' ')
                {
                    EraseMonster(player);

                    player.Position[1]++;
                    //player.Position[0]++;
                }
                else if (readKey == ConsoleKey.UpArrow && Labyrint[player.Position[0] -1, (player.Position[1])] == ' ')
                {
                    EraseMonster(player);

                    player.Position[0]--;
                    //player.Position[1]--;
                }
                else if (readKey == ConsoleKey.DownArrow && Labyrint[player.Position[0] +1, (player.Position[1])] == ' ')
                {
                    EraseMonster(player);

                    player.Position[0]++;
                    //player.Position[1]++;
                }
                else if (readKey == ConsoleKey.Insert)
                {
                    player.Equip();
                    Console.Clear();
                    PrintLabyrint(player);
                }
                else if (readKey == ConsoleKey.Delete)
                {
                    player.UnEquip();
                    Console.Clear();
                    PrintLabyrint(player);
                }

                else if (readKey == ConsoleKey.Home)
                {
                    player.Display();
                    Console.Clear();
                    PrintLabyrint(player);
                }
                else if (readKey == ConsoleKey.PageUp)
                {
                    bool didTrade = false;

                    List<IShopper> Shoppers = new List<IShopper>();
                    foreach (var market in Shops) { Shoppers.Add(market); }
                    foreach (var thing in Monsters) { Shoppers.Add(thing); }
                    foreach (var shopper in Shoppers)

                        //foreach (var thing in Monsters)
                    {

                        if (GetDistance(player,shopper) <3)
                        {
                            Trade(player, shopper);
                            break;
                        }
 
                    }
                    if (didTrade)
                    {
                        Console.Clear();
                        PrintLabyrint(player);
                    }
                    else
                    {
                        Console.SetCursorPosition(Labyrint.GetLength(0) - 10, Labyrint.GetLength(1) + 3);
                        Console.WriteLine( "Ingen att handla med");
                        Thread.Sleep(3000);
                        Console.SetCursorPosition(Labyrint.GetLength(0) - 10, Labyrint.GetLength(1) + 3);
                        Console.WriteLine("                     ");
                    }
                }

                foreach (var item in Monsters)
                {
                    EraseMonster(item);

                    item.Move(this,player); // måste skicka med både player & game. Vad är egentligen poängen med uppdelningen i klasser nu?
                }
                foreach (var item in Monsters)
                {
                    PrintMonster(item);
                }
                PrintMonster(player);

                if (player.XP /( player.Level * 1000) > 1)
                {
                    player.LevelUp();
                }
            }
        }

        public void Fight (Player player, Monster monster)
        {
            //Console.WriteLine("fight!");

            Random rnd = new Random();
            if (monster.IsHostile)
            {
                while (monster.IsAlive && player.IsAlive)
                {   
                    int attackRollPlayer = rnd.Next(1, 101);
                    int attackRollMonster = rnd.Next(1, 101);
                    if (attackRollPlayer <= player.HitChance)
                    {                                               // CONSOLE CLEAR
                        Console.WriteLine(player.Name + " träffade " + monster.Name + " och gjorde " + player.HitDamage + " hp skada");
                        monster.HP -= player.HitDamage;
                    }
                    else
                    {
                        Console.WriteLine(player.Name + " missade");
                    }
                    ConsoleKey readKey=Console.ReadKey().Key;
                     if (readKey == ConsoleKey.Home)
                    {
                        player.Display();
                    }
                    if (attackRollMonster <= monster.HitChance)
                    {
                        Console.WriteLine(monster.Name + " träffade " + player.Name + " och gjorde " + monster.HitDamage + " hp skada");
                        player.HP -= monster.HitDamage;
                    }
                    else
                    {
                        Console.WriteLine(monster.Name + " missade");
                    }

                    if (player.HP < 0)
                    {
                        player.IsAlive = false;
                        Console.WriteLine(player.Name + " dog");
                    }
                    if (monster.HP < 0)
                    {
                        monster.IsAlive = false;
                        Console.WriteLine(monster.Name + " dog");
                        player.XP += monster.XP;
                        player.Gold += monster.Gold;
                        List<Item> tmpList = new List<Item>();
                        foreach (var item in monster.Inventory)
                        {
                            player.Inventory.Add(item);
                            tmpList.Add(item);
                           
                        }
                        foreach (var item2 in tmpList)
                        {
                            monster.Inventory.Remove(item2);
                        }
                        Console.Clear();
                        PrintLabyrint(player);
                    }
                }
            }
            else if (monster.WantsToBuy.Count > 0 && monster.WantsToSell.Count > 0)
            {
                //string input;
                //do
                //{
                //    //CONSOLE CLEAR (eller skapa popups?)
                //    Console.WriteLine(monster.Name + " vill idka byteshandel.\n" +
                //        "\n" +
                //        "1) handla \n" +
                //        "2) slåss");
                //    input = Console.ReadLine();
                //} while (input != "1" && input != "2");
                //if (input == "1")
                //{
                //    Trade(player, monster);
                    
                //    Console.Clear();
                //    PrintLabyrint(player);
                //}
                //else
                //{
                //    monster.IsHostile=true;
                //    FightOrTrade(player, monster);
                //}
            }


            Console.ReadKey();
        }


        public void PlaceMonster ( Monster monster, int minY, int maxY, int minX, int maxX, Player player )
        {
            int x = 0;
            int y = 0;
            Random rnd = new Random();
            do
            {
                 x = rnd.Next(minX, maxX);
                 y = rnd.Next(minY, maxY);
            } while (Labyrint[y, x] != ' ' && !(CheckForMonsters(y,x, player )));
            monster.Position[0] = y;
            monster.Position[1] = x;
            monster.RecentlyVisitedPositions.Add((y, x));
        }
        public Game()
        {
            

            //int size = 24;            
            int size = 18;
            char[,] maze = new char[size * 2 + 2, size * 2 + 2];
            char[,] overlay = new char[size * 2 + 2, size * 2 + 2];// ya bort

            (int, int) currentCell = (4, 4);
            Random rnd = new Random();

            //vvvv fyll labyrinten med väggar & obesökta kammare
            //  omge lab med tecken som är annat än ' ' & '#', exvis '!'
            for (int i = 0; i < (size * 2) + 2; i++)
            {
                for (int j = 0; j < (size * 2) + 2; j++)
                {
                    if (i != 0 && j != 0 && i != size * 2 + 1 && j != size * 2 + 1 && i != 1 && j != 1 && i != size * 2 && j != size * 2)
                    {
                        maze[i, j] = '#';
                    }
                    else
                    {
                        maze[i, j] = '!';
                    }

                }
            }
            Generate(currentCell);

            Labyrint=DoubleSize(maze);
             void Generate((int, int) current)
            {
                //https://en.wikipedia.org/wiki/Maze_generation_algorithm#Randomized_depth-first_search


                //maze[current.Item1, current.Item2] = ' ';
                while
                    (
                    maze[current.Item1 + 2, current.Item2] == '#' ||
                    maze[current.Item1 - 2, current.Item2] == '#' ||
                    maze[current.Item1, current.Item2 + 2] == '#' ||
                    maze[current.Item1, current.Item2 - 2] == '#'
                    )
                {
                    maze[current.Item1, current.Item2] = ' ';
                    int val = rnd.Next(1, 5);
                    switch (val)
                    {
                        case 1:
                            if (maze[current.Item1 + 2, current.Item2] == '#' && maze[current.Item1 + 1, current.Item2 + 1] != ' ' && maze[current.Item1 + 1, current.Item2 - 1] != ' ')
                            {
                                maze[current.Item1 + 1, current.Item2] = ' ';
                                current.Item1 = current.Item1 + 2;
                                Generate(current);
                            }
                            break;
                        case 2:
                            if (maze[current.Item1 - 2, current.Item2] == '#' && maze[current.Item1 - 1, current.Item2 + 1] != ' ' && maze[current.Item1 - 1, current.Item2 - 1] != ' ')
                            {
                                maze[current.Item1 - 1, current.Item2] = ' ';
                                current.Item1 = current.Item1 - 2;
                                Generate(current);
                            }
                            break;
                        case 3:
                            if (maze[current.Item1, current.Item2 + 2] == '#' && maze[current.Item1 + 1, current.Item2 + 1] != ' ' && maze[current.Item1 - 1, current.Item2 - 1] != ' ')
                            {
                                maze[current.Item1, current.Item2 + 1] = ' ';
                                current.Item2 = current.Item2 + 2;
                                Generate(current);
                            }
                            break;
                        case 4:
                            if (maze[current.Item1, current.Item2 - 2] == '#' && maze[current.Item1 + 1, current.Item2 - 1] != ' ' && maze[current.Item1 - 1, current.Item2 - 1] != ' ')
                            {
                                maze[current.Item1, current.Item2 - 1] = ' ';
                                current.Item2 = current.Item2 - 2;
                                Generate(current);
                            }
                            break;


                    }

                }
            }
            char[,] DoubleSize(char[,] mazen)
            {
                int height = mazen.GetLength(0);
                int width = mazen.GetLength(1);
                char c = ' ';
                char[,] bigger = new char[(height * 2), (width * 2)];
                for (int i = 0; i < height * 2; i++)
                {
                    for (int j = 0; j < width * 2; j++)
                    {
                        c = mazen[i / 2, j / 2];
                        bigger[i, j] = c;
                        //Console.Write (bigger[i,j]);
                        //if ( j == width*2 - 1)
                        //{
                        //	Console.WriteLine(" ");
                        //}
                    }

                }//dit 1
                for (int k = 0; k < height * 2; k++)
                {
                    for (int l = 0; l < width * 2; l++)
                    {
                        //Thread.Sleep(5);

                        if (k != height * 2 - 1 && (bigger[k, l] == '!' && bigger[k + 1, l] == ' '))                         //(bigger[k,l]=='#' && bigger[k+1,l]==' ')  
                        {
                            c = 'o';
                            bigger[k + 1, l] = c;
                        }

                        if (l != width * 2 - 1 && (bigger[k, l] == '!' && bigger[k, l + 1] == ' '))                         //(bigger[k,l]=='#' && bigger[k+1,l]==' ')  
                        {
                            c = 'o';
                            bigger[k, l + 1] = c;
                        }
                        if (bigger[k, l] == '!')                         //(bigger[k,l]=='#' && bigger[k+1,l]==' ')  
                        {
                            c = 'o';
                            bigger[k, l] = c;
                        }

                        if (bigger[k, l] == '#' && bigger[k + 1, l] == ' ')   //(bigger[k,l]=='#' && bigger[k+1,l]==' ')  
                        {
                            c = 'o';
                            bigger[k + 1, l] = c;
                        }

                        if (bigger[k, l] == '#' && bigger[k + 1, l + 1] == ' ')   //(bigger[k,l]=='#' && bigger[k+1,l]==' ')  
                        {
                            c = 'o';
                            bigger[k + 1, l + 1] = c;
                        }

                        if (bigger[k, l] == '#' && bigger[k, l + 1] == ' ')   //(bigger[k,l]=='#' && bigger[k+1,l]==' ')  
                        {
                            c = 'o';
                            bigger[k, l + 1] = c;
                        }


                        if (bigger[k, l] == '!')
                        {
                            c = '#';
                            bigger[k, l] = c;
                        }
                        if (bigger[k, l] == 'o')
                        {
                            c = '#';
                            bigger[k, l] = c;
                        }
                        if (bigger[k, l] == '#' || bigger[k, l] == '!')
                        {
                            //Console.ForegroundColor = ConsoleColor.Blue;
                            //Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            //Console.ForegroundColor = ConsoleColor.White;
                            //Console.BackgroundColor = ConsoleColor.Black;

                        }
                        //Console.Write(bigger[k, l]);
                        if (l == width * 2 - 1)
                        {
                            //Console.WriteLine(" ");
                        }
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            int y = (bigger.GetLength(0) / 2 - 6) + i;
                            int x = (bigger.GetLength(1) / 2 - 6) + j;
                            (int, int) middle = (bigger.GetLength(0) / 2, bigger.GetLength(1) / 2);
                            if (Distance(middle, (y, x)) < 5.0)
                            {
                                bigger[(bigger.GetLength(0) / 2 - 5) + i, (bigger.GetLength(1) / 2 - 5) + j] = ' ';
                            }
                             
                        }
                    }
                }
                return bigger;

            }

            //for (int i = 0 ; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Labyrint[(Labyrint.GetLength(0) / 2 -5)+i, (Labyrint.GetLength(1) / 2 - 5)] = ' ';
            //    }
            //}
            //Labyrint.GetLength(1)/2
            //Labyrint.GetLength(1)/2
        } //END GAME Constructor

        public bool CheckForMonsters(int i, int j, Player player)
        {

            foreach (var item in Monsters)
            {
                if (i == item.Position[0] && j == item.Position[1])
                {
                    //Console.Write(item.Symbol);         //TAG BORT
                    return true;
                }                
            }

            if (i == player.Position[0] && j == player.Position[1]) return true;

                return false;
        }

        //public void Trade(Player player, Monster monster)
        public void Trade(Player player, IShopper shopper)
        {
            string input;
            do
            {
                Console.WriteLine("0) Avsluta");
                Console.WriteLine("1.Köp");
                Console.WriteLine("2.Sälj");
                Console.WriteLine(" ");
                input = Console.ReadLine();
                //} while (input != "1" && input != "2");

                if (input == "1")
                {
                    int i = 0;
                    int result = 0;
                    string response;
                    List<Item> sell = new List<Item>();
                    do
                    {
                        Console.WriteLine("x) ångra");
                        //foreach (var item in monster.WantsToSell)
                        //for (int k = 0; k < monster.WantsToSell.Count; k++)
                         for (int k = 0; k <shopper.WantsToSell.Count; k++)
                        {
                            Item item = shopper.WantsToSell[k];
                            Console.WriteLine((k + 1) + " " + item.Name + " " + item.Description + "\t" + item.SuggestedPrice + " guld");
                            sell.Add(item);
                            //i++;
                        }
                        Console.WriteLine("välj vad");
                        response = Console.ReadLine();
                        //i = 1; //WTF?!?!?!
                        bool uselessVariable = int.TryParse(response, out result);
                    }
                    //while (!int.TryParse(response, out result) || ( result < 1 || result > sell.Count )  || response != "x");
                    while ((result < 1 || result > player.Inventory.Count) && response != "x");
                    if (response =="x")
                    {
                        Console.WriteLine("OK.");
                    }
                    else
                    {
                        if (player.Gold > sell[result - 1].SuggestedPrice)
                        {
                            player.Gold -= sell[result - 1].SuggestedPrice;
                            shopper.Gold += sell[result - 1].SuggestedPrice;
                            player.Inventory.Add(sell[result - 1]);
                            shopper.Inventory.Remove(sell[result - 1]);
                        }
                    }
                }
                /////////////////////////////////
                if (input == "2")
                {
                    int i = 1;
                    int result = 0;
                    int offer=0;
                    string reply;
                    List<Item> buy = new List<Item>();
                    do
                    {
                        Console.WriteLine("x) ångra");
                        foreach (var item in shopper.WantsToBuy)
                        {
                            //foreach (var thing in player.Inventory)
                             for  (int j =0; j < player.Inventory.Count; j++)

                            {

                                if (player.Inventory [j] == item)
                                {

                                    if (item.SuggestedPrice > shopper.Gold) offer = shopper.Gold;
                                    else offer = item.SuggestedPrice;
                                    Console.WriteLine((i) + shopper.Name + " vill köpa " + item.Name + "för " + offer + " guld");
                                    buy.Add(item);
                                    //i++;
                                }
                            }
                        }

                        Console.WriteLine("välj vad");
                        reply=Console.ReadLine();
                        Console.Write(" reply är " + reply + " som parsas till ");
                        //i = 1;//WTF?!?!
                        bool blah=int.TryParse(reply, out result);
                        Console.WriteLine(result);
                        bool villkor = ((result < 1 || result > player.Inventory.Count) || reply != "x");
                        Console.WriteLine("villkor=" + villkor);
                    } while (  ( result < 1 || result > player.Inventory.Count ) && reply !="x");

                    if (reply == "x")
                    {
                        Console.WriteLine("OK.");
                    }
                    else
                    {                        
                            player.Gold += offer;
                            shopper.Gold -= offer;

                            player.Inventory.Remove(buy[i - 1]);
                            shopper.Inventory.Add(buy[i - 1]);                        
                    }
                }



            } while (input != "0");
            Console.Clear();
            PrintLabyrint(player);
            //monster.Move(this, player );            // För att inte fastna
        }

        public double GetDistance (Player player, IShopper monster)      // ÄNDRA TILL ((int,int) position 1, (int,int) position 2)
        {

            double distance = 0;
            (int, int) playerPos;
            (int, int) monsterPos;

            playerPos.Item1 = player.Position[0];
            playerPos.Item2 = player.Position[1];
            monsterPos.Item1 = monster.Position[0];
            monsterPos.Item2 = monster.Position[1];
            //distance = Math.Sqrt(Math.Pow((player.Position[0] - monster.Position[0]), 2) + Math.Pow((player.Position[1] - monster.Position[1]), 2));
            distance = Distance(playerPos, monsterPos);
            return distance;
        }

        public double Distance ((int,int) first,(int,int) second)
        {
            double distance;
            distance=Math.Sqrt(Math.Pow((first.Item1 - second.Item1), 2) + Math.Pow((first.Item2 - second.Item2), 2));
            //Math.Sqrt(Math.Pow((player.Position[0] - monster.Position[0]), 2) + Math.Pow((player.Position[1] - monster.Position[1]), 2))
            return distance;
        }

        private void PrintLabyrint(Player player) //player gör ingenting, ta bort
        {
            for (int i = 0; i < Labyrint.GetLength(0); i++)// private void PrintLabyrint() START
            {
                for (int j = 0; j < Labyrint.GetLength(1); j++)
                {


                    if ( Labyrint[i,j]==' ')  
                    {                                                       //
                        Console.ForegroundColor = ConsoleColor.White;       //
                        Console.BackgroundColor = ConsoleColor.Black;       //
                        Console.Write(Labyrint[i,j]);                       //
                    }

                    else  
                    {
                        if (Labyrint[i, j] != ' ' ) 

                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(Labyrint[i, j]);
                        }
                    }

                    if (j == Labyrint.GetLength(1) - 1) Console.WriteLine("");
                }

            }
            Console.SetCursorPosition(4, Labyrint.GetLength(1) - 6);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("  FRODO'S  ");
            Console.SetCursorPosition(4, Labyrint.GetLength(1) - 5);
            Console.Write("SUPERMARKET");

            Console.SetCursorPosition(Labyrint.GetLength(0) -17, 3);
            Console.Write("  FRODO'S  ");
            Console.SetCursorPosition(Labyrint.GetLength(0) - 17, 4);
            Console.Write("SUPERMARKET");
            Console.SetCursorPosition(Labyrint.GetLength(1) - 10, Labyrint.GetLength(0) -5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("EXIT->");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        void EraseMonster(Monster abomination)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            int y = abomination.Position[0];
            int x = abomination.Position[1];
            //Console.SetCursorPosition(y, x);
            Console.SetCursorPosition(x, y);
            Console.Write(' ');


            


        }

        void PrintMonster ( Monster monstrosity)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            int y = monstrosity.Position[0];
            int x = monstrosity.Position[1];

            Console.SetCursorPosition(x, y);
            //Console.SetCursorPosition(y, x);
            Console.Write(monstrosity.Symbol);
            if (monstrosity is Player)
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" y " + y + " x " + x + "     ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        //void SetColorForPrint (int y, int x)
        //{
        //    if (Labyrint[y, x] == ' ')
        //    {
        //        Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
        //    }
        //    else
        //    {
        //        //Console.ForegroundColor = ConsoleColor.Blue; Console.BackgroundColor = ConsoleColor.Blue;
        //        Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
        //    }
        //}

    }



}





