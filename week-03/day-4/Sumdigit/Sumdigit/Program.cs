using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int original = Convert.ToInt32(Console.ReadLine());

            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            Breaker(original);

            Console.ReadLine();
            

        }
        static int Breaker(int n)
        {
           
        }
    }
}
