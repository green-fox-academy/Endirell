using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> people = new List<int>();
            people.Add(6);
            people.Add(7);
            people.Add(7);
            people.Add(7);

            Console.WriteLine(people.Sum());

            Console.ReadLine();
            




        }
    }
}
