using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator
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
                default:
                    throw new Exception("Неизвестный тип калькулятора");
            }
        }
    }
}
