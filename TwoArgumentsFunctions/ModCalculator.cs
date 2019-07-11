using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the remainder of the division
    /// </summary>
    public class ModCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the remainder of the division
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
            return firstValue % secondValue;
        }
    }
}
