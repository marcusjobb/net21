using System;
using System.Collections.Generic;
using GoFight._player;
using GoFight._monster;
using GoFight._mainMenu;
using GoFight._store;

namespace GoFight._action
{
    class action
    {
        player ply = new();
        monster mon = new();

        List<player> players = new List<player>()
        {
            new player {plyerName="Niklas", Level = level.first, playerHealthPoint=200, playerGold=0, sTrength=0, touGHness=0},
            new player {plyerName="Anderss", Level = level.fifth, playerHealthPoint=155, playerGold=120, sTrength=2, touGHness=3},
            new player {plyerName="Joly", Level = level.second, playerHealthPoint=170, playerGold=82, sTrength=1, touGHness=1},
            new player {plyerName="Ommer", Level = level.ninth, playerHealthPoint=120, playerGold=150, sTrength=3, touGHness=4},
            new player {plyerName="Emma", Level = level.third, playerHealthPoint=80, playerGold=0, sTrength=1, touGHness=2}
        };

        public void goToPlay()
        {
            int numStartMenu = 0;
            bool flag = true;
            mainMenu.startMenu();
            while (flag)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out numStartMenu))
                {
                    if (numStartMenu > 0 && numStartMenu < 4) break;
                    else Console.WriteLine("Invalid value, try again");
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numStartMenu)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string input1 = Console.ReadLine();
                    int count = 0;
                    if (players.Exists(ply1 => ply1.plyerName.Contains(input1)))
                    {
                        player ply1 = players.Find(ply1 => ply1.plyerName == input1);
                        count = players.IndexOf(ply1);
                        ply1 = players[count];
                        mainMenu.mainMenuSelection();
                        sitting(ply1);
                    }
                    else Console.WriteLine("The Name you gave isnot exist");
                    break;

                case 2:

                    players.Add(ply);
                    Console.WriteLine("\n");
                    Console.WriteLine(" ....     CREATION A NEW A CCOUNT     .... ");
                    Console.WriteLine(" ...   Please fill your informations:  ... ");
                    Console.WriteLine("___________________________________________");
                    Console.Write("Your name: ");
                    ply.plyerName = Console.ReadLine();
                    Console.WriteLine("___________________________________________");
                    Console.Write("your E-Mail: ");
                    ply.Email = Console.ReadLine();
                    Console.WriteLine("___________________________________________");
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(".. You SUCCEEDED To Create a New Account ..");
                    Console.WriteLine("___________________________________________");
                    Console.WriteLine(" ........    Press << ENTER >>    ........ ");
                    Console.WriteLine(" ...    To Go Back To The Start Menu   ... ");

