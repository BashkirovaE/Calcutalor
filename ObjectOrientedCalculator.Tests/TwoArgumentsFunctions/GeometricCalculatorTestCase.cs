using System;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class GeometricCalculatorTestCase
    {
        [TestCase(3, 3, 3)]
        [TestCase(4, 12, 6.928)]
        [TestCase(2, 23, 6.782)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new GeometricCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}