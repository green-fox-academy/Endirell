using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys

            Console.WriteLine("Number of girls coming to the party:");
            string askgirls = Console.ReadLine();

            int girls = Convert.ToInt32(askgirls);

            Console.WriteLine("Number of boys coming to the party:");
            string askboys = Console.ReadLine();

            int boys = Convert.ToInt32(askboys);

            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            if (girls == 0)
            {
                Console.WriteLine("Sausage party!");
            }

            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20

            else if (girls + boys > 20 && girls == boys)
            {
                Console.WriteLine("The party is exellent!");
            }

            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1

            else if (girls + boys > 20 && girls != boys)
            {
                Console.WriteLine("Quite cool party!");

            }

            // It should print: Average party...
            // If there are less people coming than 20

            else if (girls + boys < 20)
            {
                Console.WriteLine("Average party!");
            }


            
            
                Console.ReadLine();

        }
    }
}