using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    class Flower : Garden
    {
        public Flower(string color) : base(color) 
        {
            currentwater = 0;
            absorbrate = 0.75;
            treshold = 5;
            type = "flower";
        }

    }
}
