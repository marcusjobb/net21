// -----------------------------------------------------------------------------------------------
//  Game.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    using POCO;
    using System;
    using static Helpers.PrintHelpers;

    public class Game
    {
        private readonly Player player = new();
        private Monster mob;
        private Menu roomMenu;
        private int encounterChance;
        private Maze maze;
        private int EncounterChance { get => encounterChance; set => encounterChance = (value > 100 || value < 0) ? value > 100 ? 100 : 0 : value; }

        public Game(int percentEncounterChance = 10)
        {
            EncounterChance = percentEncounterChance;
            maze = new(EncounterChance);
        }
        public void Start()
        {   
            player.Name = GameHelper.Intro();
            Town cave = new() { Name = "the Cave" };
            var keepPlaying = cave.Enter(player);
            var changeX = 0;
            var changeY = 0;

            while (keepPlaying && !player.Dead && player.Level < 10)
            {
                (MazeRoom room, var noEncounter) = maze.ShowMaze(changeX,changeY);
                if (!noEncounter) Encounter();
                roomMenu = null;
                roomMenu = GameHelper.GetRoomMenu(player, room);

                if (!player.Dead&&player.Level<10)
                {
                    (keepPlaying,changeX,changeY) = ShowRoom(cave);
                }
                else
                {
                    GameOver();
                }
            }
        }


        private (bool,int,int) ShowRoom(Town town)
        {
            string choice;
            (bool keepPlaying,int changeX,int changeY) returnThis = (true,0,0);
            do
            {
                roomMenu.UpdateMenuItem($"Current health: {player.CurrentHealth} / {player.MaxHealth}", 3);

                if (mob != null) AddMobToRoomMenu();
                else RemoveMobFromRoomMenu();

                choice = roomMenu.UseMenu();

                if (choice.StartsWith("Show")) player.ShowStats();
                else if (choice.StartsWith("Attack")) Fight();

            } while (!player.Dead && choice != "Head back to town." && !choice.StartsWith("Go"));

            if (choice == "Head back to town.") returnThis = (GameHelper.PortalStone(player, town),0,0);
            else
            {
                string lastMove = choice.Substring(choice.IndexOf(' ') + 1, choice.IndexOf('.') - (choice.IndexOf(' ') + 1));
                returnThis.changeY = lastMove == "North" || lastMove == "South" ? lastMove == "North" ? -1 : +1 : 0;
                returnThis.changeX = lastMove == "East" || lastMove == "West" ? lastMove == "East" ? +1 : -1 : 0;
            }

            return returnThis;
        }

        private void RemoveMobFromRoomMenu()
        {
            roomMenu.UpdateMenuItem($"", 4);
            if (roomMenu.MenuItems.Find(item => item.StartsWith("Attack")) != null) roomMenu.MenuItems.RemoveAt(roomMenu.MenuItems.Count - 3);
        }

        private void AddMobToRoomMenu()
        {
            roomMenu.UpdateMenuItem($"There's a {mob.FullName} in the room!", 4);
            roomMenu.MenuItems.Insert(roomMenu.MenuItems.Count - 2, $"Attack {mob.Alias}.");
        }

        private void Encounter()
        {
            mob = new Monster(player.Level);
            Console.ForegroundColor = ConsoleColor.Red;
            BorderPrint($"You encounter a {mob.FullName}!");
            SetColors();
            Menu encounter = GameHelper.EncounterMenu(player, mob);
            var choice = encounter.UseMenu();
            if (choice == "Fight!") Fight();
            else Flee();
        }

        private void Flee()
        {
            BorderPrint($"As you turn and flee like a chicken, {mob.Alias} hits you in the back!");
            player.TakeDamage(mob.Attack(false),true);
            Hold();
        }

        private void Fight()
        {
            var round = 1;
            while (player.Alive && mob.Alive)
            {
                CombatRoundPrint(round);
                mob.TakeDamage(player.Attack(true),false);
                if (mob.Alive) player.TakeDamage(mob.Attack(false),true);
                if (mob.Alive && player.Alive)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{player.Name}: {player.CurrentHealth} hp, {mob.Name}: {mob.CurrentHealth} hp.");
                    SetColors();
                    round++;
                    Hold();
                }
            }
            if (player.Alive) player.Loot(mob.Corpse());
            mob = null;
        }

        private void GameOver()
        {
            if (player.Level == 10)
            {
                BorderPrint("Congratulations you've reached level 10 and won the game!");
                Menu endgame = GameHelper.EndGameMenu();
                string choice = endgame.UseMenu();
                if (choice == "Of course I deserve to be the ruler! (Challenge Dungeon Lord)") GameHelper.BossFight(player);

            }
            string[] go = { "GAME OVER!", "Thanks for playing, hope you enjoyed it.", "", "Why not have another go?" };
            BorderPrint(go);
        }

        
    }
}