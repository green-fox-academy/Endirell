using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("n = " + number);

            Counter(number);
            Console.ReadLine();


        }

        public static int Counter(int n)
        {
            n = n - 1;
            Console.WriteLine(n + 1);
            if (n > 0)
            {

                Counter(n);
                
                return n;
                
            }
            else
            {
                return 0;
            }
                                       
            
                

           
        }

    }
}
