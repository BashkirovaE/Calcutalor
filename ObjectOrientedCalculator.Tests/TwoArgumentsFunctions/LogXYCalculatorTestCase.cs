using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class LogXYCalculatorTestCase
    {
        [TestCase(100, 10, 2)]
        [TestCase(1000, 10, 3)]
        [TestCase(10, 100, 0.5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogXYCalculator();
            var actual = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}