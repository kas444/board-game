using System;
using System.Configuration;
using Game.Enums;

namespace Game.Actions
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
            var minX = int.Parse(ConfigurationManager.AppSettings["BoardSizeMinX"]);
            var maxX = int.Parse(ConfigurationManager.AppSettings["BoardSizeMaxX"]);
            var maxY = int.Parse(ConfigurationManager.AppSettings["BoardSizeMaxY"]);
            
            switch (position.Direction)
            {
                case Direction.North:
                    if (position.Y < maxY)
                    {
                        position.Y++;
                    }
                    break;
                case Direction.East:
                    if (position.X < maxX)
                    {
                        position.X++;
                    }
                    break;
                case Direction.West:
                    if (position.X > minX)
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