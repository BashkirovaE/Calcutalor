﻿using System;

namespace ObjectOrientedCalculator.OneArgumentsFunctions
{
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Asin(firstValue);
        }
    }
}
