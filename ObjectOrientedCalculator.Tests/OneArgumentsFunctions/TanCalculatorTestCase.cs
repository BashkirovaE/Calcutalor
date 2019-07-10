using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class TanCalculatorTestCase
    {
        [TestCase(1, 1.557)]
        [TestCase(Math.PI, 0)]
        [TestCase(Math.PI/4, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TanCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}