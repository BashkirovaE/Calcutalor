using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "btn_sin":
                    return new SinusCalculator();
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
