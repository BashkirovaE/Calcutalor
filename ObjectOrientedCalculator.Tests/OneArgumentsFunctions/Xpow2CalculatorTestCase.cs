using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class Xpow2CalculatorTestCase
    {
        [TestCase(2, 4)]
        [TestCase(-2, 4)]
        [TestCase(-7, 49)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Xpow2Calculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}