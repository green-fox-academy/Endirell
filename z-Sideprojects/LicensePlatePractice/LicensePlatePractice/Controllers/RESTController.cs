using LicensePlatePractice.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicensePlatePractice.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        private CarService carService;

        public RESTController(CarService carService)
        {
            this.carService = carService;        
        }

        [HttpGet("search/{brand}")]
        public IActionResult Search([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = carService.GetBrandList(brand) });
        }
    }

   
}
