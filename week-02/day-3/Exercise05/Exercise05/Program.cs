using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            
            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            char[] result = Reverser(reversed);
            
            Console.WriteLine(result);

            Console.WriteLine("\nWhat else do you want to reverse?");
            string ask = Console.ReadLine();
            
            Console.WriteLine(Reverser(ask));

            Console.ReadLine();
        }

        public static char[] Reverser(string text)
        {
            var normal = text.ToCharArray();
            Array.Reverse(normal);
            return normal;
        }
    }
}