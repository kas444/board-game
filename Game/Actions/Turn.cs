using System.Collections.Generic;
using System.Linq;
using Game.Enums;

namespace Game.Actions
{
    public interface ITurn
    {
        Direction ChangeDirection(Direction direction, int rotate);
    }
    
    public class Turn : ITurn
    {
        private readonly List<Direction> _direction = new List<Direction>() 
            {Direction.North, Direction.East, Direction.South, Direction.West};

        public Direction ChangeDirection(Direction direction, int rotate)
        {
            var length = _direction.Count;
            var index = _direction.IndexOf(direction);
            var sum = index + rotate;

            return sum >= 0 ? _direction[sum % length] : _direction[length + sum % length];
        }
    }
}