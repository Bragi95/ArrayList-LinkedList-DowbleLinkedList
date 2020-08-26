using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree.tests
{
    class TwoArrayTest
    {
        TwoArray twoArray;
        int[,] array;
        
        [SetUp]
        public void Setup()
        {
            twoArray = new TwoArray();
            array = new int[3,3];
            array[0, 0] = 1;
            array[0, 1] = 1;
            array[0, 2] = 1;
            array[1, 0] = 1;
            array[1, 1] = 2;
            array[1, 2] = 1;
            array[2, 0] = 1;
            array[2, 1] = 1;
            array[2, 1] = 1;
            
        }

        [Test]
        [TestCase(2)]
       
        public void SameDigitTest( int expected)
        {
            int actual = twoArray.FindPointArray(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
