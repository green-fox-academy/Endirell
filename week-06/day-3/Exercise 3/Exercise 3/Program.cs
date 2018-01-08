using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positivesquarred = n.Where(ps => ps > 0).OrderBy(ps => ps).Select(ps => ps * ps);

            foreach (var number in positivesquarred)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(" ");

            var possq = from p in n
                        where (p > 0)
                        orderby p
                        select p * p;

            foreach (var item in possq)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
