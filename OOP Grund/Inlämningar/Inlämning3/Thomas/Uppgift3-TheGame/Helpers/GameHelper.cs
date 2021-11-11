// -----------------------------------------------------------------------------------------------
//  GameHelper.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame
{
    using Enums;
    using POCO;
    using System;
    using System.Collections.Generic;
    using static Helpers.PrintHelpers;

    internal static class GameHelper
    {
        private static Random rng = new();

        internal static Menu GetRoomMenu(Player pc, MazeRoom room)
        {
            string[] roomDescriptions =
            {
                "This room looks oddly familiar...",
                "You could swear you've been here before...",
                "Is that something moving in the corner?",
                "Didn't you just leave this room?",
                "What's that over there?",
                "You are feeling a bit lost...",
                "What was that?",
                "Is this the right way?",
                "You know just where you are."
            };
            List<string> roomList = new() { "The Evershifting Maze,", $"{roomDescriptions[rng.Next(0, roomDescriptions.Length)]}" };
            roomList.Add($"Level: {pc.Level} Xp: {pc.Xp} / {pc.XpToNextLevel} Gold: {pc.Gold}");
            roomList.Add($"Current health: {pc.CurrentHealth} / {pc.MaxHealth}");
            roomList.Add("");
            List<string> exitList = new();

            if ((room.Exits & Direction.North) == Direction.North) exitList.Add("Go North.");
            if ((room.Exits & Direction.East) == Direction.East) exitList.Add("Go East.");
            if ((room.Exits & Direction.South) == Direction.South) exitList.Add("Go South.");
            if ((room.Exits & Direction.West) == Direction.West) exitList.Add("Go West.");

            roomList.AddRange(exitList);

            roomList.Add("Show player stats.");
            roomList.Add("Head back to town.");

            var roomMenu = new Menu(roomList, 2, 3);
            return roomMenu;
        }

        internal static Menu EncounterMenu(Player pc, Monster mob)
        {
            List<string> encounterList = new()
            {
                "Encounter!",
                $"You have encountered a {mob.FullName}.",
                $"Your health: {pc.CurrentHealth} / {pc.MaxHealth}",
                "Fight!",
                "Flee!"
            };
            var encounterMenu = new Menu(encounterList, 1, 2);
            return encounterMenu;
        }
        internal static bool PortalStone(Player pc, Town town)
        {
            string[] portalStone =
                    {
                        "A shimmering portal appears before you as you activate your portal stone.",
                        "You step trough and find yourself back in \"town\"."
                    };
            BorderPrint(portalStone);
            var keepPlaying = town.Enter(pc);
            return keepPlaying;
        }
        internal static string Intro()
        {
            string[] intro =
            {
                "You, the hero of our story are currently standing in a dark cavern.",
                "Well, when I say \"hero\" what I actually mean is, let's be honest",
                "about it.... \"MONSTER\"! You are hired by the resident Dungeon Lord",
                "to track down and \"expel\" troublesome heroes and other do-gooders who",
                "come poking around, aswell as keeping the local, feral, monster poulation",
                "under control.",
                "",
                "As our story begin, what would you like to be called?"
            };
            BorderPrint(intro, false);
            Console.Write("Name: ");
            return Console.ReadLine().Trim();
        }

        internal static Menu EndGameMenu()
        {
            List<string> endGameList = new()
            {
                "Congratulations! You beat the game!",
                "You could either bask in the glory of knowing you are the Dungeon Lord's",
                "most elite minion or......",
                "Why not challenge the Dungeon Lord and become the ruler yourself....",
                "",
                "You feel that you are at full health and ready for anything.",
                "What are you going to do?",
                "Of course I deserve to be the ruler! (Challenge Dungeon Lord)",
                "Quit while I'm ahead. (Exit game)"
            };
            Menu endGameMenu = new(endGameList, 1, 6);
            return endGameMenu;

        }

        internal static void BossFight(Player player)
        {
            player.CurrentHealth = player.MaxHealth;
            Player boss = player.Clone();
            SetUpBoss(boss);
            var round = 1;
            while (player.Alive && boss.Alive)
            {
                CombatRoundPrint(round);
                boss.TakeDamage(player.Attack(true),false);
                if (boss.Alive) player.TakeDamage(boss.Attack(false),true);
                if (boss.Alive && player.Alive)
                {
                    Console.WriteLine($"{player.Name}: {player.CurrentHealth} hp, {boss.Name}: {boss.CurrentHealth} hp.");
                    round++;
                    Hold();
                }
            }
        }
        private static void BossDeath()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            BorderPrint("The Dungeon Lord is DEAD!, ALL HAIL THE DUNGEON LORD!");
            SetColors();
        }

        private static void SetUpBoss(Player boss)
        {
            boss.Name = "The Dungeon Lord";
            boss.Alias = "The Dungeon Lord";
            boss.EquipWeapon(Equipment.BossWeapon);
            boss.EquipArmor(Equipment.BossArmor);
            boss.DeathScene = new Player.Scene(BossDeath);
            boss.Defense = 14;
            boss.Offense = 14;
        }
    }

}