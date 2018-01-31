using Microsoft.AspNetCore.Mvc;
using WebStore.Services;

namespace WebStore.Controllers
{
    [Route("")]
    public class WebStoreController : Controller
    {
        private WebStoreService webStoreService;

        public WebStoreController(WebStoreService webStoreService)
        {
            this.webStoreService = webStoreService;
        }

        [HttpGet("warehouse")]
        public IActionResult Summary()
        {

            return View();
        }

        [HttpGet("")]
        public IActionResult Warehouse()
        {

            return View(webStoreService.GetClothesList());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Inde()
        {

            return View();
        }

        [HttpGet("warehouse/query")]
        public IActionResult Ind()
        {
            //return Json();
            return Ok();
        }

       
    }
}
