using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function arccos(x)
    /// </summary>
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value of function arccos(x)
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            if (!((firstValue <= 1)&&(firstValue >= -1)))
            {
                throw new Exception("Out of range");
            }
            return Math.Acos(firstValue);
        }
    }
}
