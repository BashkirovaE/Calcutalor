
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class SubtractionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            double expected = -34;
            double actual = new SubtractionCalculator().Calculate(-33, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}