using NUnit.Framework;

namespace HomeWorkOne.test
{
    public class HWOneTest
    {
        HWOne hwOne;
        [SetUp]
        public void Setup()
        {
            hwOne = new HWOne();
        }

        [Test]
        [TestCase(2,4,true)]
        [TestCase(7, 92, true)]
        public void SwapVariableTest(int A, int B, bool expected)
        {           
            bool actual = hwOne.SwapVariable(A, B);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(3,4,5)]       
        public void FindHipotenuzaTest(double A,double B, double expected)
        {
           double actual =  hwOne.FindHipotenuza(A, B);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(10, 3, 5,5)]
        public void SolvingALinearEquationTest(double A, double B, double C, double expected)
        {
            double actual = hwOne.SolvingALinearEquation(A, B, C);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(5, 5, 25)]
        [TestCase(5,10, -5)]
        public void ActionProvidedTest(double A, double B, double expected)
        {
            double actual = hwOne.ActionProvided(A, B);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(12, 6, 2)]
        [TestCase(46, 2, 23)]
        public void CheckingForDivisionTest(double A, double B, double expected)
        {
            double actual = hwOne.CheckingForDivision(A, B);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(5, 3, 1)]
        [TestCase(-5, 5, 2)]
        [TestCase(-5, -10, 3)]
        [TestCase(5, -10, 4)]
        public void FindQuarter(int A, int B, int expected)
        {
            int actual = hwOne.FindQuarter(A, B);

            Assert.AreEqual(expected, actual);
        }
    }
}