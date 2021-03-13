using Game.Enums;

namespace Game
{
    public interface IActionFacade
    {
        public Direction TurnRight(Direction direction);
        public Direction TurnLeft(Direction direction);
        public (int, int, Direction) MoveUp(int x, int y, Direction direction);
        public (int, int, Direction) MoveDown(int x, int y, Direction direction);
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
            return _turn.TurnRight(direction);
        }
        
        public Direction TurnLeft(Direction direction)
        {
            return _turn.TurnLeft(direction);
        }
        
        public (int, int, Direction) MoveUp(int x, int y, Direction direction)
        {
            return _move.MoveUp(x, y, direction);
        }

        public (int, int, Direction) MoveDown(int x, int y, Direction direction)
        {
            throw new System.NotImplementedException();
        }
    }
}