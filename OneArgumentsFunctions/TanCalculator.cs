using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function tan(x)
    /// </summary>
    public class TanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            if(firstValue == (Math.PI / 2) || firstValue == (3 * Math.PI / 2))
            {
                throw new Exception("Out of range");
            }
            return Math.Tan(firstValue);
        }
    }
}
