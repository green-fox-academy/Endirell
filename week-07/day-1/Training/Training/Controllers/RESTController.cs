using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Training.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static long counter = 0;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            Greeting firstgreet = new Greeting(name);
            
            counter++;

            firstgreet.Id = counter;

            return new JsonResult(firstgreet);
        }
    }
}
