using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        private CounterModel cm;

        public HomeController(CounterModel cm)
        {
            this.cm = cm;
        }

        [HttpGet("")]
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View(cm);
        }

        [HttpPost("")]
        public IActionResult Reload()
        {
            cm.Number++;

            return RedirectToAction("Index");
        }
    }
}
