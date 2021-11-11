using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Helpers;
using TheGame.Characters;
using TheGame.GameStructure;
using static TheGame.Helpers.UserExperience;
using static TheGame.Helpers.StringHelpers;
using static TheGame.DisplayMethods.Display;
using static TheGame.GameAssets.ArtAssets;
using static TheGame.GameAssets.StoryStrings;

namespace TheGame
{
    public class Game
    {

        // Control the text animation speed. Easier to change quickly for testing purposes.
        private int textSpeed = 25;           // 25
        private int textSpeedCombat = 8;    // 8
        private Player currentPlayer;
        private BaseMonster AnonMonster;
        private BaseMonster GenericMonster;
        private SurprisedElectricRodent SurprisedElectricRodent;
        private SpookyScarySkeleton SpookySkeleton;
        // Monster array which is to be populated with monsters. Stored in an array to make it easier to randomize monster spawn by using the array index.
        private BaseMonster[] monsterArray;
        // Random number generator, to be used here and there.
        internal static Random RandomGenerator = new();
        // List which should contain "dead" or successful players/previous game attempts, can be used as a "highscore" of sorts.
        internal static List<Player> fallenPlayers = new();
        internal static List<Player> victoryPlayers = new();

        // Constructor for the game, instantiates the game characters and the monster array. This might not be a proper way of doing things, but it seems to work.
        public Game()
        {
            currentPlayer = new();
            AnonMonster = new();
            GenericMonster = new();
            SpookySkeleton = new();
            SurprisedElectricRodent = new();
            // Some monsters are meant to be "generic/fodder" monsters, they are given a name here instead of in their class, since they're the same class.
            AnonMonster.Name = "Seasonally appropriate Monster";
            GenericMonster.Name = "Creature of the Night";
            // The monster array contains more than one SpookySkeleton monster, to bias the random monster spawner to spawn more skeletons.
            // Because spooky scary skeletons have more fun.
            monsterArray = new BaseMonster[] { AnonMonster, GenericMonster, SurprisedElectricRodent, SpookySkeleton, SpookySkeleton};
        }

        #region Game StartUp
        /// <summary>
        /// When start is called, starts the game by calling on several other methods.
        /// Shows an intro for the game. Lets the user input a name.
        /// Initalises the ingame menu, which also controls the flow of the game.
        /// </summary>
        public void Start()
        {
            GameIntro();
            GetPlayerName();
            InGameMenu();
        }

