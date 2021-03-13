using System;
using Game.Actions;
using Game.Enums;

namespace Game
{
    public class BoardGame
    {
        private readonly IConsoleWrapper _consoleWrapper;
        private readonly IActionFacade _action;

        public BoardGame(
            IConsoleWrapper consoleWrapper,
            IActionFacade action
            )
        {
            _consoleWrapper = consoleWrapper;
            _action = action;
        }

        public (int, int, Direction) PlayGame(int x, int y, Direction direction)
        {
            var position = (X:x, Y:y, Direction: direction);
            
            Console.WriteLine("Game start!");
            Console.WriteLine($"Current position is: {position.X},{position.Y} {position.Direction}");
            
            ConsoleKeyInfo key;

            do
            {
                key = _consoleWrapper.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.R:
                        position.Direction = _action.TurnRight(position.Direction);
                        break;
                    case ConsoleKey.L:
                        position.Direction = _action.TurnLeft(position.Direction);
                        break;
                    case ConsoleKey.M:
                        position = _action.MoveUp(position);
                        break;
                }
                Console.WriteLine($"Current position is: {position.X},{position.Y} {position.Direction}");
            }
            while (key.Key != ConsoleKey.Enter);
            
            return position;
        }
    }
}