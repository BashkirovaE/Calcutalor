using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class LnXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (Math.Log(firstValue, Math.E));
        }
    }
}
