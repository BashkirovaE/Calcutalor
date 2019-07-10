namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class DivCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (int)(firstValue / secondValue);
        }
    }
}
