using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator exponentiating the number x to y 
    /// </summary>
    public class PowXYCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method exponentiating the number x to y 
        /// </summary>
        /// <param name="firstValue">base</param>
        /// <param name="secondValue">exponent</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
