using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (((firstValue % (Math.PI/2))==0 && (firstValue % (Math.PI/2*3) == 0)))
            {
                throw new Exception("Out of range");
            }
            return Math.Tan(firstValue);
        }
    }
}
