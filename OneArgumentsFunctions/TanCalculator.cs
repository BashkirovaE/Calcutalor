using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            
            if(firstValue == (Math.PI / 2) || firstValue == (3 * Math.PI / 2))
            {
                throw new Exception("Out of range");
            }
            return Math.Tan(firstValue);
        }
    }
}
