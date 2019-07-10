using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
