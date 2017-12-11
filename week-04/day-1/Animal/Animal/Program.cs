using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragon = new Animal();

            dragon.Eat();

            dragon.Eat();

            dragon.Eat();

            dragon.Eat();

            dragon.Play();

            dragon.Play();

            dragon.Play();

            dragon.Play();

            dragon.Play();

            Console.WriteLine(" " + dragon.hunger + " " + dragon.thirst);

            Console.ReadLine();

        }
    }
}
