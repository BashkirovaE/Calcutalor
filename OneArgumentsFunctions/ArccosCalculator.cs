using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (!((firstValue <= 1)&&(firstValue >= -1)))
            {
                throw new Exception("Out of range");
            }
            return Math.Acos(firstValue);
        }
    }
}
