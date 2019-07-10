namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class MultiplyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
