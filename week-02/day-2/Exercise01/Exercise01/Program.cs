﻿using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter
            // - Print the result of `doubling(ak)`

            Doubling(123);

            Console.ReadLine();
        }

        static void Doubling(int ak)
        {
            Console.WriteLine(ak * 2);
        }
    }
}