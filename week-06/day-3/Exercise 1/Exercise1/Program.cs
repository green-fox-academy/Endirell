using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from number in numbers
                              where (number % 2 == 0)
                              orderby number descending
                              select number;

            foreach (var i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            var even = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n).Select(n => n);

            foreach (var e in even)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
