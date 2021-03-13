using System;
using Game.Enums;

namespace Game
{
    public class BoardGame
    {
        public static (int, int, Direction) PlayGame(IConsoleWrapper console)
        {
            var position = (X:0, Y:0, Direction: Direction.North);
            
            Console.WriteLine("Game start!");
            Console.WriteLine($"Current position is: {position.X},{position.Y} {position.Direction}");
            
            ConsoleKeyInfo key;

            do
            {
                key = console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.R:
                        position.Direction = position.Direction == Direction.West 
                            ? Direction.North 
                            : Direction.East;
                        break;
                    case ConsoleKey.L:
                        position.Direction = position.Direction == Direction.East 
                            ? Direction.North 
                            : Direction.West;
                        break;
                    case ConsoleKey.M:
                        switch (position.Direction)
                        {
                            case Direction.North:
                                if (position.Y < 4)
                                {
                                    position.Y++;
                                }
                                break;
                            case Direction.East:
                                if (position.X < 4)
                                {
                                    position.X++;
                                }
                                break;
                            case Direction.West:
                                if (position.X > 0)
                                {
                                    position.X--;
                                }
                                break;
                        }
                        break;
                }
                Console.WriteLine($"Current position is: {position.X},{position.Y} {position.Direction}");
            }
            while (key.Key != ConsoleKey.Enter);

            return position;
        }
    }
}