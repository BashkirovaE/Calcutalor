using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
