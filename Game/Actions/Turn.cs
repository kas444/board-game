using Game.Enums;

namespace Game.Actions
{
    public interface ITurn
    {
        Direction TurnRight(Direction direction);
        Direction TurnLeft(Direction direction);
    }
    
    public class Turn : ITurn
    {
        public Direction TurnRight(Direction direction)
        {
            return direction == Direction.West ? Direction.North : Direction.East;
        }

        public Direction TurnLeft(Direction direction)
        {
            return direction  == Direction.East ? Direction.North : Direction.West;
        }
    }
}