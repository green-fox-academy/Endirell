using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me two words, I tell you if they are anagrams or not.");

            Console.WriteLine("\nWord 1:");
            string word1 = Console.ReadLine();

            var anagram1 = word1.ToCharArray();

            Console.WriteLine("\nWord 2:");
            string word2 = Console.ReadLine();

            var anagram2 = word2.ToCharArray();

            var result = anagram1.Except(anagram2);

            if (result.Count() == 0)
            {
                Console.WriteLine("\nThese two words ARE anagrams");                
            }
            else
            {
                Console.WriteLine("\nThese two words are NOT anagrams");
            }

            Console.ReadLine();
        }
    }
    
}
