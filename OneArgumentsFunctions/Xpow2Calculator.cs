using ObjectOrientedCalculator.Interfaces;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class Xpow2Calculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (firstValue * firstValue);
        }
    }
}
