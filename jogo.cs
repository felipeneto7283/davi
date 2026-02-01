using System;

class SimpleGame
{
    static void Main()
    {
        Console.WriteLine("=== Simple Game ===");
        Console.WriteLine("Commands:");
        Console.WriteLine("1 - Start Game");
        Console.WriteLine("2 - Move Up");
        Console.WriteLine("3 - Move Down");
        Console.WriteLine("4 - Move Left");
        Console.WriteLine("5 - Move Right");
        Console.WriteLine("6 - Attack");
        Console.WriteLine("0 - Exit");

        bool playing = true;
        int playerX = 5, playerY = 5;

        while (playing)
        {
            Console.Write("\nEnter command: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Game started!");
                    break;
                case "2":
                    playerY--;
                    Console.WriteLine($"Moved up to ({playerX}, {playerY})");
                    break;
                case "3":
                    playerY++;
                    Console.WriteLine($"Moved down to ({playerX}, {playerY})");
                    break;
                case "4":
                    playerX--;
                    Console.WriteLine($"Moved left to ({playerX}, {playerY})");
                    break;
                case "5":
                    playerX++;
                    Console.WriteLine($"Moved right to ({playerX}, {playerY})");
                    break;
                case "6":
                    Console.WriteLine("Attacking!");
                    break;
                case "0":
                    playing = false;
                    Console.WriteLine("Game over!");
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
}