using System;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class AverageCalculatorTestCase
    {
        [TestCase(6, 3, 4.5)]
        [TestCase(-2, 0, -1)]
        [TestCase(-7, -63, -35)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AverageCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}