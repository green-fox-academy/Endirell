using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class Carrier
    {
        public int hp;
        public int aircraftnumber;
        public int carrierammo;
        public List<Aircraft>aircraftstore;

         
        public Carrier()
        {
            hp = 15000;
            carrierammo = 10000;
            List<Aircraft>aircraftstore = new List<Aircraft>();
        }

        public void Addaircraft()
        {
            string input = Console.ReadLine();
            
            if (input == "F35" || input == "f35")
            {
                aircraftstore.Add(new F35());
            }

            else if  (input == "F16" || input == "f16")
            {
                aircraftstore.Add(new F16());
            }

            else
            {
                Console.WriteLine("Type in F35 or F16!");
                Addaircraft();
            }




        }

        public void Fill()
        {
            

        }

        public string GetStatus()
        {
            int total = 0;
            string aircraftst;

            for (int i = 0; i < aircraftstore.Count; i++)
            {
                total += aircraftstore[i].basedamage * aircraftstore[i].ammostore;
            }

            for (int j = 0; j < aircraftstore.Count; j++)
            {
                aircraftst = Aircraft.GetStatus();
            }

            string status = aircraftstore.Count.ToString() + " " + total.ToString();




            return status;
        }
        //"Hp: " + hp + ", Aircraft count: " + aircraftstore.Count + ", Ammo storage: " + carrierammo + ", Total damage: " + carrierammo;
    }
}
