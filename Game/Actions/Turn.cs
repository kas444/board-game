using System.Collections.Generic;
using System.Linq;
using Game.Enums;

namespace Game.Actions
{
    public interface ITurn
    {
        Direction ChangeDirection(Direction direction, char rotate);
    }
    
    public class Turn : ITurn
    {
        private readonly List<Direction> _direction = new List<Direction>() {Direction.North, Direction.East, Direction.South, Direction.West};

        public Direction ChangeDirection(Direction direction, char rotate)
        {
            var length = _direction.Count;
            var index = _direction.IndexOf(direction);

            if (rotate == 'R')
            {
                if (index >= length-1) return _direction.First();
                index++;
                return _direction[index];
            }
            
            if (index == 0) return _direction.Last();
            index--;
            return _direction[index];
        }
    }
}