using NUnit.Framework;

namespace HomeWorkTwo.tests
{
    public class Conditionstest
    {
        Conditions conditions;

        [SetUp]
        public void Setup()
        {
           conditions = new Conditions();
        }

        [Test]
        [TestCase(9, -6, 1, new double[] { 1 / 3d })]
        [TestCase(1, -5, 9, new double[] { 0 })]
        [TestCase(2/3d, 5/6d, -7/12d, new double[]{1/2d,-7/4d})]

        public void NumberOne(double A, double B, double C, double[] expected)
        {
           
           // подготовака
            
            // вызов тестируемого метода

            double[] array= conditions.NumberOne(A,B,C);
            // проверка результата
            if (array.Length > 1)
            {
                Assert.AreEqual(expected[0], array[0]);
                Assert.AreEqual(expected[1], array[1]);
            }
            else
            Assert.AreEqual(expected[0], array[0]);
        }
        
        [Test]
        [TestCase(3,4,8,true)]
        [TestCase(9, 4, 8,false)]
        public void NumberThree(int X, int Y, int r, bool expected)
        {          
           
           bool actual = conditions.NumberThree(X,Y,r);

            Assert.AreEqual(expected, actual);
        }
    }
}