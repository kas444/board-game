using System;
using System.Configuration;
using Game.Enums;

namespace Game.Actions
{
    public interface IMove
    {
        (int, int, Direction) MoveForward((int x, int y, Direction direction) position);
    }
    
    public class Move : IMove
    {
        public (int, int, Direction) MoveForward((int x, int y, Direction direction) position)
        {
            position = (position.x, position.y, position.direction);
            var minX = int.Parse(ConfigurationManager.AppSettings["BoardSizeMinX"]);
            var maxX = int.Parse(ConfigurationManager.AppSettings["BoardSizeMaxX"]);
            var minY = int.Parse(ConfigurationManager.AppSettings["BoardSizeMinY"]);
            var maxY = int.Parse(ConfigurationManager.AppSettings["BoardSizeMaxY"]);
            
            switch (position.direction)
            {
                case Direction.North:
                    if (position.y < maxY)
                    {
                        position.y++;
                    }
                    break;
                case Direction.East:
                    if (position.x < maxX)
                    {
                        position.x++;
                    }
                    break;
                case Direction.West:
                    if (position.x > minX)
                    {
                        position.x--;
                    }
                    break;
                case Direction.South:
                    if (position.y > minY)
                    {
                        position.y--;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return position;
        }
    }
}