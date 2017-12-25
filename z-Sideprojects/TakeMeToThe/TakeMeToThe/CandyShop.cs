using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        public int sugarstorage;

        public double income;

        public int candynumber;

        public int lollipopnumber;

        public List<Sweet> storage;

        public CandyShop(int sugar)
        {
            sugarstorage = sugar;

            income = 0;

            storage = new List<Sweet>();

            candynumber = 0;

            lollipopnumber = 0;
        }

        public void CreateSweets(string sweet)
        {
            if (sweet == "lollipop")
            {
                storage.Add(new Lollipop());
                sugarstorage = sugarstorage - Lollipop.sugarcontent;
                candynumber++;
            }

            if (sweet == "candy")
            {
                storage.Add(new Candy());
                sugarstorage = sugarstorage - Candy.sugarcontent;
                lollipopnumber++;
            }

        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: " + candynumber + " candies, " + lollipopnumber + " lollipops, Income: " + income +"$, Sugar: " + sugarstorage + "gr");
        }

        public void Raise(double percentage)
        {
            foreach (var s in storage)
            {
                Sweet.price = Sweet.price * 1 + (percentage / 100);
            }
        }

        public void Sell(string sweet, int amount)
        {
            foreach (var s in storage)
            {
                if (sweet == "lollipop")
                {
                    storage.Remove(s)
                    sugarstorage = sugarstorage - Lollipop.sugarcontent;
                    candynumber++;
                }

                if (sweet == "candy")
                {
                    storage.Add(new Candy());
                    sugarstorage = sugarstorage - Candy.sugarcontent;
                    lollipopnumber++;
                }
            }                       
        }
    }
}
