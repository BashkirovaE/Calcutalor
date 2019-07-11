using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function that converts a value from radians to degrees
    /// </summary>
    public class DegXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the value
        /// </summary>
        /// <param name="firstValue">argument (the value in radians)</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            return (firstValue * 180 / Math.PI);
        }
    }
}
