using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace HomeWorkTwo.tests
{
    class CyclesTest
    {
        Cycles cycles = new Cycles();     
        [Test]
        [TestCase(2,4, 16)]
        [TestCase(3, 4, 81)]
        public void NumberOne(double A, double B, double expected)
        {           

            double actual = cycles.NumberOne(A, B);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(10, new double[] { 2, 5, 10 })]
        [TestCase(0, new double[] {})]
        [TestCase(-200, new double[] { 2.0d, 4.0d, 5.0d, 8.0d, 10.0d, 20.0d, 25.0d, 40.0d, 50.0d, 100.0d,200 })]
        public void NumberTwo(double A, double[] expected)
        {           
            List<double> actual = cycles.NumberTwo(A);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Contains(expected[i], actual);

            }
        }
        [Test]
        [TestCase(3,true)]        
        public void NumberThree(int N, bool expected)
        {           
            bool actual=cycles.NumberThree(N);

            Assert.AreEqual(expected, actual);
            
        }
        [Test]
        [TestCase(4, new double[] { 1, 1, 2, 3 })]
        public void NumberFour(int N,double [] expected)
        {
            double[] actual = cycles.NumberFour(N);

            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        [Test]
        [TestCase(10,5)]
        [TestCase(100, 50)]
        public void NumberFive(double A, double expected)
        {           
            double actual = cycles.NumberFive(A);

            Assert.AreEqual(expected, actual);
        }
    }
}
