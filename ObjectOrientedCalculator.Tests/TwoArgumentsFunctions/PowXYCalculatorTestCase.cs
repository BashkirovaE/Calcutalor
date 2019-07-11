using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class PowXYCalculatorTestCase
    {
        [TestCase(2, 3, 8)]
        [TestCase(-2, 0, 1)]
        [TestCase(-7, 1, -7)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new PowXYCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}