using Game.Actions;
using Game.Enums;
using NUnit.Framework;

namespace Game.Tests
{
    public class TurnTest
    {
        private Turn _turn;
    
        [SetUp]
        public void SetUp()
        {
            _turn = new Turn();
        }

        [Test]
        public void TestTurnRight_West_To_North()
        {
            var direction = _turn.TurnRight(Direction.West);
            
            Assert.AreEqual(direction, Direction.North);
        }
        
        [Test]
        public void TestTurnRight_North_To_East()
        {
            var direction = _turn.TurnRight(Direction.North);
            
            Assert.AreEqual(direction, Direction.East);
        }
        
        [Test]
        public void TestTurnRight_East_To_East()
        {
            var direction = _turn.TurnRight(Direction.East);
            
            Assert.AreEqual(direction, Direction.East);
        }
    }
}