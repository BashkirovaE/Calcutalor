
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            double expected = 6;
            double actual = new MultiplyCalculator().Calculate(2, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
