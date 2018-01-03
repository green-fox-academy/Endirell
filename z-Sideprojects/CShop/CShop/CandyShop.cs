using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop
{
    class CandyShop
    {
        int sugarstorage;
        List<Sweets> candystore;


        public CandyShop(int sugaradded)
        {
            this.sugarstorage = sugaradded;
            this.candystore = new List<Sweets>();
        }

        public void CreateSweets(string type)
        {
            if (type == "lollipop")
            {
                candystore.Add(new Lollipop());
                sugarstorage -= Lollipop.sugarcontent
            }

            if (type == "candy")
            {
                candystore.Add(new Candy());
            }
        }

    }
}
