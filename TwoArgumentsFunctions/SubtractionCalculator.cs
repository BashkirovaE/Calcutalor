using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the difference of two numbers
    /// </summary>
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the value
        /// </summary>
        /// <param name="firstValue">argument one</param>
        /// <param name="secondValue">argument two</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
