using System;
using ObjectOrientedCalculator.Interfaces;
using ObjectOrientedCalculator.TwoArgumentsFunctions;

namespace ObjectOrientedCalculator.Factories
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
                case "btn_xpowy":
                    return new PowXYCalculator();
                case "btn_logxy":
                    return new LogXYCalculator();
                case "btn_minxy":
                    return new MinXYCalculator();
                case "btn_mod":
                    return new ModCalculator();
                case "btn_divxony":
                    return new DivCalculator();
                case "btn_max":
                    return new MaxXYCalculator();
                case "btn_average":
                    return new AverageCalculator();
                case "btn_geometric":
                    return new GeometricCalculator();
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
