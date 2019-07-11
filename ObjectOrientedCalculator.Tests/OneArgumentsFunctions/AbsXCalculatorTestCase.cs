using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class AbsXCalculatorTestCase
    {
        [TestCase(-1, 1)]
        [TestCase(20, 20)]
        [TestCase(0, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new AbsXCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}