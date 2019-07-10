using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}
