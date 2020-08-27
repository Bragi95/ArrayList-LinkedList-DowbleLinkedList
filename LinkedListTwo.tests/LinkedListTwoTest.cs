using NUnit.Framework;
using System;
using System.Data;

namespace LinkedListTwo.tests
{
    public class LinkedListTwoTest
    {
        LListTwo lList;
        [SetUp]
        public void Setup()
        {
            lList = new LListTwo();
            lList.RemoveAll();
        }

        [Test]
        [TestCase(new int[] {1,1,1,1,1,1 },2,new int[] {2,1,1,1,1,1,1 })]
        [TestCase(new int[] { }, 2, new int[] { 2 })]
        [TestCase(new int[] {1}, 2, new int[] { 2, 1})]
        [TestCase(new int[] {}, 0, new int[] {0})]
        public void AddFirstTest(int[] array, int value, int[] expected)
        {
            lList.AddLast(array);
            lList.AddFirst(value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 1  }, new int[] { 2,3 }, new int[] { 3,2, 1, 1 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 2}, new int[] { 2, 1 })]
        [TestCase(new int[] { }, new int[] {2 }, new int[] { 2 })]
        public void AddFirstArrTest(int[] array, int[] value, int[] expected)
        {
            lList.AddLast(array);
            lList.AddFirst(value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 1, }, new int[] { 2, 3 }, new int[] {  1, 1,2,3 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 2 }, new int[] {  1,2 })]
        [TestCase(new int[] { }, new int[] { 2 }, new int[] { 2 })]
        public void AddLastArrTest(int[] array, int[] value, int[] expected)
        {
            lList.AddLast(array);
            lList.AddLast(value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] {1,2,3 },2,5 , new int[] {1,2,5,3 })]
        [TestCase(new int[] {}, 2, 5, new int[] {5})]
        [TestCase(new int[] { 1, 2, 3 }, 0, -5, new int[] { -5,1, 2,  3 })]       
        public void AddAtTest(int[] array,int index, int value, int[] expected)
        {
            lList.AddLast(array);
            lList.AddAt(index, value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 2, 3 }, new int[] { 1, 2, 2, 3,3 })]
        [TestCase(new int[] { }, 2, new int[] { 2, 3 }, new int[] {})]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 5, 5 }, new int[] { 5,5, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 12, new int[] { 5, 5 }, new int[] { 1, 2, 3 })]
        public void AddAtArrTest(int[] array, int index, int[] value, int[] expected)
        {
            lList.AddLast(array);
            lList.AddAt(index, value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] {2,4,6,8,10 }, 2,100, new int[] {2,4,100,8,10 }  )]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 0, 100, new int[] { 100, 4, 6, 8, 10 })]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 15, 100, new int[] {  2, 4, 6, 8, 10 })]
        public void SetTest(int[] array, int index,int value, int[] expected)
        {
            lList.AddLast(array);
            lList.Set(index, value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 },  new int[] {  4, 6, 8, 10})]
        [TestCase(new int[] { }, new int[] {  })]
        public void RemoveFirstTest(int[] array, int[]expected)
        {
            lList.AddLast(array);
            lList.RemoveFirst();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 4, 6, 8, 10 }, new int[] { 2,4, 6, 8 })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            lList.AddLast(array);
            lList.RemoveLast();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 },1, new int[] { 2, 6, 8,10 })]
        [TestCase(new int[] { },0, new int[] { })]
        public void RemoveAtTest(int[] array,int index, int[] expected)
        {
            lList.AddLast(array);
            lList.RemoveAt(index);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveAllTest(int[] array, int[] expected)
        {
            lList.AddLast(array);
            lList.RemoveAll();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 6, 2 }, 3, new int[] { 1, 5, 6, 2 })]
        [TestCase(new int[] { 1, 5, 5, 7, 2 }, 5, new int[] { 1, 7, 2 })]
        [TestCase(new int[] { 1 }, 4, new int[] { 1 })]

        public void RemoveAllValueTest(int[] array, int value, int[] expected)
        {
            lList.AddLast(array);
            lList.RemoveAll(value);
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 },6,true)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 0, false)]
        public void ContainsTest(int[] array,int value, bool expected )
        {
            lList.AddLast(array);
            bool actual = lList.Contains(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 },2,0)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 10, 4)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 15, -1)]
        public void IndexOfTest(int[] array, int value, int expected)
        {
            lList.AddLast(array);
            int actual = lList.IndexOf(value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 4, 6, 8, 10 }, new int[] { 10,8,6,4,2})]
        [TestCase(new int[] {}, new int[] {})]
        public void ReversTest(int[] array,  int[] expected)
        {
            lList.AddLast(array);
            lList.Reverse();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 },2)]        
        public void GetFirstTest(int[] array, int? expected)
        {
            lList.AddLast(array);
            if (lList.Head == null)
            {
                Assert.Throws<Exception>(() => lList.GetFirst());
            }
            int? actual = lList.GetFirst();
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void GetFirstTestWithException()
        {
            Assert.Throws<Exception>(() => lList.GetFirst());
        }



        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 10)]
        public void GetLastTest(int[] array, int expected)
        {
            lList.AddLast(array);
            if (lList.Tail == null)
            {
                Assert.Throws<Exception>(() => lList.GetLast());
            }
            int actual = lList.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetLastTestWithException()
        {
            Assert.Throws<Exception>(() => lList.GetLast());
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 0,2)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 4, 10)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 5, 0)]
        public void GetTest(int[] array,int index,  int expected)
        {
            lList.AddLast(array);
            int actual = lList.Get(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 4, 6, 8, 10 },  10)]
        [TestCase(new int[] { },  0)]
        [TestCase(new int[] { 2 },2 )]
        public void MaxTest(int[] array,  int expected)
        {
            lList.AddLast(array);
            int actual = lList.Max();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 2)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 2 }, 2)]
        public void MinTest(int[] array, int expected)
        {
            lList.AddLast(array);
            int actual = lList.Min();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 4)]
        [TestCase(new int[] { }, 0)]
        public void IndexOfMax(int[] array, int expected)
        {
            lList.AddLast(array);
            int actual = lList.IndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 0)]
        [TestCase(new int[] { }, 0)]
        public void IndexOfMin(int[] array, int expected)
        {
            lList.AddLast(array);
            int actual = lList.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 6, 4, 8, 2 }, new int[] { 2, 4, 6, 8, 10 })]
        [TestCase(new int[] {}, new int[] {})]
        public void SortTest(int[] array, int[] expected)
        {
            lList.AddLast(array);
            lList.Sort();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 10, 6, 4, 8, 2 }, new int[] { 10,8,6,4,2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortDescTest(int[] array, int[] expected)
        {
            lList.AddLast(array);
            lList.SortDesc();
            int[] actual = lList.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}