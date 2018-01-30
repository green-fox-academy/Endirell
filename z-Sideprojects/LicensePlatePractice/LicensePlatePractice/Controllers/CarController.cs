using LicensePlatePractice.Services;
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
        private CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        public IActionResult Index()
        {
            return View(carService.GetList());
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string q, int police, int diplomat)
        {
            return View("Index", carService.GetSearchList(q, police, diplomat));
        }

        [HttpGet("search/{brand}")]
        public IActionResult BrandSearch([FromRoute] string brand)
        {
            return View("Index", carService.GetBrandList(brand));
        }


    }
    
}
