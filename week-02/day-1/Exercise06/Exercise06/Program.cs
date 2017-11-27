using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyhours = 6;
            int semester = 17;
            int averageweeklyhours = 52;



            Console.WriteLine("Hours spent coding in a semester: " + dailyhours*semester*5);
            Console.WriteLine("Percentage of the coding hours in the semester: " + (double)(dailyhours * 5) / averageweeklyhours * 100);

            Console.ReadLine();           
        }
    }
}