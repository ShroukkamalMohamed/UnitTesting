 using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProj;

namespace Test.UnitTest
{

    [TestClass]
    public class CalculationTest
    {
 
        [TestMethod]
        public void Add_TheREsultIsEqual_ReturnSameNumber()
        {
            Calculator calculator = new Calculator();
            //Arrange 
            calculator.FristNumber = 20;
            calculator.SecNumber = 25;
            calculator.OperationType = "Add";
            // Act 
            int Result = calculator.Calucluation();
            int expectedNumber =45;
            // Assert 
            Assert.AreEqual(Result, expectedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public  void CaluclationIfOPisnotExist_Multiply_ReturnExcption()
        {
            Calculator calculator = new Calculator();
            //Arrange 
            calculator.FristNumber = 20;
            calculator.SecNumber = 25;
            calculator.OperationType = "Multiply";
            // Act 
            int Result = calculator.Calucluation();
            int expectedNumber = 45;
            // Assert 
            Assert.AreEqual(Result, expectedNumber);
        }
        //[ClassInitialize]
        //public  void MyTestMethod(TestContext TestContext)
        //{
        //    TestContext.WriteLine("ClassInitialize");
        //}
        //[TestInitialize]
        //public  void TestInitialize(TestContext TestContext)
        //{
        //    TestContext.WriteLine("TestInitialize");
        //}

    }
}
