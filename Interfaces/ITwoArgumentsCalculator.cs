namespace ObjectOrientedCalculator.Interfaces
{
    /// <summary>
    /// Two arguments calculator interface
    /// </summary>
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method that calculates the value
        /// </summary>
        /// <param name="firstValue">argument one</param>
        /// <param name="secondValue">argument two</param>
        /// <returns>result</returns>
        double Calculate(double firstValue, double secondValue);
    }
}
