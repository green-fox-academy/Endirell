using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garden_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new List<Garden>();

            garden.Add(new Flower("yellow"));
            garden.Add(new Flower("blue"));
            garden.Add(new Tree("purple"));
            garden.Add(new Tree("orange"));
            
            Garden.GardenStatus(garden);            

            Garden.Watering(40, garden);

            Garden.Watering(70, garden);

            Console.ReadLine();


        }
    }
}
