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
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        

        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greetings greet = new Greetings()
            {
                Id = 1,

                Content = "Guten Tag!"
            };
        
            return new JsonResult(greet);
        }
    }
}
