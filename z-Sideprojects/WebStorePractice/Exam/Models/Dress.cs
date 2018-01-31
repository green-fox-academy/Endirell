using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Dress
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public double UnitPrice { get; set; }
    }
}
