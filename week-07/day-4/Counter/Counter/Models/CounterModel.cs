﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Models
{
    public class CounterModel
    {
        public int Number { get; set; }

        public CounterModel()
        {
            Number = 0;
        }
    }
}
