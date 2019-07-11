using System;
using ObjectOrientedCalculator.Factories;
using ObjectOrientedCalculator.OneArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.Factories
{
    [TestFixture]
    public class OneArgumentFactoryTestCase
    {
        [TestCase("btn_absx", typeof(AbsXCalculator))]
        [TestCase("btn_acos", typeof(ArccosCalculator))]
        [TestCase("btn_asin", typeof(ArcsinCalculator))]
        [TestCase("btn_atan", typeof(ArctanCalculator))]
        [TestCase("btn_cos", typeof(CosinusCalculator))]
        [TestCase("btn_ctan", typeof(CtanCalculator))]
        [TestCase("btn_degx", typeof(DegXCalculator))]
        [TestCase("btn_lnx", typeof(LnXCalculator))]
        [TestCase("btn_negativex", typeof(MinusXCalculator))]
        [TestCase("btn_1divx", typeof(OnedivXCalculator))]
        [TestCase("btn_radx", typeof(RadXCalculator))]
        [TestCase("btn_sin", typeof(SinusCalculator))]
        [TestCase("btn_tan", typeof(TanCalculator))]
        [TestCase("btn_xpow2", typeof(Xpow2Calculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
        
    }
}