using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the arithmetic average
    /// </summary>
    public class AverageCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the arithmetic average
        /// </summary>
        /// <param name="firstValue">argument one</param>
        /// <param name="secondValue">argument two</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return ((firstValue + secondValue) / 2);
        }
    }
}
