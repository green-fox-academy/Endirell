using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Training.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int counter = 0;

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            counter++;

            var greeting = new Greeting(name)
            {
                TimesLoaded = counter,
                Id = 1,
                Content = name
                
            };

            return View(greeting);
        }

    }
}
