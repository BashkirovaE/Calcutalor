using System;
using NUnit.Framework;
using ObjectOrientedCalculator.OneArgumentsFunctions;

namespace ObjectOrientedCalculator.Tests
{
    [TestFixture]
    public class OneArgumentExtentionTests
    {
        [Test]
        public void OnedivXCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new OnedivXCalculator().Calculate(0));
        }
        [Test]
        public void ArccosCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new ArccosCalculator().Calculate(3));
            Assert.Throws<Exception>(() => new ArccosCalculator().Calculate(-3));
        }
        [Test]
        public void ArcsinCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new ArcsinCalculator().Calculate(3));
            Assert.Throws<Exception>(() => new ArcsinCalculator().Calculate(-3));
        }
        [Test]
        public void CtanCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new CtanCalculator().Calculate(0));
        }
        [Test]
        public void LnXCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new LnXCalculator().Calculate(-10));
        }
        [Test]
        public void TanCaltulatorExtentionTest()
        {
            Assert.Throws<Exception>(() => new TanCalculator().Calculate(Math.PI / 2));
            Assert.Throws<Exception>(() => new TanCalculator().Calculate(Math.PI / 2*3));
        }
    }
}