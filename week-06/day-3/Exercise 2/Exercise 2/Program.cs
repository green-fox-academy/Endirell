using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddNumbers = from number in numbers
                              where (number % 2 != 0)
                              orderby number descending
                              select number;

            double average = oddNumbers.Average(); 
            
            Console.WriteLine(average);

            Console.ReadKey();

        }
    }
}
