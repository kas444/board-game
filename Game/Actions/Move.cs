using System;
using Game.Enums;

namespace Game
{
    public interface IMove
    {
        (int, int, Direction) MoveUp(int x, int y, Direction direction);
        (int, int, Direction) MoveDown(int x, int y, Direction direction);
    }
    
    public class Move : IMove
    {
        public (int, int, Direction) MoveUp(int x, int y, Direction direction)
        {
            var position = (X:x, Y:y, Direction:direction);
            
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
            return position;
        }

        public (int, int, Direction) MoveDown(int x, int y, Direction direction)
        {
            throw new System.NotImplementedException();
        }
    }
}