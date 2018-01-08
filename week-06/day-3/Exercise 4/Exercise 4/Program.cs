using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            var squaredmorethantwenty = from number in numbers
                    where number * number > 20
                    select number;

            foreach (var s in squaredmorethantwenty)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            var sqmttw = numbers.Where(n => n * n > 20);

            foreach (var i in sqmttw)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
