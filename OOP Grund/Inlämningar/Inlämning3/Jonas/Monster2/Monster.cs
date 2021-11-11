using System;
using System.Collections.Generic;

namespace TheGame001
{
    public class Monster : IShopper
    {
        Random rnd = new Random();
        protected string name;
        protected char symbol;
        protected int[] position;
        private List<(int, int)> recentlyVisitedPositions=new List<(int, int)>();
        protected int xp;
        protected int hp;
        protected int hitChance;
        protected int hitDamage;
        protected int damageReduction;
        protected List<Item> wantsToBuy;
        protected List<Item> wantsToSell;
        protected List<Item> inventory;
        protected int gold;
        protected bool isHostile;
        protected bool isAlive;
 
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
 
        public char Symbol
        {
            get => symbol;
            set
            {
                symbol = value;
            }
        }
 
        // Längd 2; x & y (Hellre en tuplet?)
        public int[] Position
        {
            get => position;
            set
            {
                position = value;
            }
        }
 
        public List<(int,int)> RecentlyVisitedPositions
        {
            get => recentlyVisitedPositions;
            set
            {
                recentlyVisitedPositions = value;
            }
        }
 
        public int  HP
        {
            get => hp;
            set
            {
                hp = value;
            }
        }
 
        public int XP
        {
            get => xp;
            set
            {
                xp = value;
            }
        }
 
        public virtual int HitChance
        {
            get => hitChance;
            set
            {
                if (value > 100) hitChance = 100;
                if (value < 0) hitChance = 0;
                hitChance = value;
            }
        }
 
        public virtual int HitDamage
        {
            get => hitDamage;
            set
            {
                hitDamage = value;
            }
        }
 
        public int DamageReduction                 // Monster använder inte DR, men den behövs i Fight som tar monster monster parametrar
        {                                          // , så den sätts till 0 för monstren
            get => damageReduction;
            set
            {
                damageReduction = value;
            }
        }
  
        public int Gold
        {
            get => gold;
            set
            {
                if (value < 0) gold = 0;
                gold = value;
            }
        }
 

        public bool IsHostile
        {
            get => isHostile;
            set
            {
                 
                isHostile = value;
            }
        }
 
        public bool IsAlive
        {
            get => isAlive;
            set
            {
                isAlive = value;
            }
        }

        public List<Item> Inventory

        {
            get => inventory;
            set
            {
                inventory = value;
            }
        }

        public List<Item> WantsToBuy

        {
            get => wantsToBuy;
            set
            {
                wantsToBuy = value;
            }
        }

        public List<Item> WantsToSell

        {
            get => wantsToSell;
            set
            {
                wantsToSell = value;
            }
        }

        public virtual void Move(Game myGame, Player player)
        {
            //Random rnd = new Random();
            bool go_on= true;
            //CheckVisited();
            do
            {
                int direction = rnd.Next(1, 6);
                int x = Position[1];
                int y = Position[0];
                if (IsAlive == false) direction = 5;
                switch (direction)
                {
                    case 1://Upp
                            
                        if (myGame.Labyrint[y-1, x] == ' ' && !(myGame.CheckForMonsters(y-1, x, player))  )//&& ( !( recentlyVisitedPositions[recentlyVisitedPositions.Count -1].Item1 == y-1) && (recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item2 == x) ) )

                            {
                            this.recentlyVisitedPositions.Add((position[0],position[1]));
                            Position[0]--;
                            go_on = false;
                        }
                        //go_on = false;
                        break;

                    case 2://ner
                        if (myGame.Labyrint[y + 1, x] == ' ' && !(myGame.CheckForMonsters(y + 1, x,player)) )//&& (!(recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item1 == y + 1) && (recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item2 == x)))

                        {
                            this.recentlyVisitedPositions.Add((position[0], position[1]));
                            Position[0]++;
                            go_on = false;
                        }
                        //go_on = false;
                        break;
                    case 3://höger
                        if (myGame.Labyrint[y , x+1] == ' ' && !(myGame.CheckForMonsters(y, x +1,player)) ) //&& (!(recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item1 == y ) && (recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item2 == x +1 )))

                        {
                            this.recentlyVisitedPositions.Add((position[0], position[1]));
                            Position[1]++;
                            go_on = false;
                        }
                        //go_on = false;
                        break;
                        
                    case 4://vänster
                        if (myGame.Labyrint[y, x -1] == ' ' && !(myGame.CheckForMonsters(y, x - 1,player)) )// && (!(recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item1 == y ) && (recentlyVisitedPositions[recentlyVisitedPositions.Count - 1].Item2 == x -1 )))

                        {
                            this.recentlyVisitedPositions.Add((position[0], position[1]));
                            Position[1]--;
                            go_on = false;
                        }
                        //go_on = false;
                        break;
                    case 5: 
 
                       go_on = false;
                        break;
                    default:
                        break;
                }
                if (recentlyVisitedPositions.Count > 8)
                {
                    recentlyVisitedPositions.Clear();
                    recentlyVisitedPositions.Add((position[0],position[1]));
                }
            } while (go_on);



        }
        //public bool CheckVisited( )
        //{
        //    bool visited=false;
        //    foreach (var item in recentlyVisitedPositions)
        //    {
        //        if ( item.Item1 == position[0] && item.Item2 == position[1])
        //        {
        //            visited = true;
        //        }
        //    }

        //    return visited;
        //}

        public Item GetStuff ( int Price)
        {
            int choice = rnd.Next(0, Miscellaneous.AllTheThings.Count -1);

            Item returnMe = Miscellaneous.AllTheThings[choice];
            //Miscellaneous.AllTheThings[choice]
            if (Miscellaneous.AllTheThings[choice].SuggestedPrice < Price)
            {
                return returnMe;
            }
            else
            {
                return Miscellaneous.ExistingThings["Get"];
            }
        }

        public Monster(string myName, char sign, int Exp)
        {
            Random rnd = new Random();
            
            this.name = myName;
            this.symbol = sign;
            //int x = rnd.Next(3, 9);
            //int y = rnd.Next(3, 9);
            this.position = new int[] { 0, 0 };
            this.xp = Exp;
            this.hp = rnd.Next(80, 120)*xp/250;
            this.hitChance = rnd.Next(10, 25) * xp / 250;
            this.hitDamage = rnd.Next(5, 15) * xp / 250;
            this.damageReduction = 0;
            //this.inventory = new List<string> { "Skjorta", "Dolk" };
            //this.inventory = new List<Item> { Miscellaneous.ExistingThings["Yxa"], Miscellaneous.ExistingThings["PepsiCola"]};
            this.inventory = new List<Item> { GetStuff(xp/600) };
            this.wantsToSell = new List<Item> { this.inventory[0]};
            this.wantsToBuy = new List<Item> { GetStuff(10000)};
            this.gold = rnd.Next(0, 20)*xp/250;
 
            //this.WantsToBuy = new List<(string, int)>
            //                {
            //    ("Dolk",20 )
            //                };

            //this.WantsToSell = new List<(string, int)>
            //                {
            //    ("Svärd",40 )
            //                };

            int tmp = rnd.Next(1, 9);
            isHostile = true;
            if (tmp < 5) isHostile = false;
             
            this.isAlive=true;



        }
    }

}





