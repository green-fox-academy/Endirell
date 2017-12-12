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
        List<Aircraft> aircraftstore = new List<Aircraft>();

         
        public Carrier()
        {
            hp = 15000;
            carrierammo = 10000;
        }

        public void Fill()
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
                Console.WriteLine("Tipe in F35 or F16!");
            }




        }

        public string GetStatus()
        {
            string status;
            return status = "Hp: " + hp + ", Aircraft count: " + aircraftstore.Count + ", Ammo storage: " + carrierammo + ", Total damage: " + carrierammo;
        }

    }
}
