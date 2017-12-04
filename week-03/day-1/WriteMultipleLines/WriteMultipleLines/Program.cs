using System;
using System.IO;
using System.Text;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Multi();
            Console.ReadLine();
        }

        static void Multi()
        {
            string path = @"C:\Users\user\greenfox\Endirell\week-03\day-1\my-file2.txt";
            string word = "something";
            int number = 6;

            try
            {
                StreamWriter writer = new StreamWriter(path);

                for (int i = 0; i <= number - 1; i++)
                {
                    writer.WriteLine(word);
                }
                writer.Close();
            }
            catch (Exception e)
            {
                Console.Clear();
            }
        }
        

        
    }
}
