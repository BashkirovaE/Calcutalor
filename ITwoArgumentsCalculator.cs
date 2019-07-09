using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCalculator
{
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double firstValue, double secondValue);
    }
}
