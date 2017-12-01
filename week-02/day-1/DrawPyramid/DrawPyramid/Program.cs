using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("How many stories has our pyramid?");
            string stories = Console.ReadLine();
            int number = Convert.ToInt32(stories);
            string brick = "*";

            for (int i = 0; i < number; i++)
            {
                for (int i2 =0; i2 < (number - i); i2++)
                {
                    Console.Write(" ");
                }

                for (int i3 = 0; i3 < ((number + i) - 1); i3++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }

            Console.ReadLine();

        }
    }
}