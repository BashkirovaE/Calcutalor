using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "btn_sin":
                    return new SinusCalculator();
                case "btn_cos":
                    return new CosinusCalculator();

                case "x_pow_2":
                    return new Xpow2Calculator();
                case "x_inv":
                    return new OnedivXCalculator();
                case "abs_x":
                    return new AbsXCalculator();
                case "rad_x":
                    return new RadXCalculator();
                case "deg_x":
                    return new DegXCalculator();
                case "ln_x":
                    return new LnXCalculator();
                case "minus_x":
                    return new MinusXCalculator();
                case "btn_tan":
                    return new TanCalculator();
                case "btn_ctan":
                    return new CtanCalculator();
                case "btn_asin":
                    return new ArcsinCalculator();

                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
