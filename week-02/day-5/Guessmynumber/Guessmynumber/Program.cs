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
            string range1s = Console.ReadLine();
            int range1 = Convert.ToInt32(range1s);

            string range2s = Console.ReadLine();
            int range2 = Convert.ToInt32(range2s);


            Random random = new Random();
            int number = random.Next(range1, (range2 +1));

            Console.WriteLine(number);

            Start:

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

            goto Right;

            Wrong:
            Console.WriteLine("\nWrong input! Type in numbers from 1-100\n");
            goto Start;

            Right:

            Console.WriteLine(guess);
            Console.ReadLine();



        }
    }
}