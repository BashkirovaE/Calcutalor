using System;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class ArcsinCalculatorTestCase
    {
        [Test]
        public void ArcsinCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new ArcsinCalculator().Calculate(3));
            Assert.Throws<Exception>(() => new ArcsinCalculator().Calculate(-3));
        }

        [TestCase(0, 0)]
        [TestCase(1, 1.570)]
        [TestCase(-1, -1.570)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcsinCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}