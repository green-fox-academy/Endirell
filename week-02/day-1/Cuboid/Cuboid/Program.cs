using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            Console.WriteLine("Cuboid side a length:");
            string astr = Console.ReadLine();
            double a = Convert.ToDouble(astr);

            Console.WriteLine("Cuboid side b length:");
            string bstr = Console.ReadLine();
            double b = Convert.ToDouble(bstr);

            Console.WriteLine("Cuboid side c length:");
            string cstr = Console.ReadLine();
            double c = Convert.ToDouble(cstr);

            double area = (((a * b) * 2) + ((a * c) * 2) + ((c * b) * 2));
            double volume = (a * b * c);

            Console.WriteLine("\nSurface Area: " + area + "\nVolume: " + volume);
            Console.ReadLine();


        }
    }
}