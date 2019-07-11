using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class ArccosCalculatorTestCase
    {
        [TestCase(0, 1.570)]
        [TestCase(1, 0)]
        [TestCase(-1, 3.141)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArccosCalculator();
            var actual = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}