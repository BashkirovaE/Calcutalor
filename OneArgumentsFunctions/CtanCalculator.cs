using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (1 / Math.Tan(firstValue));
        }
    }
}
