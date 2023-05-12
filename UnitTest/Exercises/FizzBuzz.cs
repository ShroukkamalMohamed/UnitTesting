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
    public class FizzBuzz
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(5, "Buzz")]
        [TestCase(3, "Fizz")]
        [TestCase(2, "2")]
        public void FizzBuzz_PassNumber_ReturnFizzOrBuzzType(int Number, string ExpectedExperation)
        {
            TestProj.Exercises.FizzBuzz fizzBuzz = new TestProj.Exercises.FizzBuzz();
            string Reesult = fizzBuzz.GetType(Number);
            Assert.AreEqual(ExpectedExperation, Reesult);

        }

    }
}
