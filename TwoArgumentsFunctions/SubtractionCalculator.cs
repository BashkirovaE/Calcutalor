using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the difference of two numbers
    /// </summary>
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// The method that calculates the the difference of two numbers
        /// </summary>
        /// <param name="firstValue">minuend</param>
        /// <param name="secondValue">subtrahend</param>
        /// <returns>difference</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
