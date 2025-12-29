using System;
using System.Collections.Generic;

class SnakeAndLadder
{
    static Random random = new Random();

    static void Main()
    {
        // Snakes (Key = Head, Value = Tail)
        Dictionary<int, int> snakes = new Dictionary<int, int>()
        {
            { 99, 54 },
            { 70, 55 },
            { 52, 42 },
            { 25, 2 }
        };

        // Ladders (Key = Start, Value = End)
        Dictionary<int, int> ladders = new Dictionary<int, int>()
        {
            { 6, 25 },
            { 11, 40 },
            { 60, 85 },
            { 46, 90 }
        };

        Console.Write("Enter number of players (2 to 4): ");
        int playerCount = int.Parse(Console.ReadLine());

        // Store player names
        string[] players = new string[playerCount];

        // Store player positions (start at 0)
        int[] positions = new int[playerCount];

        for (int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter name of Player {i + 1}: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        bool gameOver = false;

        // Game loop
        while (!gameOver)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n{players[i]}'s turn. Press Enter to roll dice...");
                Console.ReadLine();

                int dice = RollDice();
                int oldPosition = positions[i];
                int newPosition = oldPosition + dice;

                // If position exceeds 100, skip move
                if (newPosition > 100)
                {
                    Console.WriteLine($"{players[i]} rolled {dice} → Move skipped (beyond 100)");
                    continue;
                }

                // Apply snake or ladder
                newPosition = ApplySnakeOrLadder(newPosition, snakes, ladders, players[i]);

                positions[i] = newPosition;

                Console.WriteLine($"{players[i]} rolled {dice} : {oldPosition} → {positions[i]}");

                // Check win
                if (CheckWin(positions[i]))
                {
                    Console.WriteLine($"\n🎉 {players[i]} wins the game! 🎉");
                    gameOver = true;
                    break;
                }
            }
        }
    }

    // Dice roll method
    static int RollDice()
    {
        return random.Next(1, 7); // 1 to 6
    }

    // Snake or Ladder logic
    static int ApplySnakeOrLadder(int position, Dictionary<int, int> snakes,
                                  Dictionary<int, int> ladders, string player)
    {
        if (snakes.ContainsKey(position))
        {
            Console.WriteLine($"🐍 Snake! {player} goes down to {snakes[position]}");
            return snakes[position];
        }
        else if (ladders.ContainsKey(position))
        {
            Console.WriteLine($"🪜 Ladder! {player} climbs up to {ladders[position]}");
            return ladders[position];
        }
        return position;
    }

    // Win condition
    static bool CheckWin(int position)
    {
        return position == 100 ? true : false; // ternary operator used
    }
}
