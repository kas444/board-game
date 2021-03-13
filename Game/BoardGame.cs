using System;
using Game.Enums;

namespace Game
{
    public class BoardGame
    {
        public void PlayGame()
        {
            var position = (X:0, Y:0, Direction: Direction.North);
            
            Console.WriteLine("Game start!");
            Console.WriteLine($"Current position is: {position.X},{position.Y} {position.Direction}");

            while (true)
            {
                var input = Console.ReadKey(true);
                switch (input.KeyChar)
                {
                    case 'r':
                        position.Direction = position.Direction == Direction.West 
                            ? Direction.North 
                            : Direction.East;
                        break;
                    case 'l':
                        position.Direction = position.Direction == Direction.East 
                            ? Direction.North 
                            : Direction.West;
                        break;
                    case 'm':
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
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(input.KeyChar), input.KeyChar, null);
                }
                Console.WriteLine($"Current position is: {position.X},{position.Y} {position.Direction}");
            }
        }
    }
}