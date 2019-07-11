using System;
using ObjectOrientedCalculator.Factories;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.Factories
{
    [TestFixture]
    public class TwoArgumentsFactoryTestCase
    {
        [TestCase("btn_div", typeof(DivisionCalculator))]
        [TestCase("btn_add", typeof(AdditionCalculator))]
        [TestCase("btn_mul", typeof(MultiplyCalculator))]
        [TestCase("btn_sub", typeof(SubtractionCalculator))]
        [TestCase("btn_xpowy", typeof(PowXYCalculator))]
        [TestCase("btn_logxy", typeof(LogXYCalculator))]
        [TestCase("btn_minxy", typeof(MinXYCalculator))]
        [TestCase("btn_mod", typeof(ModCalculator))]
        [TestCase("btn_divxony", typeof(DivCalculator))]
        [TestCase("btn_max", typeof(MaxXYCalculator))]
        [TestCase("btn_average", typeof(AverageCalculator))]
        [TestCase("btn_geometric", typeof(GeometricCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
        
    }
}