using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int counter = 0;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greetings()
            {
                Id = 1,
                Content = "World"
            };

            return View(greeting);
        }

        [Route("greet")]
        public IActionResult Greeting([FromQuery] string name)
        {
            Greetings greet = new Greetings(name);

            counter++;

            greet.Id = counter;

            greet.Content = "Hello, " + name + "! This site was loaded " + counter + " times since last server start.";

            //return new JsonResult(greet);
            return View(greet);
        }
    }
}
