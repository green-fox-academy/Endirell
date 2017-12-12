using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            F35 TopGun = new F35();

            TopGun.Refill(11);

            Console.WriteLine(TopGun.GetStatus());

            Console.WriteLine(TopGun.Fight());

            Carrier Nimitz = new Carrier();

            Console.WriteLine(Nimitz.GetStatus());

            Console.ReadLine();


        }
    }
}
