using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function negative(x)
    /// </summary>
    public class MinusXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that calculates the negative(x) value
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            return -firstValue;
        }
    }
}