                    Console.WriteLine("  (( And << LOG IN >> With new Acount ))   ");
                    ply.Level = level.first;
                    ply.playerHealthPoint = 200;
                    ply.playerGold = 0;
                    ply.sTrength = 0;
                    ply.touGHness = 0;
                    break;
                default:    //3) ---> exit
                    Environment.Exit(0);
                    break;
            }
            Console.Read();
        }

        public void sitting(player ply)
        {
            int numMainMenu = 0;
            bool flag = true;

            while (flag)
            {
                Console.Write("Your choises is << 1  -  4 >>: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numMainMenu))
                {
                    if (numMainMenu > 0 && numMainMenu < 5) break;
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numMainMenu)
            {
                case 1:
                    Console.WriteLine("Enter To Continu");                   
                    goAdventure(ply);
                    break;

                case 2:
                    int numShowDetails = 0;
                    mainMenu.detailsMenu();
                    while (flag)
                    {

                        string input1 = Console.ReadLine();
                        if (int.TryParse(input1, out numShowDetails))
                        {
                            if (numShowDetails > 0 && numShowDetails < 4) break;
                            else Console.WriteLine("Invalid value, try again");
                        }
                        else Console.WriteLine("Invalid value, try again");
                    }

                    switch (numShowDetails)
                    {
                        case 1:
                            ply.show_Details(ply);
                            Console.WriteLine("Perss Enter to Exit");
                            Console.Read();
                            mainMenu.mainMenuSelection();
                            sitting(ply);
                            Console.Read();
                            break;

                        case 2:
                            Console.Write("Please Write your other accounts Name: ");
                            string input2 = Console.ReadLine();
                            int count = 0;
                            if (players.Exists(ply2 => ply2.plyerName.Contains(input2)))
                            {
                                player ply2 = players.Find(ply2 => ply2.plyerName == input2);
                                count = players.IndexOf(ply2);
                                ply2 = players[count];
                                ply.show_Details(ply2);
                            }
                            else Console.WriteLine("The Name you gave isnot exist");
                            Console.WriteLine("Perss Enter to Exit");
                            Console.Read();
                            mainMenu.mainMenuSelection();
                            sitting(ply);
                            Console.Read();
                            break;

                        case 3:
                            mainMenu.mainMenuSelection();
                            sitting(ply);
                            Console.Read();
                            break;

                    }
                    break;

                case 3:
                    store sto = new();
                    sto.inTheStore(ply);
                    break; 
                    

                default:  //4
                    mainMenu.startMenu();
                    goToPlay();
                    Console.Read();
                    break;
            }
        }


        public void goAdventure(player ply)
        {

            while (true)
            {
                switch (ply.Level)
                {
                    case (level.first):
                        ply.playerMaxAttack = 16;
                        ply.playerMaxBlock = 1;
                        mon.monName = monsterName.Alpha;
                        mon.monsterHealthPoint = 60;
                        mon.monsterMaxAttack = 12;
                        mon.monsterMaxBlock = 1;
                        mon.monsterGold = 10;
                        break;

                    case (level.second):
                        ply.playerMaxAttack = 17;
                        ply.playerMaxBlock = 2;
                        mon.monName = monsterName.Beta;
                        mon.monsterHealthPoint = 70;
                        mon.monsterMaxAttack = 14;
                        mon.monsterMaxBlock = 2;
                        mon.monsterGold = 20;
                        break;

                    case (level.third):
                        ply.playerMaxAttack = 18;
                        ply.playerMaxBlock = 3;
                        mon.monName = monsterName.Gamma;
                        mon.monsterHealthPoint = 80;
                        mon.monsterMaxAttack = 16;
                        mon.monsterMaxBlock = 3;
                        mon.monsterGold = 30;
                        break;

                    case (level.fourth):
                        ply.playerMaxAttack = 19;
                        ply.playerMaxBlock = 4;
                        mon.monName = monsterName.Delta;
                        mon.monsterHealthPoint = 90;
                        mon.monsterMaxAttack = 18;
                        mon.monsterMaxBlock = 4;
                        mon.monsterGold = 40;
                        break;

                    case (level.fifth):
                        ply.playerMaxAttack = 20;
                        ply.playerMaxBlock = 5;
                        mon.monName = monsterName.Epsilon;
                        mon.monsterHealthPoint = 100;
                        mon.monsterMaxAttack = 20;
                        mon.monsterMaxBlock = 5;
                        mon.monsterGold = 50;
                        break;

                    case (level.sixth):
                        ply.playerMaxAttack = 21;
                        ply.playerMaxBlock = 6;
                        mon.monName = monsterName.Zeta;
                        mon.monsterHealthPoint = 110;
                        mon.monsterMaxAttack = 22;
                        mon.monsterMaxBlock = 6;
                        mon.monsterGold = 60;
                        break;

                    case (level.seventh):
                        ply.playerMaxAttack = 22;
                        ply.playerMaxBlock = 7;
                        mon.monName = monsterName.Eta;
                        mon.monsterHealthPoint = 120;
                        mon.monsterMaxAttack = 24;
                        mon.monsterMaxBlock = 7;
                        mon.monsterGold = 70;
                        break;

                    case (level.eighth):
                        ply.playerMaxAttack = 23;
                        ply.playerMaxBlock = 8;
                        mon.monName = monsterName.Theta;
                        mon.monsterHealthPoint = 130;
                        mon.monsterMaxAttack = 26;
                        mon.monsterMaxBlock = 8;
                        mon.monsterGold = 80;
                        break;

                    case (level.ninth):
                        ply.playerMaxAttack = 24;
                        ply.playerMaxBlock = 9;
                        mon.monName = monsterName.Iota;
                        mon.monsterHealthPoint = 140;
                        mon.monsterMaxAttack = 28;
                        mon.monsterMaxBlock = 9;
                        mon.monsterGold = 90;
                        break;

                    case (level.tenth):
                        ply.playerMaxAttack = 25;
                        ply.playerMaxBlock = 10;
                        mon.monName = monsterName.Koppa;
                        mon.monsterHealthPoint = 150;
                        mon.monsterMaxAttack = 30;
                        mon.monsterMaxBlock = 10;
                        mon.monsterGold = 100;
                        break;
                }

                Console.Read();
                ply.show_Details(ply);
                Console.WriteLine("Do You Want To Go Back To The Main Menu (y/N):");
                Console.WriteLine("Or Perss Enter to Fight");
                string st = Console.ReadLine();
                if (st == "y" || st == "Y")
                {
                    mainMenu.mainMenuSelection();
                    sitting(ply);
                    break;
                }
                Console.Read();
                while (true)
                {
                    player2monster(ply, mon);
                    if (mon.monsterHealthPoint <= 0) break;
                    Console.Read();
                    monster2player(ply, mon);
                    if (ply.playerHealthPoint <= 0) break;
                    Console.Read();

                }
                if (ply.playerHealthPoint <= 0) break;
            }
        }

        public void player2monster(player ply, monster mon)
        {
            Console.Clear();
            Console.Read();
            Console.WriteLine("\n\n");
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" ............                F I G H T I N G                 ............ ");
            Console.WriteLine(" ........                  T H E  M O N S T E R                  ........ ");
            Console.WriteLine("==========================================================================");
            int plyAttack = ply.playerAttack();
            int monBlock = mon.monsterBlock();

            int dmg2monster = plyAttack - monBlock;

            if (dmg2monster > 0)
            {
                mon.monsterHealthPoint -= dmg2monster;
            }
            else dmg2monster = 0;
            Console.WriteLine("==========================================================================");
            Console.WriteLine();
            Console.WriteLine($" ...                                {(ply.plyerName).ToUpper()}                              ... ");
            Console.WriteLine();
            Console.WriteLine(" ...                           A T T A C K S !                         ... ");
            Console.WriteLine();
            Console.WriteLine($" ...                      The Monster  <<  {(mon.monName).ToString().ToUpper()}  >>                   ... ");
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine($" ...                         <<< {dmg2monster} >>> Damage                           ... ");
            Console.WriteLine("___________________________________________________________________________");

            Console.WriteLine($" ...         The Monster  {(mon.monName).ToString().ToUpper()} Has  :  <<< {mon.monsterHealthPoint} >>>  Helthy Point          ... ");
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("                          <<<<  E N T E R  >>>>                           ");

            if (mon.monsterHealthPoint <= 0)
            {
                if (ply.Level == level.tenth)
                {
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("       -----<<<((((    C 0 N G R A T U L A T I O N    ))))>>>-----                         ");
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("       -----<<<((((           Y O U   W I N           ))))>>>-----                         ");
                    Console.WriteLine("*************************************************************************");

                }
                else
                {
                    ply.Level = ((level)(int)ply.Level + 1);
                    ply.playerGold += mon.monsterGold;
                    
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine($"                 Y O U   A R E   V E R Y    G 0 0 D                      ");
                    Console.WriteLine($"             you leved up and you are now level :  {ply.Level}           ");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                 G O   T O   T H E   N E X T   L E V E L                  ");
                    Console.WriteLine($"                             {((ply.Level).ToString()).ToUpper()}                            ");
                    Console.WriteLine("==========================================================================");
                    Console.Read();
                }

            }

        }

        public void monster2player(player ply, monster mon)
        {
            Console.Clear();
            Console.Read();
            Console.WriteLine("\n\n");
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" ............                F I G H T I N G                 ............ ");
            Console.WriteLine(" ........                  T H E  M O N S T E R                  ........ ");
            Console.WriteLine("==========================================================================");
            int monAttack = mon.mosterAttack();
            int plyBlock = ply.playerBlock();

            int dmg2player = monAttack - plyBlock;

            if (dmg2player > 0)
            {
                ply.playerHealthPoint -= dmg2player;
            }
            else dmg2player = 0;
            Console.WriteLine("==========================================================================");
            Console.WriteLine();
            Console.WriteLine($" ...                                {(mon.monName).ToString().ToUpper()}                              ... ");
            Console.WriteLine();
            Console.WriteLine(" ...                           A T T A C K S !                         ... ");
            Console.WriteLine();
            Console.WriteLine($" ...                      The Player  <<  {(ply.plyerName).ToUpper()}  >>                   ... ");
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine($" ...                         <<< {dmg2player} >>> Damage                           ... ");
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine($" ...          The Player  {(ply.plyerName).ToUpper()}  has :  <<< {ply.playerHealthPoint} >>>  Helthy Point          ... ");
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("                          <<<<  E N T E R  >>>>                           ");

            if (ply.playerHealthPoint <= 0)
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("          -----<<<((((   G A M E   O V E R    ))))>>>-----               ");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("          -----<<<((((    T R Y   A G A I N   ))))>>>-----               ");
                Console.WriteLine("*************************************************************************");
            }

        }
    }
}
