using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your mass in Kilogramms:");

            double kg = 0;

            kg = Examiner(kg);

            if (kg > 0)
            {
                Console.WriteLine("Your mass in Kilogramms is: " + kg);
            }
            else if (kg < 0)
            {
                Console.WriteLine("Please type in a positive number!");
            }
            
            Console.ReadLine();
            
        }
        static double Examiner(double input)
        {

            try
            {
                input = Convert.ToDouble(Console.ReadLine());
                if (input == 0)
                {
                    Console.WriteLine("Please type in a number that is bigger than zero!");
                }
                return input;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nWrong input! Type in numbers\n");
                return 0;
            }

        }
        
    }
}
