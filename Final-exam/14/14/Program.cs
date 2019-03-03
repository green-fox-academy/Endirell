using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function takes a string and a letter and splits the string to an 
            //list of strings by the letter like: "a,bcd,e,fg" and ',' becomes["a", "bcd", "e", "fg"]

            string originalString = "a,bcd,e,fg,hij,klmno,p,qrs,tuvwx,yz";

            char splitterLetter = ',';

            foreach (var s in Splitter(originalString, splitterLetter))
            {
                Console.WriteLine(s);                
            }
            Console.ReadKey();

            List<string> Splitter(string original, char letter)
            {
                List<string> result = new List<string>();

                char[] letters = original.ToCharArray();

                List<int> indexes = new List<int>();

                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i].Equals(letter))
                    {
                        indexes.Add(i);
                    }
                }

                int startIndex = 0;

                int lenght = indexes[0];

                result.Add(original.Substring(startIndex, lenght));

                for (int j = 1; j < indexes.Count; j++)
                {
                    startIndex = lenght + 1;

                    lenght = indexes[j] - indexes[j - 1];

                    int difference = lenght + 1;

                    result.Add(original.Substring(indexes[j-1] + 1, lenght - 1));
                }

                int lastIndex = indexes[indexes.Count - 1];

                result.Add(original.Substring(lastIndex + 1));

                return result;
            }
        }
    }
}
