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
                case "btn_sin":
                    return new SinusCalculator();
                case "btn_cos":
                    return new CosinusCalculator();
                case "btn_xpow2":
                    return new Xpow2Calculator();
                case "btn_1divx":
                    return new OnedivXCalculator();
                case "btn_absx":
                    return new AbsXCalculator();
                case "btn_radx":
                    return new RadXCalculator();
                case "btn_degx":
                    return new DegXCalculator();
                case "btn_lnx":
                    return new LnXCalculator();
                case "btn_negativex":
                    return new MinusXCalculator();
                case "btn_tan":
                    return new TanCalculator();
                case "btn_ctan":
                    return new CtanCalculator();
                case "btn_asin":
                    return new ArcsinCalculator();
                case "btn_acos":
                    return new ArccosCalculator();
                case "btn_atan":
                    return new ArctanCalculator();
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
