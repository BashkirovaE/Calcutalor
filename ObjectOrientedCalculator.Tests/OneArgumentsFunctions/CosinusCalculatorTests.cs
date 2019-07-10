
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.OneArgumentsFunctions
{
    [TestFixture]
    public class CosinusCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            double expected = 1;
            double actual = new CosinusCalculator().Calculate(0);
            Assert.AreEqual(expected, actual);
        }
    }
}