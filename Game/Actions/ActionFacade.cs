using Game.Enums;

namespace Game.Actions
{
    public interface IActionFacade
    {
        public Direction TurnRight(Direction direction);
        public Direction TurnLeft(Direction direction);
        public (int, int, Direction) MoveForward((int x, int y, Direction direction) position);
    }
    
    public class ActionFacade : IActionFacade
    {
        private readonly ITurn _turn;
        private readonly IMove _move;

        public ActionFacade(ITurn turn, IMove move)
        {
            _turn = turn;
            _move = move;
        }

        public Direction TurnRight(Direction direction)
        {
            return _turn.ChangeDirection(direction, 'R');
        }
        
        public Direction TurnLeft(Direction direction)
        {
            return _turn.ChangeDirection(direction, 'L');
        }
        
        public (int, int, Direction) MoveForward((int x, int y, Direction direction) position)
        {
            return _move.MoveForward(position);
        }
    }
}