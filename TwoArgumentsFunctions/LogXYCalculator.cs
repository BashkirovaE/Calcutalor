using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the logarithm of y over the base x
    /// </summary>
    public class LogXYCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the value
        /// </summary>
        /// <param name="firstValue">base of logarithm</param>
        /// <param name="secondValue">argument</param>
        /// <returns>result</returns>
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
