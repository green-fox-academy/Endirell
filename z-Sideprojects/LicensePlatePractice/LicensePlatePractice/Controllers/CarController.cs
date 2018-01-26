using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePlatePractice.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("search")]
        public IActionResult Search()
        {
            return View();
        }


    }
    
}
