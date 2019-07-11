using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function 1/(x)
    /// </summary>
    public class OnedivXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that devides 1 on x
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Out of range");
            }
            return (1 / firstValue);
        }
    }
}
