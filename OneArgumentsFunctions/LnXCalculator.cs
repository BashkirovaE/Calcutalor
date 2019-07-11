using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function ln(x)
    /// </summary>
    public class LnXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value of function ln(x)
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Out of range");
            }
            return (Math.Log(firstValue, Math.E));
        }
    }
}
