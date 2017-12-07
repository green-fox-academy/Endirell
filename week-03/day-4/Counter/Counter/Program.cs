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
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("n = " + number);

            Counter(number);
            Console.ReadLine();


        }

        public static void Counter(int n)
        {
            int m = n;

            for (int i = 0; i < m; i++)
                if (n > 0)
                {
                    Console.WriteLine(n);
                    n = n -1;
                }
                
            
                

           
        }

    }
}
