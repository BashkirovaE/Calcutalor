using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function abs(x)
    /// </summary>
    public class AbsXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            return (Math.Abs(firstValue));
        }
    }
}
