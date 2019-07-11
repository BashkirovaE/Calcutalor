using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class RadXCalculatorTestCase
    {
        [TestCase(0, 0)]
        [TestCase(180, Math.PI)]
        [TestCase(-180, -Math.PI)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new RadXCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}