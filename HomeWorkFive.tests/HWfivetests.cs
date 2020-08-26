using NUnit.Framework;

namespace HomeWorkFive.tests
{
    public class HWfivetests
    {
        
        int[] array;
        int[] array2;
        HWFive hWFive;
        [SetUp]
        public void Setup()
        {
            
            array = new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1 };
            hWFive = new HWFive(array);
        }

        [Test]
        [TestCase(30,new int[] {30, 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(15, new int[] { 15, 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1})]
        [TestCase(0, new int[] { 0, 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1})]
        [TestCase(-40, new int[] { -40, 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(123456, new int[] { 123456, 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1})]
        public void AddFirsttest(int value, int[] expected)
        {
            int[] actual = hWFive.AddFirst(value);
            Assert.AreEqual(expected,actual);
        }
        [TestCase(new int[] {1,2 }, new int[] { 1,2, 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(new int[] { 1, 2,3 }, new int[] { 1, 2,3, 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0, 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1})]
        [TestCase(new int[] { -1, -2, -3 }, new int[] { -1, -2, -3, 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(new int[] {  }, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1})]
        public void AddFirstArrtest(int[] value, int[] expected)
        {
            int[] actual = hWFive.AddFirstArr(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1,1 })]
        [TestCase(0, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1, 0 })]
        [TestCase(-15, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1, -15 })]
        [TestCase(12, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1, 12 })]
        [TestCase(59874, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1, 59874 })]
        public void AddLastTest(int value, int[] expected)
        {
            int[] actual = hWFive.AddLast(value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { }, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(new int[] {1,2 }, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1,1,2 })]
        [TestCase(new int[] { 0,0}, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1,0,0})]
        [TestCase(new int[] { -12,-5}, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1,-12,-5 })]
        [TestCase(new int[] {9,8,7,6,5,4,3,2,1 }, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1,9,8,7,6,5,4,3,2,1 })]
        public void AddLastArrArrtest(int[] value, int[] expected)
        {
            int[] actual = hWFive.AddLast(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,59874, new int[] { 1, 59874, 2, 3, 6, 9, 13, 56, -1,0,1})]
        [TestCase(0, 59874, new int[] { 59874, 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(-1, 59874, new int[] { })]
        [TestCase(4, 59874, new int[] { 1, 2, 3, 6, 59874, 9, 13, 56, -1, 0,1 })]
        [TestCase(15, 59874, new int[] { })]
        public void AddAtTest(int index,int value, int[] expected)
        {
            int[] actual = hWFive.AddAt(value,index);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-1, new int[] { 1,2,4}, new int[] { })]
        [TestCase(4, new int[] { 1, 2, 4 }, new int[] { 1, 2, 3, 6, 1, 2, 4, 9, 13, 56, -1, 0,1 })]
        [TestCase(7, new int[] { 1, 2, 4 }, new int[] { 1, 2, 3, 6,  9, 13, 56, 1, 2, 4, - 1, 0,1 })]
        [TestCase(1, new int[] { 1, 2, 4 }, new int[] { 1, 1, 2, 4, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(2, new int[] { }, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0,1 })]
        public void AddAtArrtest(int index,int[] value, int[] expected)
        {
            int[] actual = hWFive.AddAt(value,index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase( new int[] { 1,2,3}, 3 )]
        [TestCase(new int[] {}, 0)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetSizetest( int[] value, int expected)
        {
            int actual = hWFive.GetSize(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1 ,new int[] { 1, 2, 1, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(-1, 1, new int[] { })]
        [TestCase(0, 1, new int[] { 1, 2, 3, 6, 9, 13, 56, -1, 0 ,1})]
        [TestCase(5, 92, new int[] { 1, 2, 3, 6, 9, 92, 56, -1, 0,1 })]
        [TestCase(15, 5, new int[] {})]
        public void Settest(int index,int value, int[] expected)
        {
            int[] actual = hWFive.Set(index,value);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] {1,2,3,4,5 }, new int[] {2,3,4,5 })]
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] { 1}, new int[] {})]
        
        public void RemoveFirstTest( int[] value, int[] expected)
        {
            int[] actual = hWFive.RemoveFirst( value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {1, 2, 3, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { })]

        public void RemoveLastTest(int[] value, int[] expected)
        {
            int[] actual = hWFive.RemoveLast(value);
            Assert.AreEqual(expected, actual);
        }


        
                [TestCase(0, new int[] { 2, 3, 6, 9, 13, 56, -1, 0,1 })]
                [TestCase(-1, new int[] { })]
                [TestCase(20, new int[] { })]
                [TestCase(2, new int[] { 1, 2,  6, 9, 13, 56, -1, 0,1 })]
                public void RemoveAttTest(int index, int[] expected)
                {
                    int[] actual = hWFive.RemoveAtt(index);
                    Assert.AreEqual(expected, actual);
                }


                [TestCase(15, 5, new int[] { })]
                public void Settet(int index, int value, int[] expected)
                {
                    int[] actual = hWFive.Set(index, value);
                    Assert.AreEqual(expected, actual);
                }
                


        [TestCase(30, new int[] { 1, 2,3, 6, 9, 13, 56, -1, 0,1 })]
        [TestCase(0, new int[] { 1, 2, 3, 6, 9, 13, 56, -1,1 })]
        [TestCase(1, new int[] {  2, 3, 6, 9, 13, 56, -1, 0 })]
        [TestCase(56, new int[] { 1, 2, 3, 6, 9, 13,  -1, 0 ,1})]

        public void RemoveAllTest(int value, int[] expected)
        {
            int[] actual = hWFive.RemoveAll(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(56, true)]
        [TestCase(23, false)]

        public void ContainsTest(int value, bool expected)
        {
           bool actual = hWFive.Contains(value);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(56, 6)]
        [TestCase(23, -1)]

        public void IndexOfTest(int value, int expected)
        {
            int actual = hWFive.IndexOf(value);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] {1,2,3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] {  }, new int[] { })]
        public void ToArrayTest(int[] value, int[] expected)
        {
            int[] actual = hWFive.ToArray(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 },  1)]
        [TestCase(new int[] { }, 0)]
        public void GetFirstTest(int[] value, int expected)
        {
            int actual = hWFive.GetFirst(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { }, 0)]
        public void GetLastTest(int[] value, int expected)
        {
            int actual = hWFive.GetLast(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(-1, 0)]
        [TestCase(1, 2)]
        [TestCase(15, 0)]
        public void GetTest(int index, int expected)
        {
            int actual = hWFive.Get(index);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] {1,2,3 } , new int[] {3,2,1 })]
        [TestCase(new int[] { 1, 2, 3,4 }, new int[] { 4,3, 2, 1 })]
        [TestCase(new int[] {  }, new int[] { })]
        public void ReversTest(int[] value, int[] expected)
        {
            int[] actual = hWFive.Reverse(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,3 }, 3)]
        [TestCase(new int[] {  }, 0)]
       
        public void MaxTest(int[] value, int expected)
        {
            int actual = hWFive.Max(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1,2,3}, 1)]
        [TestCase(new int[] { }, 0)]
        public void MinTest(int[] value, int expected)
        {
            int actual = hWFive.Min(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMaxTest(int[] value, int expected)
        {
            int actual = hWFive.IndexOfMax(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMinTest(int[] value, int expected)
        {
            int actual = hWFive.IndexOfMin(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3,2,1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 3, 2, 1,3,5,7,1 }, new int[] { 1,1, 2,3, 3,5,7 })]
        [TestCase(new int[] { -3, -2, -1, -3, -5, -7, 1 }, new int[] { -7,-5,-3,-3,-2,-1,1 })]
        [TestCase(new int[] { }, new int[] {  })]
        public void SortTest(int[] value, int[] expected)
        {
            int[] actual = hWFive.Sort(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3,2,1 })]
        [TestCase(new int[] { 3, 2, 1, 3, 5, 7, 1 }, new int[] { 7,5,3,3,2,1,1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortDescTest(int[] value, int[] expected)
        {
            int[] actual = hWFive.SortDesc(value);
            Assert.AreEqual(expected, actual);
        }
    }
}