using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class MinXYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Min(firstValue, secondValue);
        }
    }
}
