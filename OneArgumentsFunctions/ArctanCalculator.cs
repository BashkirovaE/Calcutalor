using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class ArctanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
