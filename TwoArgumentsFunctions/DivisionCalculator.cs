using ObjectOrientedCalculator.Interfaces;
using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the quotient of two numbers
    /// </summary>
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the quotient of two numbers
        /// </summary>
        /// <param name="firstValue">dividend</param>
        /// <param name="secondValue">divider</param>
        /// <returns>result</returns>
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
