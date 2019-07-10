
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.TwoArgumentsFunctions
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            double expected = -32;
            double actual = new AdditionCalculator().Calculate(-33, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}