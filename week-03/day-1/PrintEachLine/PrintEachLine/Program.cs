using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string open = @"C:\Users\user\greenfox\Endirell\week-03\day-1\my-file.txt";
            try
            {                
                string[] lines = File.ReadAllLines(open);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }

            Console.ReadLine();
        }
    }
}
