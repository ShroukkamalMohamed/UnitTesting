using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProj.Exercises;

namespace UnitTest.Exercises
{
    [TestFixture]
    public class PointsCaluculatorTest
    {
        PointsCaluculator pointsCaluculator = new PointsCaluculator();  
         [Test]
        public void PointsCaluculator_SpeedIsLessZero_throwExpection()
        {
            Assert.That(() => pointsCaluculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        
        [Test]
        public void PointsCaluculator_SpeedLessThanLimtSpeed_returnZero()
        {
            int Speed = 2;
            var Result = pointsCaluculator.CalculateDemeritPoints(Speed);
            var ExpectedResult = 0;
            Assert.That(Result, Is.EqualTo(ExpectedResult));
        }

        [Test]
        public void PointsCaluculator_SpeedMoreThanLimtSpeed_ReturnDemeritPoint()
        {
            Assert.That(pointsCaluculator.CalculateDemeritPoints(70), Is.EqualTo(1));
        }

    }
}
