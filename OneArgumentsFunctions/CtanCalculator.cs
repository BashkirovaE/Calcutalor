using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function ctan(x)
    /// </summary>
    public class CtanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value of function ctan(x)
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            if (Math.Tan(firstValue) == 0)
            {
                throw new Exception("Out of range");
            }
            return (1 / Math.Tan(firstValue));
        }
    }
}
