using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBDemo.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBDemo.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private SuperheroRepository superheroRepository;

        public HomeController(SuperheroRepository superheroRepository)
        {
            this.superheroRepository = superheroRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(superheroRepository.HeroList());
        }
    }
}
