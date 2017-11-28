using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1: ");
            string ask1 = Console.ReadLine();

            int number1 = Convert.ToInt32(ask1);

            Console.WriteLine("Number 2: ");
            string ask2 = Console.ReadLine();

            int number2 = Convert.ToInt32(ask2);

            if (number1 >= number2)
            {
                Console.WriteLine("The second number should be bigger!");
            }

            else
            {
                int number3 = (number2 - number1);

                for (int i = number1; i < number2; i++)

                {          
                    Console.WriteLine(number1++);
                }
            }

            Console.ReadLine();
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}