using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree.tests
{
    class NestedCyclesTest
    {
       NestedCycles nested;
        [SetUp]
        public void Setup()
        {
            nested = new NestedCycles();

        }

        [Test]
        [TestCase(3, 963, 1)]
        [TestCase(5, 555, 3)]
        [TestCase(5, 666, 0)]
        public void SameDigitTest(int var1, int var2, int expected)
        {
            int actual = nested.SameNumber(var1, var2);
            Assert.AreEqual(expected, actual);
        }
    }
}
