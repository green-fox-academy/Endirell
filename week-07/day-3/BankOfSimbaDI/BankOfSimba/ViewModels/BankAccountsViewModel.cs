using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;

namespace BankOfSimba.ViewModels
{
    public class BankAccountsViewModel
    {
        public List<BankAccount> Animallist { get; set; }

        public BankAccountsViewModel()
        {
            Animallist = new List<BankAccount>();
            AdToList();
        }
        
        public void AdToList()
        {
            var accountofsimba = new BankAccount
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion",
                IsKing = true,
                IsGood = true
            };

            var accountofscar = new BankAccount
            {
                Name = "Scar",
                Balance = 3000,
                AnimalType = "Lion",
                IsKing = false,
                IsGood = false
            };

            var accountofmufasa = new BankAccount
            {
                Name = "Mufasa",
                Balance = 100000,
                AnimalType = "Lion",
                IsKing = true,
                IsGood = true
            };

            var accountofnala = new BankAccount
            {
                Name = "Nala",
                Balance = 500,
                AnimalType = "Lion",
                IsKing = false,
                IsGood = true
            };

            Animallist.Add(accountofsimba);
            Animallist.Add(accountofscar);
            Animallist.Add(accountofmufasa);
            Animallist.Add(accountofnala);
        }

        public void RaiseMoney()
        {
            foreach (var a in Animallist)
            {
                if (a.IsKing)
                {
                    a.Balance += 100;
                }
                else
                {
                    a.Balance += 10;
                }
            }
        }

        public void AddAccount(string name, int amount, string animal, bool king, bool good)
        {
            var accountofanimal = new BankAccount
            {
                Name = name,
                Balance = amount,
                AnimalType = animal,
                IsKing = king,
                IsGood = good
            };

            Animallist.Add(accountofanimal);
        }
    }
}
