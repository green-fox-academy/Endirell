using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int number01 = 22;
            int number02 = 13;

            Console.WriteLine(number01 + number02);
            Console.WriteLine(number01 - number02);
            Console.WriteLine(number01 * number02);
            Console.WriteLine(number01 / (double)number02);
            Console.WriteLine(number01 / number02);
            Console.WriteLine(number01 % number02);


            Console.ReadLine();
        }
    }
}