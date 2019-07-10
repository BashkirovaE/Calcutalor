using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class ArctanCalculatorTestCase
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.785)]
        [TestCase(-1, -0.785)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArctanCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}