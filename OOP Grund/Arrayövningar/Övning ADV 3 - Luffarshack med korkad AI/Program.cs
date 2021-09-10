namespace Övning_ADV_3___Luffarshack_med_korkad_AI
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] map = new int[3, 3];

            // -------------------------------------------------------------------
            // om slumptalet är mer än 50 så ska spelaren börja
            // en slags procent-aktig jämförelse. Nu när det 50% chans
            // vem som startar spelet
            // -------------------------------------------------------------------
            bool nextPlayer = rnd.Next(0, 100) > 50; // true = human, false = computer
            int winner = 0; // 0= oavgjort, 1= spelare, 2 = dator
            int moves = 0;
            do
            {
                // -------------------------------------------------------------------
                // Räknar drag
                // -------------------------------------------------------------------
                moves++;
                // -------------------------------------------------------------------
                // Rensa skärm och skriv ut spelkarta
                // -------------------------------------------------------------------
                Console.Clear();
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        if (map[y, x] == 1) Console.Write("X");
                        else if (map[y, x] == 2) Console.Write("O");
                        else Console.Write((y) * 3 + x + 1);
                    }
                    Console.WriteLine();
                }

                if (nextPlayer)
                {
                    // -------------------------------------------------------------------
                    // mänsklig spelare
                    // -------------------------------------------------------------------
                    int playerMove = 0;
                    while (true)
                    {
                        Console.WriteLine("Var vill du placera ditt drag? (1-9)");
                        string val = Console.ReadLine();
                        int.TryParse(val, out playerMove);
                        // -------------------------------------------------------------------
                        // kontrollera att det är giltliga och tomma positioner
                        // -------------------------------------------------------------------
                        if (playerMove > 0 && playerMove < 10)
                        {
                            if (playerMove == 1 && map[0, 0] == 0) break;
                            if (playerMove == 2 && map[0, 1] == 0) break;
                            if (playerMove == 3 && map[0, 2] == 0) break;
                            if (playerMove == 4 && map[1, 0] == 0) break;
                            if (playerMove == 5 && map[1, 1] == 0) break;
                            if (playerMove == 6 && map[1, 2] == 0) break;
                            if (playerMove == 7 && map[2, 0] == 0) break;
                            if (playerMove == 8 && map[2, 1] == 0) break;
                            if (playerMove == 9 && map[2, 2] == 0) break;
                        }
                    }
                    // -------------------------------------------------------------------
                    // sätt spelarens drag på kartan
                    // -------------------------------------------------------------------
                    if (playerMove == 1 && map[0, 0] == 0) map[0, 0] = 1;
                    if (playerMove == 2 && map[0, 1] == 0) map[0, 1] = 1;
                    if (playerMove == 3 && map[0, 2] == 0) map[0, 2] = 1;
                    if (playerMove == 4 && map[1, 0] == 0) map[1, 0] = 1;
                    if (playerMove == 5 && map[1, 1] == 0) map[1, 1] = 1;
                    if (playerMove == 6 && map[1, 2] == 0) map[1, 2] = 1;
                    if (playerMove == 7 && map[2, 0] == 0) map[2, 0] = 1;
                    if (playerMove == 8 && map[2, 1] == 0) map[2, 1] = 1;
                    if (playerMove == 9 && map[2, 2] == 0) map[2, 2] = 1;
                }
                else
                {
                    // -------------------------------------------------------------------
                    // välj slumpmässig position
                    // -------------------------------------------------------------------
                    int playerMove = 0;
                    while (true)
                    {
                        // -------------------------------------------------------------------
                        // välj en position mellan 1 och 9
                        // -------------------------------------------------------------------
                        playerMove = rnd.Next(1, 10);
                        // -------------------------------------------------------------------
                        // kontrollera att vald tal är tomt
                        // -------------------------------------------------------------------
                        if (playerMove > 0 && playerMove < 10)
                        {
                            if (playerMove == 1 && map[0, 0] == 0) break;
                            if (playerMove == 2 && map[0, 1] == 0) break;
                            if (playerMove == 3 && map[0, 2] == 0) break;
                            if (playerMove == 4 && map[1, 0] == 0) break;
                            if (playerMove == 5 && map[1, 1] == 0) break;
                            if (playerMove == 6 && map[1, 2] == 0) break;
                            if (playerMove == 7 && map[2, 0] == 0) break;
                            if (playerMove == 8 && map[2, 1] == 0) break;
                            if (playerMove == 9 && map[2, 2] == 0) break;
                        }
                    }
                    // -------------------------------------------------------------------
                    // spara drag i arrayen
                    // -------------------------------------------------------------------
                    if (playerMove == 1 && map[0, 0] == 0) map[0, 0] = 2;
                    if (playerMove == 2 && map[0, 1] == 0) map[0, 1] = 2;
                    if (playerMove == 3 && map[0, 2] == 0) map[0, 2] = 2;
                    if (playerMove == 4 && map[1, 0] == 0) map[1, 0] = 2;
                    if (playerMove == 5 && map[1, 1] == 0) map[1, 1] = 2;
                    if (playerMove == 6 && map[1, 2] == 0) map[1, 2] = 2;
                    if (playerMove == 7 && map[2, 0] == 0) map[2, 0] = 2;
                    if (playerMove == 8 && map[2, 1] == 0) map[2, 1] = 2;
                    if (playerMove == 9 && map[2, 2] == 0) map[2, 2] = 2;
                }
                nextPlayer = !nextPlayer;
                // -------------------------------------------------------------------
                // kontrollera positioner
                // -------------------------------------------------------------------
                // 123
                // -------------------------------------------------------------------
                if (map[0, 0] == 1 && map[0, 1] == 1 && map[0, 2] == 1) winner = 1;
                if (map[0, 0] == 2 && map[0, 1] == 2 && map[0, 2] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 456
                // -------------------------------------------------------------------
                if (map[1, 0] == 1 && map[1, 1] == 1 && map[1, 2] == 1) winner = 1;
                if (map[1, 0] == 2 && map[1, 1] == 2 && map[1, 2] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 789
                // -------------------------------------------------------------------
                if (map[2, 0] == 1 && map[2, 1] == 1 && map[2, 2] == 1) winner = 1;
                if (map[2, 0] == 2 && map[2, 1] == 2 && map[2, 2] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 147
                // -------------------------------------------------------------------
                if (map[0, 0] == 1 && map[1, 0] == 1 && map[2, 0] == 1) winner = 1;
                if (map[0, 0] == 2 && map[1, 0] == 2 && map[2, 0] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 258
                // -------------------------------------------------------------------
                if (map[0, 1] == 1 && map[1, 1] == 1 && map[2, 1] == 1) winner = 1;
                if (map[0, 1] == 2 && map[1, 1] == 2 && map[2, 1] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 368
                // -------------------------------------------------------------------
                if (map[0, 2] == 1 && map[1, 2] == 1 && map[2, 2] == 1) winner = 1;
                if (map[0, 2] == 2 && map[1, 2] == 2 && map[2, 2] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 159
                // -------------------------------------------------------------------
                if (map[0, 0] == 1 && map[1, 1] == 1 && map[2, 2] == 1) winner = 1;
                if (map[0, 0] == 2 && map[1, 1] == 2 && map[2, 2] == 2) winner = 2;
                // -------------------------------------------------------------------
                // 357
                // -------------------------------------------------------------------
                if (map[0, 2] == 1 && map[1, 1] == 1 && map[2, 0] == 1) winner = 1;
                if (map[0, 2] == 2 && map[1, 1] == 2 && map[2, 0] == 2) winner = 2;

            } while (moves < 9 && winner == 0);

            // -------------------------------------------------------------------
            // kolla vem som vann
            // -------------------------------------------------------------------
            if (winner == 0)
            {
                Console.WriteLine("Oavgjort");
            }
            if (winner == 1)
            {
                Console.WriteLine("Spelaren vann");
            }
            if (winner == 2)
            {
                Console.WriteLine("Datorn vann");
            }
        }
    }
}
