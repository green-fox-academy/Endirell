using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class F16 : Aircraft
    {      
        public F16()
        {
            maxammo = 8;
            basedamage = 30;
            ammostore = 0;
            type = "F16";
        }    
        
    }
}
