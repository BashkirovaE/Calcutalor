using ObjectOrientedCalculator.Interfaces;
using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Division on null");
            }
            
            return firstValue / secondValue;
        }
    }
}
