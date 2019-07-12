using System;
using ObjectOrientedCalculator.Interfaces;
using ObjectOrientedCalculator.OneArgumentsFunctions;

namespace ObjectOrientedCalculator.Factories
{
    /// <summary>
    /// Factory class, returns the required one argument calculator
    /// </summary>
    public static class OneArgumentFactory
    {
        /// <summary>
        /// returns the required one argument calculator by the name of the pressed button
        /// </summary>
        /// <param name="calculatorName">name of the pressed button</param>
        /// <returns>object calculator</returns>
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin":
                    return new SinusCalculator();
                case "cos":
                    return new CosinusCalculator();
                case "xpow2":
                    return new Xpow2Calculator();
                case "onedivx":
                    return new OnedivXCalculator();
                case "absx":
                    return new AbsXCalculator();
                case "radx":
                    return new RadXCalculator();
                case "degx":
                    return new DegXCalculator();
                case "lnx":
                    return new LnXCalculator();
                case "negativex":
                    return new MinusXCalculator();
                case "tan":
                    return new TanCalculator();
                case "ctan":
                    return new CtanCalculator();
                case "asin":
                    return new ArcsinCalculator();
                case "acos":
                    return new ArccosCalculator();
                case "atan":
                    return new ArctanCalculator();
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
