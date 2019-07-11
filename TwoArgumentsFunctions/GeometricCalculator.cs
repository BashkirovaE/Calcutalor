using System;
using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the geometric mean
    /// </summary>
    public class GeometricCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the geometric mean
        /// </summary>
        /// <param name="firstValue">argument one</param>
        /// <param name="secondValue">argument two</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue * secondValue < 0)
            {
                throw new Exception("Negative root");
            }
            return Math.Sqrt(firstValue * secondValue);
        }
    }
}
