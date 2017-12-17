using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    class Garden
    {
        public string color;
        public string type;
        public double currentwater;
        public double absorbrate;
        public int treshold;

        public Garden(string color)
        {
            this.color = color;

        }
        
        public static void GardenStatus(List<Garden> list)
        {
            foreach (var l in list)
            {
                if (l.currentwater < l.treshold)
                {
                    Console.WriteLine("The " + l.color + " " + l.type + " needs water.");
                }

                else
                {
                    Console.WriteLine("The " + l.color + " " + l.type + " doesn't need water.");
                }
            }


        }

        public static void Watering(int water, List<Garden> list)
        {
            Console.WriteLine("\nWatering with " + water);

            int thirstyplants = 0;

            foreach (var l in list)
            {
                if (l.currentwater < l.treshold)
                {
                    thirstyplants++;
                }
            }

            double eachget = 0;

            try
            {
                eachget = water / thirstyplants;
            }
            catch (DivideByZeroException)
            {

            }

            foreach (var l in list)
            {
                if (l.currentwater < l.treshold)
                {
                    l.currentwater = l.currentwater + (eachget * l.absorbrate);
                }
            }

            GardenStatus(list);
        }


    }
}
