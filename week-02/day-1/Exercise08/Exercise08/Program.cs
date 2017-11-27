using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {            
            int a = 123;
            int b = 526;

            a = 526;
            b = 123;

            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);

            Console.ReadLine();
        }
    }
}