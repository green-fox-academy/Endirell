using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            maxammo = 12;
            basedamage = 50;
            ammostore = 0;
            type = "F35";
        }
    }
}
