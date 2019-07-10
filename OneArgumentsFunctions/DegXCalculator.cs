using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class DegXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (firstValue * 180 / Math.PI);
        }
    }
}
