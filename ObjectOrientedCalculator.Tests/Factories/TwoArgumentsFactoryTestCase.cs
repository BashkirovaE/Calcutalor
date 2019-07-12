using System;
using ObjectOrientedCalculator.Factories;
using ObjectOrientedCalculator.TwoArgumentsFunctions;
using NUnit.Framework;

namespace ObjectOrientedCalculator.Tests.Factories
{
    [TestFixture]
    public class TwoArgumentsFactoryTestCase
    {
        [TestCase("div", typeof(DivisionCalculator))]
        [TestCase("add", typeof(AdditionCalculator))]
        [TestCase("mul", typeof(MultiplyCalculator))]
        [TestCase("sub", typeof(SubtractionCalculator))]
        [TestCase("xpowy", typeof(PowXYCalculator))]
        [TestCase("logxy", typeof(LogXYCalculator))]
        [TestCase("minxy", typeof(MinXYCalculator))]
        [TestCase("mod", typeof(ModCalculator))]
        [TestCase("divxony", typeof(DivCalculator))]
        [TestCase("max", typeof(MaxXYCalculator))]
        [TestCase("average", typeof(AverageCalculator))]
        [TestCase("geometric", typeof(GeometricCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
        
    }
}