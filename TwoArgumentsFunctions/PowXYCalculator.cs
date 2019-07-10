using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class PowXYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
