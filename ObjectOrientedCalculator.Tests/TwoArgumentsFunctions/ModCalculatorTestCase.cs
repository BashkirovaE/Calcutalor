using System;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class ModCalculatorTestCase
    {
        [Test]
        public void ModCalculatorExceptionTest()
        {
            Assert.Throws<Exception>(() => new ModCalculator().Calculate(10, 0));
        }
        [TestCase(6, 3, 0)]
        [TestCase(5, 2, 1)]
        [TestCase(-7, 4, -3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new ModCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}