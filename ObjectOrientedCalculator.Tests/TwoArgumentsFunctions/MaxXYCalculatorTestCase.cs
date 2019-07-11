using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class MaxXYCalculatorTestCase
    {
        [TestCase(6, 3, 6)]
        [TestCase(-2, 0, 0)]
        [TestCase(-7, -63, -7)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaxXYCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}