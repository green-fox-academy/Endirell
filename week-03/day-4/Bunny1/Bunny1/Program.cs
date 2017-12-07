using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine("How manny bunnies do we have?");
            int bunnynumber = Convert.ToInt32(Console.ReadLine());

            int bunnyeras = 2;

            Ladder(bunnynumber, bunnyeras);

            Console.ReadLine();




        }
        static int Ladder(int number, int ears)
        {


            if (number > 0)
            {
                ears = ears + 2;                
                number--;
                Ladder(number, ears);
                
                if (number == 1)
                {
                    Console.WriteLine("\nWe have " + ears + " bunny ears");
                }
                return ears;

            }
            else
            {
                return 1;
            }



        }
    }
}
