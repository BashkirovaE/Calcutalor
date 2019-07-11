using ObjectOrientedCalculator.Interfaces;
using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the integer part of a division
    /// </summary>
    public class DivCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the integer part of a division
        /// </summary>
        /// <param name="firstValue">dividend</param>
        /// <param name="secondValue">divider</param>
        /// <returns>integer result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Division on null");
            }
            return (int)(firstValue / secondValue);
        }
    }
}
