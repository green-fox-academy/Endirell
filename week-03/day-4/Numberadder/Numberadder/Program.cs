using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.

            int ladder = Convert.ToInt32(Console.ReadLine());

            int start = 0;

            Ladder(ladder, start);
            Console.ReadLine();

        }
        static int Ladder(int n, int one)
        {
            Console.WriteLine(one + 1);

            if (n > 1)
            {
                one = one + 1;
                n--;
                Ladder(n, one);
                
                return one;                
            }
            else
            {
                return 0;
            }


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(one);
                one++;
                
            }

        }
    }
}
