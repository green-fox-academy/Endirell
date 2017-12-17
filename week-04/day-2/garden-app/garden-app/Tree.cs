using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    class Tree : Garden
    {
        public Tree(string color) : base(color)
        {
            currentwater = 0;
            absorbrate = 0.4;
            treshold = 5;
            type = "tree";
        }

    }
}
