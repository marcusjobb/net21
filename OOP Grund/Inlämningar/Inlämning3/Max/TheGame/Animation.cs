using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheGame
{
    class BattleAnimation
    {
        // VS SLIME

        public static void IdleVsSlime()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│     ☻ │                          │");
            Console.WriteLine("│    /╬-┼                          │");
         Pretty.TextWithColor("│    / │                 ", "Green", "(°. º)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerStrikeSlime()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│            ☻                     │");
            Console.WriteLine("│           /╬'-+──         !      │");
         Pretty.TextWithColor("│           / ┘          ", "Green", "(°. o)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void SlimeStrike()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│     !                            │");
            Console.WriteLine("│    │☻ /                          │");
         Pretty.TextWithColor("│    '╬'       ", "Green", "(♦w ♦ )", "             │\n");
           Console.WriteLine(@"│    │ \          \\\              │");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerLowVsSlime()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
         Pretty.TextWithColor("│    _/══┐☻              ", "Green", "(°u º)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void SlimeLow()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│     ☻ │                          │");
            Console.WriteLine("│    /╬-┼                          │");
         Pretty.TextWithColor("│    / │                 ", "Green", "(×. ø)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerAndSlimeLow()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
            Pretty.TextWithColor("│    _/══┐☻              ", "Green", "(×. ø)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerDeadVsSlime()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│   -┼-                            │");
            Pretty.TextWithColor("│  _-┴──-_               ", "Green", "(^v ^)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void SlimeDead()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│     ☻ │                          │");
            Console.WriteLine("│    /╬-┼                          │");
            Pretty.TextWithColor("│    / │                 ", "Green", "(x, x)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }


        // VS KING SLIME

        public static void IdleVsKing()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│     ☻ │                          │");
         Pretty.TextWithColor("│    /╬-┼                  ", "Yellow", "NN", "      │\n");
         Pretty.TextWithColor("│    / │                 ", "Green", "(°. º)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerStrikeKing()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│            ☻              !      │");
         Pretty.TextWithColor("│           /╬-+──         ", "Yellow", "NN", "      │\n");
         Pretty.TextWithColor("│           / ┘          ", "Green", "(°. o)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void KingStrike()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│     !                            │");
         Pretty.TextWithColor("│    │☻ /        ", "Yellow", "NN", "                │\n");
         Pretty.TextWithColor("│    '╬'       ", "Green", "(♦w ♦ )", "             │\n");
           Console.WriteLine(@"│    │ \          \\\              │");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerLowVsKing()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
         Pretty.TextWithColor("│                          ", "Yellow", "NN", "      │\n");
         Pretty.TextWithColor("│    _/══┐☻              ", "Green", "(°u º)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void KingLow()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│     ☻ │                          │");
            Pretty.TextWithColor("│    /╬-┼                  ", "Yellow", "NN", "      │\n");
            Pretty.TextWithColor("│    / │                 ", "Green", "(×. ø)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerAndKingLow()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
            Pretty.TextWithColor("│                          ", "Yellow", "NN", "      │\n");
            Pretty.TextWithColor("│    _/══┐☻              ", "Green", "(×. ø)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void PlayerDeadVsKing()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│                                  │");
         Pretty.TextWithColor("│   -┼-                    ", "Yellow", "NN", "      │\n");
         Pretty.TextWithColor("│  _-┴──-_               ", "Green", "(^v ^)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }

        public static void KingDead()
        {
            Console.WriteLine("┌──────────────────────────────────┐");
            Console.WriteLine("│                                  │");
            Console.WriteLine("│     ☻ │                          │");
         Pretty.TextWithColor("│    /╬-┼                  ", "Yellow", "NN", "      │\n");
         Pretty.TextWithColor("│    / │                 ", "Green", "(x, x)", "    │\n");
            Console.WriteLine("└──────────────────────────────────┘");
        }
    }

    public class EndScreen // Code Taken from https://stackoverflow.com/questions/1923323/console-animations
    {
        static string[,] sequence = null;

        public int Delay { get; set; } = 200;

        int totalSequences = 0;
        int counter;

        public EndScreen()   
        {
            counter = 0;
            sequence = new string[,] {
                { "     (u. u)   ", "     (u. u)   ", "     (T^ T)   ", "     (┬, ┬)   ", "     (┬, ┬)   ", "    (┬, ┬ )   " , "    (┬, ┬)   ", "   (┬, ┬ )   ", 
                    "   (┬, ┬)   ", "   (┬, ┬)", "   (┬, ┬)", "   (-. -)", "   (u. u)", "   (-. -)", "   (u. u)", "   (u .u)",
                    "   (u .u)", "   (T ^T)", "   (┬ ,┬)", "   (┬ ,┬)", "   ( ┬ ,┬)", "    (┬ ,┬)", "    ( ┬ ,┬)", "     (┬ ,┬)", "     (- .-)   ",  "     (u .u)   ",
                 "     (- .-)   ",  "     (u .u)   "}
            };

            totalSequences = sequence.GetLength(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sequenceCode"> 0 | 1 | 2 |3 | 4 | 5 </param>
        public void Turn(string displayMsg = "", int sequenceCode = 0)
        {
            counter++;

            Thread.Sleep(Delay);

            sequenceCode = sequenceCode > totalSequences - 1 ? 0 : sequenceCode;

            int counterValue = counter % 28;

            string fullMessage = displayMsg + sequence[sequenceCode, counterValue];
            int msglength = fullMessage.Length;

            Console.Write(fullMessage);

            Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
        }
    }
}
