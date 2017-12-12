using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var John = new Pirate();

            John.name = "John";

            var Bill = new Pirate();

            Bill.name = "Bill";

            John.Brawl(John, Bill);

            John.DrinkSomeRum();

            Bill.DrinkSomeRum();

            Console.ReadLine();

        }
    }
}
