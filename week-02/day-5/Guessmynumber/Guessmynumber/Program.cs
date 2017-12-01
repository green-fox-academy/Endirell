using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
            Start:

            

            if (life == 0)
            {
                goto Lose;
            }

            string guessstr = Console.ReadLine();
                    

            int d;
            if (!int.TryParse(guessstr, out d))
            {
                goto Wrong;
            }

            int guess = Convert.ToInt32(guessstr);

            if (guess <= (range1 - 1) || guess > range2)
            {
                goto Wrong;
            }

            if (guess == number)
            {
                goto Won;
            }

            if (guess < number)
            {
                Console.WriteLine("Too low, you have " + life + " life point");
                int actuallife = (life - 1);
                return actuallife;
                goto Start;
            }

            if (guess > number)
            {
                Console.WriteLine("Too high, you have " + actuallife + " life point");                
                goto Start;
            }

            else
            {
                goto Lose;
            }
            
            Wrong:
            Console.WriteLine("\nWrong input! Type in numbers from " +  range1s +  " to " + range2s + "\n");
            goto Start;

            
            Won:
            Console.WriteLine("You won!");
            Console.ReadLine();
            goto Finish;

            Lose:
            Console.WriteLine("You have failed the Company and your Country!\nYou are pathetic! Kill yourself!");
            Console.ReadLine();
            goto Finish;

            Finish:
            Console.WriteLine("End");



        }
    }
}