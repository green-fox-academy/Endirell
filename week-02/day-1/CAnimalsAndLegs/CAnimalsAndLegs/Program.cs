using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.WriteLine("How many chickens has the farmer?");
            string ch = Console.ReadLine();
            int chicken = Convert.ToInt32(ch);

            Console.WriteLine("How many pigs has the farmer?");
            string p = Console.ReadLine();
            int pig = Convert.ToInt32(p);

            int legs = ((chicken * 2) + (pig * 4));

            Console.WriteLine("\nAll the animals have " + legs + " legs");
            Console.ReadLine();

        }
    }
}