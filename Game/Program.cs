namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleWrapper();
            var game = new BoardGame();
            BoardGame.PlayGame(console);
        }
    }
}