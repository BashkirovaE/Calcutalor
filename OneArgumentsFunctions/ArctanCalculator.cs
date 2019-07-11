using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function arctan(x)
    /// </summary>
    public class ArctanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value of function arctan(x)
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
