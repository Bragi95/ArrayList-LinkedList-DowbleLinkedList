using NUnit.Framework;
using HWLinkedList;
using System;

namespace HWLinkedList.tests
{
    public class LinkedListTests
    {
        LinkedList linkedList;
        [SetUp]
        public void Setup()
        {
            linkedList = new LinkedList();
            linkedList.RemoveAll();
        }

        [Test]

        [TestCase(12,12)]
        [TestCase(-12, -12)]
        [TestCase(0, 0)]
        [TestCase(123, 123)]
        
        public void AddFirstTest(int value, int expected)
        {
            
            linkedList.AddFirst(value);
            int actual = linkedList.Head.Value;

            Assert.AreEqual(expected,actual);
        }


        [TestCase(new int[] { 1, 1, }, new int[] { 2, 3 }, new int[] { 3, 2, 1, 1, })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 2 }, new int[] { 2, 1 })]       

        public void AddFirstArrTest(int[] array,int[] value, int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.AddFirst(value);
            
            int[] actual = linkedList.ToArray();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, 5)]
        [TestCase(-123, -123)]
        [TestCase(0, 0)]

        public void AddLastTest(int value, int expected)
        {
           
            linkedList.AddLast(value);

            int actual = linkedList.Tail.Value;

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { -1, 2, 3, -4 }, -4)]
        [TestCase(new int[] { }, null)]
        public void AddLastArrTest(int[] value, int? expected)
        {
            
            linkedList.AddLast(value);

            int? actual = linkedList.Tail?.Value;

            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 4, new int[] { 1, 2, 3, 4 },2)]
        [TestCase(2, 4, new int[] { 1, 2, 3, 4 }, 3)]       
        
        public void AddAtTest(int index,int value,int[] array, int expected)
        {
            if (index < 0)
            {
                Assert.Throws<Exception>(() => linkedList.AddAt(-1, 2));
            }

            int actual = 0; ;
            linkedList.AddLast(array);
            linkedList.AddAt(index,value);
            int con = 0;
            Node count=linkedList.Head;         
            while(count!=null)
            {
                if(index == con)
                {
                    actual = count.Next.Value;
                }
                count = count.Next;
                con++;
            }
            

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddAtWithException()
        {
            Assert.Throws<Exception>(()=>linkedList.AddAt(-1, 2));
        }

        [TestCase(1, new int[] { 5, 5, 5, 5 }, new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(2, new int[] { 5, 5, 5, 5 }, new int[] { 1, 2, 3, 4 }, 3)]       
        [TestCase(-1, new int[] { 5, 5, 5, 5 }, new int[] { 1, 2, 3, 4 }, 1)]

        public void AddAtArrTest(int index, int[] value, int[] array, int expected)
        {
            if (index < 0)
            {
                Assert.Throws<Exception>(() => linkedList.AddAt(-1, 2));
            }
            else
            {
                int actual = 0;
                linkedList.AddLast(array);
                linkedList.AddAt(index, value);
                int con = 0;
                Node count = linkedList.Head;
                while (count != null)
                {
                    if (index + value.Length - 1 == con)
                    {
                        actual = count.Next.Value;
                    }
                    count = count.Next;
                    con++;
                }
                Assert.AreEqual(expected, actual);
            }
        }
        [TestCase(new int[] { 1, 3, 5, 7, 2 },5)]
        [TestCase(new int[] {},0)]
        [TestCase(new int[] { -1, -3, 5, -7, 2 },5)]
        public void GetSizeTest(int[] array, int expected)
        {
            linkedList.AddLast(array);
            int actual = linkedList.GetSize();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 2,4,4)]
        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 0, 3, 3)]
       
        public void SetTest(int[] array, int index, int value, int expected)
        {
            linkedList.AddLast(array);
            linkedList.Set(index, value);
            int actual = 0;
            int count = 0;
            Node con = linkedList.Head;
            while (con != null)
            {
                if (index == count)
                {
                    actual = con.Value;
                    break;
                }

                con = con.Next;
                count++;
            }
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SetWithException()
        {
            Assert.Throws<Exception>(() => linkedList.Set(-1, 2));
        }


        [TestCase(new int[] { 1, 3, 5, 6, 2 }, new int[] {  3, 5, 6,2 })]
        [TestCase(new int[] { 1, 5, 5, 7, 2 }, new int[] {  5, 5, 7,2 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirstTest(int[] array,  int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.RemoveFirst();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 6, 2 }, new int[] { 1, 3, 5, 6 })]
        [TestCase(new int[] { 1, 5, 5, 7, 2 }, new int[] { 1, 5, 5, 7})]
        [TestCase(new int[] { 1 }, new int[] { })]

        public void RemoveLastTest(int[] array, int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.RemoveLast();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 6, 2 }, 1,new int[] { 1,  5, 6,2 })]
        [TestCase(new int[] { 1, 5, 5, 7, 2 }, 3,new int[] { 1, 5, 5, 2 })]
        [TestCase(new int[] { 1 },0 ,new int[] { })]

        public void RemoveAtTest(int[] array, int index,int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.RemoveAt(index);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 6, 2 },  new int[] { })]
        [TestCase(new int[] { 1, 5, 5, 7, 2 },  new int[] {  })]
        [TestCase(new int[] { 1 },  new int[] { })]

        public void RemoveAllTest(int[] array, int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.RemoveAll();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 6, 2 },3 ,new int[] { 1, 5, 6, 2 })]
        [TestCase(new int[] { 1, 5, 5, 7, 2 }, 5,new int[] { 1, 7, 2 })]
        [TestCase(new int[] { 1 }, 4,new int[] { 1 })]
        
        public void RemoveAllValueTest(int[] array,int value ,int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.RemoveAll(value);
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 7, 2 },3,true)]
        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 40, false)]
        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 7, true)]
        public void ContainsTest(int[] array,int value, bool expected)
        {
            linkedList.AddLast(array);
            bool actual = linkedList.Contains(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 3, 1)]
        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 5, 2)]
        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 234523, -1)]
        public void IndexOfTest(int[] array, int value, int expected)
        {
            linkedList.AddLast(array);
            int actual = linkedList.IndexOf(value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 2 }, new int[] { 2, 7, 5, 3, 1 })]
        [TestCase(new int[] { 1, 3, 5, 7, 2,4 }, new int[] { 4, 2, 7, 5, 3, 1 })]

        public void ReversTest(int[] array,  int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.Reverse();
            int [] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 2 },3,7  )]
        [TestCase(new int[] { 1, 3, 5, 7, 2, 4 },0,1 )]
        

        public void GetTest(int[] array,int index, int expected)
        {
            if(index>array.Length-1 || index<0)
            {
                Assert.Throws<Exception>(() => linkedList.Get(-1));
            }

            linkedList.AddLast(array);
            linkedList.Get(index);
            int actual = linkedList.Get(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 2 }, new int[] { 1, 2, 3, 5, 7 })]
        [TestCase(new int[] { }, new int[] {  })]

        public void SortTest(int[] array, int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.Sort();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 1, 3, 5, 7, 2 }, new int[] { 7, 5, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]

        public void SortDescTest(int[] array, int[] expected)
        {
            linkedList.AddLast(array);
            linkedList.SortDesc();
            int[] actual = linkedList.ToArray();
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 7)]
        [TestCase(new int[] { }, 0)]

        public void MaxTest(int[] array, int expected)
        {
            linkedList.AddLast(array);
            int actual = linkedList.Max();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 1)]
        [TestCase(new int[] { }, 0)]

        public void MinTest(int[] array, int expected)
        {
            linkedList.AddLast(array);
            int actual = linkedList.Min();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 3)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] {  }, -1)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            linkedList.AddLast(array);
            int actual = linkedList.IndexOfMax();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 7, 2 }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            linkedList.AddLast(array);
            int actual = linkedList.IndexOfMin();
            Assert.AreEqual(expected, actual);
        }
    }    
}