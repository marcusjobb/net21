using System;
using System.Collections.Generic;
using System.Linq;
using GoFight._action;
using GoFight._mainMenu;
using GoFight._player;

namespace GoFight._store
{
    class store
    {
        public player buyStrength(player ply)
        {
            return new player
            {
                plyerName = ply.plyerName,
                Email = ply.Email,
                Level = ply.Level,
                playerHealthPoint = ply.playerHealthPoint,
                playerMaxAttack = ply.playerMaxAttack,
                playerMaxBlock = ply.playerMaxBlock,
                playerGold = ply.playerGold - 20,
                sTrength = ply.sTrength + 1,
                touGHness = ply.touGHness,

            };

        }

        public player useStrength(player ply)
        {

            return new player
            {
                plyerName = ply.plyerName,
                Email = ply.Email,
                Level = ply.Level,
                playerHealthPoint = ply.playerHealthPoint + 20,
                playerMaxAttack = ply.playerMaxAttack,
                playerMaxBlock = ply.playerMaxBlock,
                playerGold = ply.playerGold,
                sTrength = ply.sTrength - 1,
                touGHness = ply.touGHness,
            };
        }

        public player buyDefense(player ply)
        {
            return new player
            {
                plyerName = ply.plyerName,
                Email = ply.Email,
                Level = ply.Level,
                playerHealthPoint = ply.playerHealthPoint,
                playerMaxAttack = ply.playerMaxAttack,
                playerMaxBlock = ply.playerMaxBlock,
                playerGold = ply.playerGold - 50,
                sTrength = ply.sTrength,
                touGHness = ply.touGHness + 1,
            };
        }

        public player useDefense(player ply)
        {
            ply.Level = ((level)(int)ply.Level + 1);
            return new player
            {
                plyerName = ply.plyerName,
                Email = ply.Email,
                Level = ply.Level,
                playerHealthPoint = ply.playerHealthPoint,
                playerMaxAttack = ply.playerMaxAttack,
                playerMaxBlock = ply.playerMaxBlock,
                playerGold = ply.playerGold,
                sTrength = ply.sTrength,
                touGHness = ply.touGHness - 1,
            };
        }

        public void inTheStore(player ply)
        {
            int numStorMenu = 0;
            mainMenu.ShopMenu();
            action act = new();
            while (true)
            {

                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out numStorMenu))
                {
                    if (numStorMenu > 0 && numStorMenu < 6) break;
                    else Console.WriteLine("Invalid value, try again");
                }
                else Console.WriteLine("Invalid value, try again");
            }


            store sto = new();
            switch (numStorMenu)
            {
                case 1:
                    int count;
                    Console.WriteLine("Buy Strength Amulet");
                    Console.WriteLine("One Strength Amulet Costs 20 Gold pieces");
                    ply.show_Details(ply);
                    Console.WriteLine("Your Account Befor Buying");
                    Console.Read();
                    if (ply.playerGold >= 20)
                    {
                        ply = buyStrength(ply);
                        ply.show_Details(ply);
                        Console.WriteLine("Your Account After Buying");
                    }
                    else Console.WriteLine("You do not have enough Gold");
                    Console.Read();
                    Console.WriteLine(" Perss Enter to Exit");
                    Console.Read();
                    mainMenu.mainMenuSelection();
                    act.sitting(ply);
                    break;


                case 2:
                    Console.WriteLine("Use Strength Amulet");
                    Console.WriteLine("One Strength Amulet Increases 20 Healthy points.");
                    ply.show_Details(ply);
                    Console.WriteLine("Your Account Befor Buying");
                    Console.Read();
                    if (ply.sTrength > 0)
                    {
                        ply = useStrength(ply);
                        ply.show_Details(ply);
                        Console.WriteLine("Your Account After Buying");
                    }
                    else Console.WriteLine("You do not have any Strength Amulet");
                    Console.Read();
                    Console.WriteLine(" Perss Enter to Exit");
                    Console.Read();
                    mainMenu.mainMenuSelection();
                    act.sitting(ply);
                    break;
                   

                case 3:
                    Console.WriteLine("Buy DefenSe Amulet");
                    Console.WriteLine("One DefenSe Amulet Costs 50 Gold pieces");
                    ply.show_Details(ply);
                    Console.WriteLine("Your Account Befor Buying");
                    Console.Read();
                    if (ply.playerGold >= 50)
                    {
                        ply = buyDefense(ply);
                        ply.show_Details(ply);
                        Console.WriteLine("Your Account After Buying");
                    }
                    else Console.WriteLine("You do not have enough Gold");
                    Console.Read();
                    Console.WriteLine(" Perss Enter to Exit");
                    Console.Read();
                    mainMenu.mainMenuSelection();
                    act.sitting(ply);
                    break;
                    

                case 4:
                    Console.WriteLine("Use DefenSe Amulet");
                    Console.WriteLine("One DefenSe Amulet Move you Direct To The Next Level.");
                    ply.show_Details(ply);
                    Console.WriteLine("Your Account Befor Buying");
                    Console.Read();
                    if (ply.touGHness > 0)
                    {
                        ply = useDefense(ply);
                        ply.show_Details(ply);
                        Console.WriteLine("Your Account After Buying");
                    }
                    else Console.WriteLine("You do not have any DefenSe Amulet");
                    Console.Read();
                    Console.WriteLine(" Perss Enter to Exit");
                    Console.Read();
                    mainMenu.mainMenuSelection();
                    act.sitting(ply);
                    break;
                    

                default:    //5) ---> exit
                    mainMenu.mainMenuSelection();
                    act.sitting(ply);
                    Console.Read();
                    break;

            }
        }
    }
}
