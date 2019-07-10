using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class ArctanCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Atan(firstValue);
        }
    }
}
