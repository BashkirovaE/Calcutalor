using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
