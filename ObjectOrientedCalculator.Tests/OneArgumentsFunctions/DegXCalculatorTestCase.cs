using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class DegXCalculatorTestCase
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI, 180)]
        [TestCase(-Math.PI, -180)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new DegXCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}