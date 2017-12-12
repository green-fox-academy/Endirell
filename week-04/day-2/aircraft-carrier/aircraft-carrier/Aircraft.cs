using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class Aircraft
    {
        public int maxammo;
        public int basedamage;
        public int ammostore;
        public int damage;
        public int refillammo;
        public int remainammo;
        public string type;


        public int Fight()
        {
            damage = ammostore * basedamage;
            ammostore = 0;
            return damage;
        }

        public int Refill(int refillammo)
        {
            this.refillammo = refillammo;
            
            if (refillammo < (maxammo - ammostore))
            {
                ammostore = (ammostore + refillammo);

                return 0;                
            }

            else
            {
                remainammo = refillammo - (maxammo - ammostore);

                ammostore = maxammo;

                return remainammo;
            }

            
        }

        public new string GetType()
        {
            return type;
        }

        public string GetStatus()
        {
            string status;
            return status = "Type: " + type + ", Ammo: " + ammostore + ", Base Damage: " + basedamage + ", All Damage: " + (ammostore * basedamage);
        }


    }  

    
}
