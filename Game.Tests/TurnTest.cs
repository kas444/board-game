using Game.Actions;
using Game.Enums;
using NUnit.Framework;

namespace Game.Tests
{
    public class TurnTest
    {
        private Turn _turn;
        private const int R = 1;
        private const int L = -1;
    
        [SetUp]
        public void SetUp()
        {
            _turn = new Turn();
        }

        [Test]
        public void TestTurnRight_West_To_North()
        {
            var direction = _turn.ChangeDirection(Direction.West, R);
            
            Assert.AreEqual(Direction.North, direction);
        }
        
        [Test]
        public void TestTurnRight_North_To_East()
        {
            var direction = _turn.ChangeDirection(Direction.North, R);
            
            Assert.AreEqual(Direction.East, direction);
        }
        
        [Test]
        public void TestTurnRight_East_To_South()
        {
            var direction = _turn.ChangeDirection(Direction.East, R);
            
            Assert.AreEqual(Direction.South, direction);
        }
        
        [Test]
        public void TestTurnRight_South_To_West()
        {
            var direction = _turn.ChangeDirection(Direction.South, R);
            
            Assert.AreEqual(Direction.West, direction);
        }
        
        [Test]
        public void TestTurnLeft_West_To_South()
        {
            var direction = _turn.ChangeDirection(Direction.West, L);
            
            Assert.AreEqual(Direction.South, direction);
        }
        
        [Test]
        public void TestTurnLeft_North_To_West()
        {
            var direction = _turn.ChangeDirection(Direction.North, L);
            
            Assert.AreEqual(Direction.West, direction);
        }
        
        [Test]
        public void TestTurnLeft_East_To_North()
        {
            var direction = _turn.ChangeDirection(Direction.East, L);
            
            Assert.AreEqual(Direction.North, direction);
        }
        
        [Test]
        public void TestTurnLeft_South_To_East()
        {
            var direction = _turn.ChangeDirection(Direction.South, L);
            
            Assert.AreEqual(Direction.East, direction);
        }
    }
}