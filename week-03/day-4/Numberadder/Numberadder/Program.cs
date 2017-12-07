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
            int ladder = Convert.ToInt32(Console.ReadLine());
            Ladder(ladder);
            Console.ReadLine();

        }
        static void Ladder(int n)
        {
            int one = 1;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(one);
                one++;
                
            }

        }
    }
}
