using System;
using System.Collections.Generic;
using System.Configuration;
using Game.Actions;
using Game.Enums;
using Moq;
using NUnit.Framework;

namespace Game.Tests
{
    public class BoardGameTest
    {
        private BoardGame _boardGame;
        private Mock<Turn> _turn;
        private Mock<Move> _move;
        private ActionFacade _actionFacadeMock;
    
        [SetUp]
        public void SetUp()
        {
            _turn = new Mock<Turn>();
            _move = new Mock<Move>();
            _actionFacadeMock = new ActionFacade(_turn.Object, _move.Object);
            
            ConfigurationManager.AppSettings["BoardSizeMinX"] = "0";
            ConfigurationManager.AppSettings["BoardSizeMaxX"] = "4";
            ConfigurationManager.AppSettings["BoardSizeMaxY"] = "4";
        }
        
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
            
            _boardGame = new BoardGame(stub, _actionFacadeMock);
            
            var result = _boardGame.PlayGame(0, 0, Direction.North);
            
            var expectedPosition = (0, 4, Direction.North);
            
            Assert.AreEqual(expectedPosition, result);
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

            _boardGame = new BoardGame(stub, _actionFacadeMock);

            var result = _boardGame.PlayGame(0, 0, Direction.North);
            
            var expectedPosition = (3, 2, Direction.North);
            
            Assert.AreEqual(expectedPosition, result);
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

            _boardGame = new BoardGame(stub, _actionFacadeMock);

            var result = _boardGame.PlayGame(0, 0, Direction.North);
            
            var expectedPosition = (2, 2, Direction.East);
            
            Assert.AreEqual(expectedPosition, result);
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

            _boardGame = new BoardGame(stub, _actionFacadeMock);

            var result = _boardGame.PlayGame(0, 0, Direction.North);
            
            var expectedPosition = (1, 2, Direction.West);
            
            Assert.AreEqual(expectedPosition, result);
        }
    }
}