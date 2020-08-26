using NUnit.Framework;

namespace HomeWorkFour.test
{
    public class HWFourTest

    {
        HWFour  hwFour;
        int[] array;

        [SetUp]
        public void Setup()
        {
            hwFour = new HWFour();
            
        }

        [Test]
        [TestCase(4,2,2)]
        [TestCase(9, 6, 3)]
        [TestCase(9, 9, 9)]
        [TestCase(0, 10, 0)]
        [TestCase(10, 0, 0)]
        [TestCase(-10, 6, 0)]
        [TestCase(10, -6, 0)]
        [TestCase(21, 14, 7)]
        public void EvklidTest(int var1,int var2, int expected)
        {
            int actual = hwFour.Evklid(var1, var2);

            Assert.AreEqual(expected,actual);
        }
        [TestCase(new int[] { 10, 3, 5, 7, 2, 4, 6 }, 2)]
        public void MinArrayTest(int[] array, int expected)
        {
            int actual = hwFour.MinArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 3, 5, 7, 2, 4, 6 }, 10)]
        public void MaxArrayTest(int[] array, int expected)
        {
            int actual = hwFour.MaxArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 3, 5, 7, 2, 4, 6 }, new int[] { 2, 3, 4, 5, 6, 7, 10 })]
        [TestCase(new int[] { 10, -3, 5, 7, 2, 4, 6 }, new int[] { -3, 2, 4, 5, 6, 7, 10 })]
        [TestCase(new int[] { 10, 3, 5, 0, 2, -4, 6 }, new int[] { -4, 0, 2, 3, 5, 6, 10 })]
        [TestCase(new int[] { 10, 3, 5, 0, 0, 4, 6, 9, -57, 32, 12 }, new int[] {-57, 0, 0, 3, 4, 5, 6, 9,10,12,32 })]
        [TestCase(new int[] {}, new int[] {})]
        [TestCase(new int[] {-1,0,1,-1,0,1 }, new int[] {-1,-1,0,0,1,1 })]
        public void SortArrayTest(int[] array, int[] expected)
        {
            int[] actual = hwFour.SortArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 1,10 , 21.170000000000002)]
        [TestCase(3, -1, 10, 0)]
        [TestCase(3, 0, 10, 20.1)]
        public void SummaAllCaloriyInFatTest(double tKg, double vKg, double cKg, double expected)
        {
            double actual = hwFour.SummaAllCaloriyInFat(tKg, vKg, cKg);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 2, 1, 24, 1195)]
        [TestCase(0, 0, 0, 24, 0)]
        [TestCase(-1, 6, 0, 24, 0)]
        public void TotalCaloriesBurnedInGameTest(double hourPratki, double hourDogon, double hourshahmati, double hourDota, double expected)
        {
            double actual = hwFour.TotalCaloriesBurnedInGame(hourPratki, hourDogon, hourshahmati, hourDota);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(300, 10)]
        [TestCase(-10, 0)]
        [TestCase(0, 0)]
        public void CaloriiInFatTest(double grammFat, double expected)
        {
            double actual = hwFour.CaloriiInFat(grammFat);

            Assert.AreEqual(expected, actual);
        }
    }
}