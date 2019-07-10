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
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
