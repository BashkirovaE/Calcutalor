using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class RadXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (firstValue * Math.PI / 180);
        }
    }
}
