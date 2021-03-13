using System;
using System.Collections.Generic;

namespace Game.Tests
{
    public class ConsoleWrapperStub : IConsoleWrapper
    {
        private IList<ConsoleKey> _keyCollection;
        private int _keyIndex = 0;

        public ConsoleWrapperStub(IList<ConsoleKey> keyCollection)
        {
            _keyCollection = keyCollection;
        }
        public ConsoleKeyInfo ReadKey()
        {
            var result = _keyCollection[_keyIndex];
            _keyIndex++;
            return new ConsoleKeyInfo( (char)result ,result ,false ,false ,false);
        }

    }
}