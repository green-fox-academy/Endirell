using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dice;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Dice> dicepool = new List<Dice>();

            for (int i = 0; i < 6; i++)
            {
                dicepool.Add(new Dice());                
            }
           
            for (int j = 0; j < dicepool.Count; j++)
            {
                dicepool[j].Roll();
            }

            for (int k = 0; k < dicepool.Count; k++)
            {
                dicepool[k].GetCurrent();
            }

            Console.WriteLine("\n\n");

            for (int l = 0; l < dicepool.Count; l++)
            {
                if (dicepool[l].D6 != 6)
                { 
                    Console.WriteLine("Reroll number " + (l + 1) + " dice");
                }

                while (dicepool[l].D6 != 6)
                {
                dicepool[l].Reroll();
                dicepool[l].GetCurrent();
                }

                Console.WriteLine("\n");
            }

            Console.ReadLine();



        }
    }
}
