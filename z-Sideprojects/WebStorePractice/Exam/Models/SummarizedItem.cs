using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class SummarizedItem
    {
        public string UnitName { get; set; }
        public string UnitSize { get; set; }
        public string UnitCategory { get; set; }
        public string UnitManufacturer { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public double Subtotal { get; set; }

        public SummarizedItem(int amount, string unitname, string unitsize)
        {
            Amount = amount;
            UnitName = unitname;
            UnitSize = unitsize;
            UnitCategory = "";
            UnitManufacturer = "";
            UnitPrice = 0;
            Subtotal = 0;
        }

    }
}
