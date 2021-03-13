using System;

namespace Game
{
    public interface IConsoleWrapper
    {
        ConsoleKeyInfo ReadKey();
    }
    
    public class ConsoleWrapper : IConsoleWrapper
    {
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey(true);
        }
    }
}