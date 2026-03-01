using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace var4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 12;

            EvenTwoDigitChecker task1 = new EvenTwoDigitChecker();
            bool result = task1.IsEvenTwoDigit(number);

            bool test_res = true;
            Assert.AreEqual(test_res, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int number = 122;

            EvenTwoDigitChecker task1 = new EvenTwoDigitChecker();
            bool result = task1.IsEvenTwoDigit(number);

            bool test_res = true;
            Assert.AreEqual(test_res, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int number = 50;

            EvenTwoDigitChecker task1 = new EvenTwoDigitChecker();
            bool result = task1.IsEvenTwoDigit(number);

            bool test_res = true;
            Assert.AreEqual(test_res, result);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sizafile = 100000;

            FileSizeConverter task2 = new FileSizeConverter();
            (int KB, int MB) result2 = task2.Convert(sizafile);

            (int, int) test_res = (97, 0);
            Assert.AreEqual(test_res, result2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int sizafile = 105000;

            FileSizeConverter task2 = new FileSizeConverter();
            (int KB, int MB) result2 = task2.Convert(sizafile);

            (int, int ) test_res = (32, 5);
            Assert.AreEqual(test_res, result2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int sizafile = 105999;

            FileSizeConverter task2 = new FileSizeConverter();
            (int KB, int MB) result2 = task2.Convert(sizafile);

            (int, int) test_res = (30, 5);
            Assert.AreEqual(test_res, result2);
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            TriangleCalculator task4 = new TriangleCalculator();
            double result4 = task4.TriangleP(a);

            double test_res = 9;
            Assert.AreEqual(test_res, result4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 10;
            TriangleCalculator task4 = new TriangleCalculator();
            double result4 = task4.TriangleP(a);

            double test_res = 30;
            Assert.AreEqual(test_res, result4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 1;
            TriangleCalculator task4 = new TriangleCalculator();
            double result4 = task4.TriangleP(a);

            double test_res = 1;
            Assert.AreEqual(test_res, result4);
        }

    }
}
