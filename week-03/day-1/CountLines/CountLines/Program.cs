using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static int Opentext()
        {
            string open = @"C:\Users\user\greenfox\Endirell\week-03\day-1\my-file.txt";

            try
            {
                string[] lines = File.ReadAllLines(open);
                int linecount = (lines.Length);
                return linecount;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Opentext());
            Console.ReadLine();
        }
    }
}