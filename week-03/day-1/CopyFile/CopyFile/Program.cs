using System;
using System.IO;
using System.Text;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\user\greenfox\Endirell\week-03\day-1\my-file3.txt";
            string copied = @"C:\Users\user\greenfox\Endirell\week-03\day-1\my-file4.txt";

            if (Copier(source, copied))
            {
                Console.WriteLine("Successful copy!");
            }

            else
            {
                Console.WriteLine("Unable to read file");
            }
              
            Console.ReadLine();

        }

        static bool Copier(string pathoriginal, string pathnew)
        {
            bool success = false;
           
            try
            {
                StreamWriter writer = new StreamWriter(pathnew);

                string original = File.ReadAllText(pathoriginal);

                writer.Write(original);

                writer.Close();

                success = true;

                return success;

            }

            catch (Exception e)
            {
                
                success = false;

                return success;
            }
            
        }

    }
}
