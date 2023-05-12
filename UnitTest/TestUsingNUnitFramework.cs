using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProj;

namespace Test.UnitTest
{
    [TestFixture]
    public class TestUsingNUnitFramework
    {
        Calculator calculator = new Calculator();

        [Test]
        public void Add_SumOfTwoNumbers_ReturnCorrectSum()
        {
            //Arrange 
            calculator.FristNumber = 20;
            calculator.SecNumber = 25;
            calculator.OperationType = "Add";
            // Act 
            int Result = calculator.Calucluation();
            int expectedNumber = 45;
            // Assert 
            Assert.That(Result, Is.EqualTo(expectedNumber));
        }
        //TestCases..
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        public void MaxNumber_PassingTwonumbers_ReturnMaxNumberofThem(int FristNumber, int SecNumber, int ExpectedNumber)
        {
            int Result = calculator.MaxNumber(FristNumber, SecNumber);
            Assert.AreEqual(Result, ExpectedNumber);
        }
        //Ignore Test..
        [Ignore("Ignore Test..")]
        [Test]
        public void IgnoreTest()
        {
        }

        // test a List 
        [Test]
        public void OddNumber_Number_GetOddNumberlessThanNumber()
        {
            var Result = calculator.OddNumbers(6);
            // Assert.That(Result, Is.Empty);
            Assert.That(Result.Contains(2));
            Assert.That(Result.Contains(4));
            Assert.That(Result.Contains(0));

        }
    }

}
