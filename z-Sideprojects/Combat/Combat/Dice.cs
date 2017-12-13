using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat
{
    class Dice
    {
        public static Random rnd = new Random();

        public int aD10 { get; set; }
        public int bD10 { get; set; }
        public int D_2_10 { get; set; }

        public void Roll()
        {
            aD10 = rnd.Next(1, 11);
            bD10 = rnd.Next(1, 11);
            D_2_10 = aD10 + bD10;
        }

        public void GetCurrent()
        {
            Console.WriteLine(aD10 + " " + bD10 + " " + D_2_10);
        }

    }
}
