using System;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class DivCalculatorTestCase
    {
        [Test]
        public void DivCalculatorExceptionTest()
        {
            Assert.Throws<Exception>(() => new DivCalculator().Calculate(5, 0));
        }

        [TestCase(6, 3, 2)]
        [TestCase(5, 2, 2)]
        [TestCase(-7, 4, -1)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}