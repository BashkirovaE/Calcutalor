using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function that converts a value from degrees to radians
    /// </summary>
    public class RadXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that converts a value from degrees to radians
        /// </summary>
        /// <param name="firstValue">argument (value in degrees)</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            return (firstValue * Math.PI / 180);
        }
    }
}
