using System;
using System.IO;
using System.Text;


namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string open = @"C:\Users\user\greenfox\Endirell\week-03\day-1\duplicated-chars.txt";
            string text = File.ReadAllText(open);

            var chars = text.ToCharArray();

            for (int ctr = 0; ctr < chars.Length - 1; ctr++)
                Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);

            Console.ReadLine();

        }
    }
}
