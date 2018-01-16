using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public static BankAccountsViewModel vm = new BankAccountsViewModel();

        [HttpGet("index")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("simba")]
        public IActionResult Simba()
        {

            var accountofsimba = new BankAccount
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion"
            };

            return View(accountofsimba);
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View(vm);
        }

        [HttpPost("addmoney")]
        public IActionResult Addmoney()
        {
            vm.RaiseMoney();

            return Redirect("list");
        }

        [HttpPost("addnewbankaccount")]
        public IActionResult AddAnimal(string name, int amount, string animal, bool king, bool good)
        {
            vm.AddAccount(name, amount, animal, king, good);

            return Redirect("list");
        }
    }
}
