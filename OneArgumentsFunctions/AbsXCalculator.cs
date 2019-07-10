using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class AbsXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (Math.Abs(firstValue));
        }
    }
}
