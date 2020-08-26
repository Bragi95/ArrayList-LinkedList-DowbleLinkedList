using NUnit.Framework;

namespace HomeWorkThree.tests
{
    public class CalculateTest
    {
        ActionCalc calc;
        [SetUp]
        public void Setup()
        {
            calc = new ActionCalc();

        }

        [Test]
        [TestCase(new double[] {10,10,10 },30)]
        [TestCase(new double[] { 10, 5, 10 }, 25)]
        [TestCase(new double[] { -10, 10, 10 }, 10)]
        public void SummTest(double[] array, double expected)
        {
            double actual = calc.Summ(array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase(new double[] { 40, 10, 10 }, 20)]
        [TestCase(new double[] { 10, 5, 10 }, -5)]
        [TestCase(new double[] { 10, 10 }, 0)]
        public void DeductTest(double[] array, double expected)
        {
            double actual = calc.Deduct(array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase(new double[] { 10, 10, 10 }, 1000)]
        [TestCase(new double[] { -10, 5, 10 }, -500)]
        [TestCase(new double[] { 0, 10 }, 0)]
        public void MultiplyTest(double[] array, double expected)
        {
            double actual = calc.Multiply(array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase(new double[] { 40, 10, 10 }, 0.4d)]
        [TestCase(new double[] { -10, 5, 10 }, -0.2d)]
        [TestCase(new double[] { 10, 10 }, 1)]
        [TestCase(new double[] { 0, 10 }, 0)]
        public void DivideTest(double[] array, double expected)
        {
            double actual = calc.Divide(array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(2, 4, 16)]
        [TestCase(5, 3, 125)]
        [TestCase(3, 4, 81)]
        public void PowTest(double D,double P, double expected)
        {
            double actual = calc.Pow(D,P);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(81,  9)]
        [TestCase(100,  10)]
        [TestCase(25,  5)]
        public void SqrtTest(double D, double expected)
        {
            double actual = calc.Sqrt(D);
            Assert.AreEqual(expected, actual);
        }
    }
}