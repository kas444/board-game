using System;
using System.Configuration;
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
            
            var minX = int.Parse(ConfigurationManager.AppSettings["StartingAtX"]);
            var minY = int.Parse(ConfigurationManager.AppSettings["StartingAtY"]);
            var direction = Enum.Parse<Direction>(ConfigurationManager.AppSettings["StartingDirection"]);
            
            game.PlayGame(minX, minY, direction);
        }
    }
}