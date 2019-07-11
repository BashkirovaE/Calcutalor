using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (Math.Tan(firstValue) == 0)
            {
                throw new Exception("Out of range");
            }
            return (1 / Math.Tan(firstValue));
        }
    }
}
