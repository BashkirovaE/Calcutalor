using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    /// <summary>
    /// Calculator that calculates the value of function that squares the number
    /// </summary>
    public class Xpow2Calculator : IOneArgumentCalculator
    {
        /// <summary>
        /// The method that squares the number
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        public double Calculate(double firstValue)
        {
            return (firstValue * firstValue);
        }
    }
}
