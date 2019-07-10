using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public static class TwoArgumentsFactory
    {
        static public ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "btn_div":
                    return new DivisionCalculator();
                case "btn_add":
                    return new AdditionCalculator();
                case "btn_mul":
                    return new MultiplyCalculator();
                case "btn_sub":
                    return new SubtractionCalculator();
                case "x_pow_y":
                    return new PowXYCalculator();
                case "log_x_y":
                    return new LogXYCalculator();
                case "min_x_y":
                    return new MinXYCalculator();
                case "btn_mod":
                    return new ModCalculator();
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
