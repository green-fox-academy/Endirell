using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        Greeting Visitor;

        public HomeController(Greeting user)
        {
            Visitor = user;
        }

        [HttpGet("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(Visitor);
        }

        [HttpPost("addname")]
        public IActionResult Addname(Greeting user)
        {
            Visitor.VisitorName = user.VisitorName;

            return RedirectToAction("greet");
        }
    }
}
