using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (!((firstValue <= 1) && (firstValue >= -1)))
            {
                throw new Exception("Out of range");
            }
            return Math.Asin(firstValue);
        }
    }
}
