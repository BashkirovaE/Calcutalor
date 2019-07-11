using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class GeometricCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue * secondValue < 0)
            {
                throw new Exception("Negative root");
            }
            return Math.Sqrt(firstValue * secondValue);
        }
    }
}
