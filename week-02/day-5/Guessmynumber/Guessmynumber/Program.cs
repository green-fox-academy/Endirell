using System;

namespace Guessmynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will guess from:");
            string range1s = Console.ReadLine();
            int range1 = Convert.ToInt32(range1s);

            Console.WriteLine("to:");
            string range2s = Console.ReadLine();
            int range2 = Convert.ToInt32(range2s);

            Console.WriteLine("How many lives you have?");
            string lives = Console.ReadLine();
            int life = Convert.ToInt32(lives);

            Random random = new Random();
            int number = random.Next(range1, (range2 +1));

            Console.Clear();
            Console.WriteLine("Guess a number from " + range1s + " to " + range2s + ". You have " + life + " life point");

           
            for (int i = 0; i < life; i++)
            {     
                          
                string guessstr = Console.ReadLine();
                int guess = Convert.ToInt32(guessstr);

                if (guess == number)
                {
                    Console.WriteLine("You won!");

                }

                if (i < life - 1 && guess != number)
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Too high, you have " + (life - (i + 1)) + " life point");
                    }
                    else
                    {
                        Console.WriteLine("Too low, you have " + (life - (i + 1)) + " life point");
                    }
                }
                if (i == life - 1)
                {
                    Console.WriteLine("Game over");
                }
                




            }

            Console.ReadLine();
        }
    }
}