using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class CtanCalculatorTestCase
    {
        [Test]
        public void CtanCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new CtanCalculator().Calculate(0));
        }

        [TestCase(Math.PI/6, 1.732)]
        [TestCase(Math.PI/4, 1)]
        [TestCase(Math.PI/2, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CtanCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}