        public void GameIntro()
        {
            Console.Clear();
            Console.CursorVisible = false;
            AnimateTextCenter("\n\n\n\n\n\n\n\nYou find yourself in an adventurers camp, on the outskirts of a small village.\n", textSpeed);
            AnimateTextCenter("After a calm and restful night, you prepare for adventure.\n", textSpeed);
            AnimateTextCenter("You are an adventurer. A mercenary for hire. A hunter of beasts. A knight who on occasion have been known to say \"Ni!\"\n", textSpeed);
            AnimateTextCenter("It does not matter. Whoever you may be or want to be, you'll first need a name.\n", textSpeed);
            AnimateTextCenter("Who are you?\n");
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Lets the user enter a name. Can be left empty to get one automatically. You can also enter a cheatcode to get more health, damage and gold, and speed up the text.
        /// </summary>
        public void GetPlayerName()
        {
            Console.CursorVisible = false;
            var userName = Validation.ValidatedName();
            currentPlayer.Name = userName;
            if (currentPlayer.Name == "")
                currentPlayer.Name = "The Nameless Hero";
            if (currentPlayer.Name == "1337")
            {
                currentPlayer.HPMax = 9001;
                currentPlayer.HP = 9001;
                currentPlayer.Gold = 1000;
                currentPlayer.Strength = 100;
                textSpeed = 1;
                textSpeedCombat = 1;
            }
            Console.WriteLine();
            CenterPressEnterToContinue();
        }
        #endregion

        #region Game menu
        /// <summary>
        /// Displays the main menu for the game. Runs while the player is alive and the current level is not 10.
        /// </summary>
        public void InGameMenu()
        {
            Console.CursorVisible = false;
            MiddleWriteLine("");
            AnimateTextCenter(RandomGameIntroText(), textSpeed);
            CenterPressEnterToContinue();
            bool showMenu = true;
            Console.Clear();
            while (showMenu && !currentPlayer.IsDead && currentPlayer.Level != 10)
            {
                Console.Clear();
                WriteLineColour(textCamp, ConsoleColor.DarkCyan);
                WriteLineColour(campArt, ConsoleColor.DarkCyan);
                List<string> campMenu = new List<string> {
                    "[1] Leave the camp to explore", 
                    "[2] Visit the camp merchant", 
                    "[3] Show player information", 
                    "[4] Abandon adventure" };
                MiddleWriteLines(campMenu);
                CursorPosition(18, 47);
                int.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        AdventureDecider();
                        break;
                    case 2:
                        Shop campMerchant = new();
                        campMerchant.ShopMenu(currentPlayer);
                        break;
                    case 3:
                        Console.Clear();
                        currentPlayer.DisplayStats();
                        Console.WriteLine("\n\n\n");
                        CenterPressEnterToContinue();
                        break;
                    case 4:
                        var userAnswer = QuestionAndAnswer("Are you sure you wish to abandon your adventure? All progress will be lost. Press [Y] to confirm.");
                        if (userAnswer.ToLower() == "y")
                        {
                            showMenu = false;
                            CenterWriteLine("You decide to retire early.");
                            CenterPressEnterToContinue();
                        }
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                // Here's the win and lose condition for the game.
                if (currentPlayer.IsDead)
                {
                    Console.Clear();
                    AnimateTextCenter("Some say death is not the end.. They were wrong.");
                    ShowPlayerDeathArt();
                    CenterWriteLine("\n" + RandomTipsText());
                    CenterPressEnterToContinue();
                    showMenu = false;
                }
                if (currentPlayer.Level >= 10)
                {
                    Console.Clear();
                    WriteLineColour(wonTheGame, ConsoleColor.Yellow);
                    WriteLineColour(wonTheGame2, ConsoleColor.Yellow);
                    victoryPlayers.Add(currentPlayer);
                    CenterPressEnterToContinue();
                    showMenu = false;
                }
            }
        }
        #endregion

        #region Adventure Section
        /// <summary>
        /// Decides the type of encounter the player can stumble upon. ~90% chance of encountering combat, ~10% chance of encountering nothing.
        /// </summary>
        private void AdventureDecider()
        {
            var adventure = RandomGenerator.Next(1, 101);
            MiddleWriteLine("");
            AnimateTextCenter(RandomLeaveCampText(), textSpeedCombat);
            if (adventure >= 90)
                AdventureEncounterGrass();
            else
                AdventureEncounterCombat();
        }
        /// <summary>
        /// If there's a combat scenario, spawns a random monster from the monster array and sends it plus the player into the combat method.
        /// </summary>
        private void AdventureEncounterCombat()
        {
            AnimateTextCenter(RandomEncounterCombat(), textSpeedCombat);
            CenterPressEnterToContinue();
            InitializeCombat(currentPlayer, SpawnedMonster());
        }
        private void AdventureEncounterGrass()
        {
            AnimateTextCenter(RandomEncounterGrassText(), textSpeedCombat);
            CenterPressEnterToContinue();
        }
        //------------------------------------------
        #endregion
        /// <summary>
        /// Picks a random monster from the monsterArray. Scales the monster to the players level using the UpdateStats method.
        /// Returns the spawned and scaled monster.
        /// </summary>
        /// <returns></returns>
        private BaseMonster SpawnedMonster()
        {
            var monsterPick = RandomGenerator.Next(0, monsterArray.Length);
            var spawnedMonster = monsterArray[monsterPick];
            spawnedMonster.UpdateMonsterStats(currentPlayer);
            return spawnedMonster;
        }


        #region Combat Section
        /// <summary>
        /// Takes in a player object and a monster object. Lets them fight using their respective class methods until one of them dies.
        /// If the player dies, it gets added to a list consisting of dead players.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="monster"></param>
        private void InitializeCombat(Player player, BaseMonster monster)
        {
            CombatIntro(monster);
            while (!player.IsDead || !monster.IsDead)
            {
                CombatMonsterTurn(player, monster);
                Console.CursorVisible = false;
                PressEnterCombatSameLine();
                if (player.IsDead)
                {
                    fallenPlayers.Add(player);
                    break;
                }
                CombatPlayerTurn(player, monster);
                Console.CursorVisible = false;
                PressEnterCombatSameLine();
                if (monster.IsDead)
                {
                    PlayerVictory(player, monster);
                    PressEnterCombat();
                    break;
                }
                Console.Clear();
            }
        }

        private static void PlayerVictory(Player player, BaseMonster monster)
        {
            Console.Clear();
            player.GetExp(monster.Experience);
            MiddleWriteLine("");
            CenterWriteLine("You emerge victorious!"); // Placeholder
            CenterWriteLine("You return with your loot back to camp.");
            player.GetGold(monster.GiveGold());
            CenterWriteLineColour($"You have {player.Gold} gold.", ConsoleColor.DarkYellow);
        }

        private static void CombatIntro(BaseMonster monster)
        {
            Console.CursorVisible = false;
            MiddleWriteLine(RandomCombatIntro());
            PressEnterCombat();
            Console.Clear();
            monster.DisplayMonsterArt();
            Console.WriteLine();
            CenterWriteLineColour($"It's a {monster.Name}!", ConsoleColor.DarkRed);
            monster.MonsterGreeting();
            PressEnterCombat();
        }

        #region CombatTurns
        /// <summary>
        /// By pressing enter, the player and monster takes turn in combat. This is the combat turns for each combatant.
        /// The art and animations are run, and the attributes of the combatants are updated.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="monster"></param>
        private static void CombatPlayerTurn(Player player, BaseMonster monster)
        {
            CombatPlayPlayerAnimation(monster);
            monster.DisplayMonsterArt();
            Console.WriteLine();
            monster.TakeDamage(player.Attack());
            DisplayHP(player, monster); 
        }

        private static void CombatMonsterTurn(Player player, BaseMonster monster)
        {
            monster.DisplayMonsterArt();
            CombatPlayMonsterAnimation();
            monster.DisplayMonsterArt();
            player.TakeDamage(monster.Attack());
            DisplayHP(player, monster);
        }
        #endregion

        /// <summary>
        /// Displays the characters name+HP bar. Uses "Console.Write" and console positions instead of "Console.WriteLines", for flexibility
        /// and it makes it easier to display the HP in such a way that the HP gets updated after taking damage.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="monster"></param>
        private static void DisplayHP(Player player, BaseMonster monster)
        {
            string playerHpBarPadding = GetPadding(player);
            string monsterHpBarPadding = GetPadding(monster);
            //Writes the Name and HP on the same line by moving the console cursor to the right a bit. Then does the same for the HP bar.
            Console.CursorTop = 0;
            CenterWriteColour($"[{monster.Name}]", ConsoleColor.DarkRed);
            Console.CursorTop = 1;
            CenterWriteColour($"[{monsterHpBarPadding}HP: {monster.HP} / {monster.HPMax}{monsterHpBarPadding}]", ConsoleColor.Black, ConsoleColor.DarkRed);
            DrawFakeHUD();
            Console.CursorTop = 26;
            CenterWriteColour($"[{player.Name}]", ConsoleColor.DarkGreen);
            Console.CursorTop = 27;
            CenterWriteColour($"[{playerHpBarPadding}HP: {player.HP} / {player.HPMax}{playerHpBarPadding}]", ConsoleColor.Black, ConsoleColor.DarkGreen);
        }
        // Draws a fake "HUD" element. Is automatically placed behind the player hp section.
        private static void DrawFakeHUD()
        {
            Console.CursorTop = 25;
            WriteLineColour(hudElement, ConsoleColor.Yellow);
        }

        #region AttackAnimation
        /// <summary>
        /// Simple animation where the screen flashes in a certain colour, to indicate that the player took damage. 
        /// </summary>
        private static void CombatPlayMonsterAnimation()
        {
            var amountOfFlashes = 1;
            Console.CursorVisible = false;
            for (int i = 0; i < amountOfFlashes; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                System.Threading.Thread.Sleep(50);
                Console.ResetColor();
                Console.Clear();
            }
            Console.CursorVisible = true;
        }
        /// <summary>
        /// An animation of sorts where the players attack ASCII art flashes briefly, and the enemy monster flashes red a couple of times to indicate that it took damage.
        /// Simulates a hit with a sword.
        /// </summary>
        /// <param name="monster"></param>
        private static void CombatPlayPlayerAnimation(BaseMonster monster)
        {
            Console.Clear();
            Console.CursorVisible = false;
            WriteLineColour(playerAttackArt, ConsoleColor.Red);
            System.Threading.Thread.Sleep(100);
            var amountOfFlashes = 5;
            for (int i = 0; i < amountOfFlashes; i++)
            {
                Console.Clear();
                WriteLineColour(monster.Art, ConsoleColor.Red);
                System.Threading.Thread.Sleep(50);
            }
            Console.Clear();
            Console.CursorVisible = true;
        }
        #endregion
        #endregion
    }
}
