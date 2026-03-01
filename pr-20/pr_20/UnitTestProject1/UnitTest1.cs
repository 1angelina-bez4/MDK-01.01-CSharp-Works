using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pr_20;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int N = 1234;
            bool res = true;
            bool a = Task1.Meth(N);
            Assert.AreEqual(res, a);
        }
    }
}
