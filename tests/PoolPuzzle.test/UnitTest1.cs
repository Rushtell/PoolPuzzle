using System;
using Xunit;

namespace PoolPuzzle.test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldToCreateAirplane()
        {
            var airplane = new Airplane();
            airplane.SetSpeed(300);
            int speed = airplane.GetSpeed();

            Assert.Equal(300, speed);
            Assert.Equal(1, airplane.Multiplier);

            airplane.Multiplier = 3;

            Assert.Equal(3, airplane.Multiplier);
        }


        [Fact]
        public void ShouldToCreateJet()
        {
            var jet = new Jet();
            jet.SetSpeed(300);
            int speed = jet.GetSpeed();

            Assert.Equal(600, speed);
            Assert.Equal(2, jet.Multiplier);

            jet.Multiplier = 3;

            Assert.Equal(3, jet.Multiplier);

            jet.Accelerate();

            Assert.Equal(1800, jet.GetSpeed());
        }
    }
}
