using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.UnitTest
{
    [TestClass]
    public static class TestIntitialize
    {
    
            [AssemblyInitialize]
            public static void MyTestMethod(TestContext testContext)
            {
                testContext.WriteLine("AssemblyInitialize");
            }
      
    }
}
