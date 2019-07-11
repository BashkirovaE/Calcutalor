using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
   
    public class LogXYCalculator : ITwoArgumentsCalculator
    {
        
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue < 0 || firstValue == 1 || firstValue < 0)
            {
                throw new Exception("Negative number");
            }
            return Math.Log(firstValue, secondValue);
        }
    }
}
