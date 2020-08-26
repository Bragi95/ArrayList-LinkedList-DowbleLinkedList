using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace HomeWorkTwo.tests
{
    class ArrayTest
    {
        int[] array;
        int[] arrayRevers;
        [SetUp]
        public void SetUp()
        {
            Random random = new Random();

            array = new int[20];
           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);                
            }
            arrayRevers = new int[20];
            Array.Copy(array, arrayRevers,array.Length);
        }
        Arrays arraytest = new Arrays();                         
        [Test]
        public void MaxValueArrayTest()
        {
            int maxExpected = array.Max();

            int actualMax = arraytest.MaxValueArray(array);

            Assert.AreEqual(maxExpected, actualMax);
        }

        [Test]

        public void SummOddElementArrayTest()
        {
            int expected = array.Where((x,index) => index%2 != 0).Sum(); // 

            int actual = arraytest.SummOddElementArray(array);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        
        public void SummElementLessAVGTest()
        {
            int[] expected = array.Where((x) => x< array.Average()).ToArray();  
            List<int> actual = arraytest.SummElementLessAVG(array);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
        [Test]

        public void ReversArrayTest()
        {
            Array.Reverse(arrayRevers);
            arraytest.ReversArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(arrayRevers[i], array[i]);
            }
            
        }
    }
}
