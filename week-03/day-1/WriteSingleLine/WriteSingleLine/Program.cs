using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\user\greenfox\Endirell\week-03\day-1\my-file2.txt";
            
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    writer.WriteLine("Mark Klein");
                }
                catch
                {
                    Console.WriteLine("Unable to write file");
                    
                }
            }
            Console.ReadLine();
        }
    }
}
