﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class StrategyCash:Strategy
    {
        public float CalculatorStrategy(int _price, int _numberofdays)
        {
            return _price * _numberofdays;
        }
    }
}
