using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.WriteLine("Gimme a nummer fool!!!");
            string nummer = Console.ReadLine();
            int nummember = Convert.ToInt32(nummer);

            Console.WriteLine(sum(nummember));

            Console.ReadLine();
        }
        static int sum(int number)
        {
            return (number * (number + 1)) / 2;
        }     
    }
}