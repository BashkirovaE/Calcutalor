namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
