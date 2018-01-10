using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }

        public BankAccount(string name, int balance, string animaltype)
        {
            Name = name;
            Balance = balance.ToString(".00 Zebra");
            AnimalType = animaltype;
        }
    }
}
