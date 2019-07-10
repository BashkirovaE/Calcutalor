using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class AbsXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (Math.Abs(firstValue));
        }
    }
}
