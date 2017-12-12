using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirate
    {
        public static Random rnd = new Random();


        public int drunkness = 0;
        public bool alive = true;
        public bool awake = true;
        public string name;

        public void DrinkSomeRum()
        {
            drunkness++;
        }

        public void HowsItGoingMate()
        {
            if (alive == false)
            {
                Console.WriteLine("He's dead");
            }
            
            else if (drunkness < 5)
            {
                Console.WriteLine("Pour me anudder!");
                DrinkSomeRum();
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                awake = false;
            }
        }

        public void Die()
        {
            alive = false;
        }

        public void Brawl(Pirate pirate1, Pirate pirate2)
        {
            if (pirate1.alive == false)
            {
                Console.WriteLine("He's dead");
            }
            if (pirate2.alive == false)
            {
                Console.WriteLine(name + " is dead");
            }
            else if (pirate1.alive == true && pirate2.alive == true)
            {
                int fight = rnd.Next(1, 4);
                if (fight == 1)
                {
                    pirate1.alive = false;
                }

                if (fight == 2)
                {
                    pirate2.alive = false;
                }

                if (fight == 3)
                {
                    pirate1.awake = false;
                    pirate1.awake = false;
                }

            }

        }
    }
}
