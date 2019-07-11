using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the product of multiply of two numbers
    /// </summary>
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the product of multiply of two numbers
        /// </summary>
        /// <param name="firstValue">argument one</param>
        /// <param name="secondValue">argument two</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
