using System;
using ObjectOrientedCalculator.Factories;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.Factories
{
    [TestFixture]
    public class OneArgumentFactoryTestCase
    {
        [TestCase("absx", typeof(AbsXCalculator))]
        [TestCase("acos", typeof(ArccosCalculator))]
        [TestCase("asin", typeof(ArcsinCalculator))]
        [TestCase("atan", typeof(ArctanCalculator))]
        [TestCase("cos", typeof(CosinusCalculator))]
        [TestCase("ctan", typeof(CtanCalculator))]
        [TestCase("degx", typeof(DegXCalculator))]
        [TestCase("lnx", typeof(LnXCalculator))]
        [TestCase("negativex", typeof(MinusXCalculator))]
        [TestCase("onedivx", typeof(OnedivXCalculator))]
        [TestCase("radx", typeof(RadXCalculator))]
        [TestCase("sin", typeof(SinusCalculator))]
        [TestCase("tan", typeof(TanCalculator))]
        [TestCase("xpow2", typeof(Xpow2Calculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
        
    }
}