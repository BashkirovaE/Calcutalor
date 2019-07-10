﻿using System;

namespace ObjectOrientedCalculator.TwoArgumentsFunctions
{
    public class LogXYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}
