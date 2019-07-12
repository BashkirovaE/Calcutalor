using System;
using ObjectOrientedCalculator.Interfaces;
using ObjectOrientedCalculator.TwoArgumentsFunctions;

namespace ObjectOrientedCalculator.Factories
{
    /// <summary>
    /// Factory class, returns the required two arguments calculator
    /// </summary>
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// returns the required two arguments calculator by the name of the pressed button
        /// </summary>
        /// <param name="calculatorName">name of the pressed button</param>
        /// <returns>object calculator</returns>
        static public ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "div":
                    return new DivisionCalculator();
                case "add":
                    return new AdditionCalculator();
                case "mul":
                    return new MultiplyCalculator();
                case "sub":
                    return new SubtractionCalculator();
                case "xpowy":
                    return new PowXYCalculator();
                case "logxy":
                    return new LogXYCalculator();
                case "minxy":
                    return new MinXYCalculator();
                case "mod":
                    return new ModCalculator();
                case "divxony":
                    return new DivCalculator();
                case "max":
                    return new MaxXYCalculator();
                case "average":
                    return new AverageCalculator();
                case "geometric":
                    return new GeometricCalculator();
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
