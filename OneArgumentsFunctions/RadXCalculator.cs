using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class RadXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return (firstValue * Math.PI/180);
        }
    }
}
