using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyShop shop = new CandyShop(300);

            Console.WriteLine(shop.sugarstorage);

            shop.CreateSweets("lollipop");
            shop.CreateSweets("candy");

            shop.PrintInfo();

            Console.WriteLine(shop.sugarstorage);
            
            Console.ReadLine();

        }
    }
}
