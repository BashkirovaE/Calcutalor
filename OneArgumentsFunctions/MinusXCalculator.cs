using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class MinusXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (-firstValue);
        }
    }
}
