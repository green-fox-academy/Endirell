using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    
    class Dice
    {

        public static Random rnd = new Random();

        public int D6 { get; set; }  
        
        public void Roll()
        {            
            D6 = rnd.Next(1, 7);            
        }

        public void GetCurrent()
        {
            Console.WriteLine(D6);
        }

        public void Reroll()
        {
            Roll();
        }
    }
}
