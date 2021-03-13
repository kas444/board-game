using System;
using System.Collections.Generic;
using Game.Enums;
using NUnit.Framework;

namespace Game.Tests
{
    public class BoardGameTest
    {
        [Test]
        public void TestMoving_MMMMM()
        {
            var stub = new ConsoleWrapperStub(new List<ConsoleKey>
            {
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.Enter
            });

            var result = BoardGame.PlayGame(stub);
            
            var expectedPosition = (0, 4, Direction.North);
            
            Assert.AreEqual(result, expectedPosition);
        }
        [Test]
        public void TestMoving_RMMMLMM()
        {
            var stub = new ConsoleWrapperStub(new List<ConsoleKey>
            {
                ConsoleKey.R,
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.L,
                ConsoleKey.M,
                ConsoleKey.M,
                ConsoleKey.Enter
            });

            var result = BoardGame.PlayGame(stub);
            
            var expectedPosition = (3, 2, Direction.North);
            
            Assert.AreEqual(result, expectedPosition);
        }
        [Test]
        public void TestMoving_MRMLMRM()
        {
            var stub = new ConsoleWrapperStub(new List<ConsoleKey>
            {
                ConsoleKey.M,
                ConsoleKey.R,
                ConsoleKey.M,
                ConsoleKey.L,
                ConsoleKey.M,
                ConsoleKey.R,
                ConsoleKey.M,
                ConsoleKey.Enter
            });

            var result = BoardGame.PlayGame(stub);
            
            var expectedPosition = (2, 2, Direction.East);
            
            Assert.AreEqual(result, expectedPosition);
        }
        [Test]
        public void TestMoving_MRMLMRMLLM()
        {
            var stub = new ConsoleWrapperStub(new List<ConsoleKey>
            {
                ConsoleKey.M,
                ConsoleKey.R,
                ConsoleKey.M,
                ConsoleKey.L,
                ConsoleKey.M,
                ConsoleKey.R,
                ConsoleKey.M,
                ConsoleKey.L,
                ConsoleKey.L,
                ConsoleKey.M,
                ConsoleKey.Enter
            });

            var result = BoardGame.PlayGame(stub);
            
            var expectedPosition = (1, 2, Direction.West);
            
            Assert.AreEqual(result, expectedPosition);
        }
    }
}