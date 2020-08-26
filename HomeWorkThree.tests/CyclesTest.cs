using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree.tests
{
    class CyclesTest
    {
        Cycles cycles;
        [SetUp]
        public void Setup()
        {
            cycles = new Cycles();

        }

        [Test]
        [TestCase(123, 963, true)]
        [TestCase(658, 971, false)]
        public void SameDigitTest(int var1, int var2, bool expected)
        {
            bool actual = cycles.SameDigit(var1, var2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(123 ,new int[]{3, 2, 1} )]
        
        public void NumberViceVersaTest(int var1, int[] expected)
        {
          
           List<int> actual = cycles.TwoTask(var1);
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
            
        }
        
    }
}
