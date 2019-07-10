
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class SinusCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            double expected = 0;
            double actual = new SinusCalculator().Calculate(0);
            Assert.AreEqual(expected, actual);
        }
    }
}