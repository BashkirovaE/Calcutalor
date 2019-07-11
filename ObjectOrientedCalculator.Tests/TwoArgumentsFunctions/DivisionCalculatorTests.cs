
using System;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void DivisionCalculatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new DivisionCalculator().Calculate(10, 0));
        }
        [Test]
        public void CalculateTest()
        {
            double expected = 0.333;
            double actual = new DivisionCalculator().Calculate(1, 3);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
