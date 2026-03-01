using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace var4
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тест - Проверка истинности высказывания 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            int A = 2;
            int B = 3;
            int C = 4;

            Task1 cl1 = new Task1();
            bool result = true;
            bool result1 = cl1.Methood1(A, B, C);

            Assert.AreEqual(result1, result);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Тест - калькулятор 
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            double A1 = 2;
            double B1 = 4;
            int Op = 4;

            Task2 cl2 = new Task2();
            double resultat = 6;
            double resultatresh = cl2.Calc(A1, B1, Op);
            Assert.AreEqual(resultat, resultatresh);
        }


    }

    [TestClass]
    public class UnitTest3
    {
        /// <summary>
        /// Тест - осадки
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            int N = 12;
            Task3 cl3 = new Task3();
            double resultat3 = 1234;
            double[] array = new double[31];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);

            }
            double resultatproverki = cl3.Osadki(array);
            Assert.AreEqual(resultat3, resultatproverki);
        }
    }

    [TestClass]
    public class UnitTest4
    {
        /// <summary>
        /// Тест - бинарное чисосло
        /// </summary>
        [TestMethod]
        public void TestMethood4()
        {
            Task4 cl4 = new Task4();
            string binarstr = Convert.ToString(1011);
            int resultst4 = 11;
            int  resultatresh4 = cl4.Binary(binarstr);
            Assert.AreEqual(resultst4, resultatresh4);

        }
    }
}
