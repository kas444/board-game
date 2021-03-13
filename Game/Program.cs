using System;
using Game.Actions;
using Game.Enums;

namespace Game
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWrapper();
            var turn = new Turn();
            var move = new Move();
            var action = new ActionFacade(turn, move);
            var game = new BoardGame(console, action);
            
            game.PlayGame(0,0, Direction.North);
        }
    }
}