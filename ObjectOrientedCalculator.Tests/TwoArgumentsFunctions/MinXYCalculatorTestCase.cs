using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class MinXYCalculatorTestCase
    {
        [TestCase(6, 3, 3)]
        [TestCase(-2, 0, -2)]
        [TestCase(-7, -63, -63)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinXYCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}