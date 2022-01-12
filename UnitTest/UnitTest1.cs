using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace tests

{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Unit Testing Part 1"; 
        private const string Expected1 = "Welcome to Unit testing";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UnitTestProject.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                UnitTestProject.Program1.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected1, result);
            }
        }
    }
}
