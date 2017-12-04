using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
                     
            try
            {
                int b = (10 / a);
                Console.WriteLine(b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Fail");
            }

            Console.ReadLine();
        }
    }
}
