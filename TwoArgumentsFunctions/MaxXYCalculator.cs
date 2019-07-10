using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class MaxXYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
