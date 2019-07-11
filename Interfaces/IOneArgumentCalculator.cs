namespace ObjectOrientedCalculator.Interfaces
{
    /// <summary>
    /// One argument calculator interface
    /// </summary>
    public interface IOneArgumentCalculator
    {
        /// <summary>
        /// Method that calculates the value
        /// </summary>
        /// <param name="firstValue">argument</param>
        /// <returns>result</returns>
        double Calculate(double firstValue);
    }
}
