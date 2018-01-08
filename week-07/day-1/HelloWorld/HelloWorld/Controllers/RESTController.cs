using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int counter = 0;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            Greetings greet = new Greetings(name);

            counter++;

            greet.Id = counter;
        
            return new JsonResult(greet);
        }
    }
}
