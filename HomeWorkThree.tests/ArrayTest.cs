using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkThree.tests
{
    class ArrayTest
    {
        OneArray OneArray;
        int[] array;
        int[] arrayRevers;
        [SetUp]
        public void Setup()
        {
            OneArray = new  OneArray();
            arrayRevers = new int[] { 45, -12, 96, 15,84, 1, 2, 3, -2 };
            array = new int[] {1,2,3,-2,84,45,-12,96,15};
           
        }

        [Test]
        [TestCase(96,1,120)]

        public void SameDigitTest(int Max,int Min,int expected)
        {
            int actual = OneArray.SummDigitBetweenMinAndMax(Max,Min,array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        

        public void ReversArrayTest()
        {
            
            int[] actual = OneArray.ReversArray( array);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(arrayRevers[i], actual[i]);
            }
           
        }
    }
}
