using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animals
    {
        public int hunger = 50;
        public int thirst = 50;

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
        }



    }
}
