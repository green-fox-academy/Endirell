using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
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
        
        [HttpGet("")]
        [HttpGet("warehouse")]
        public IActionResult Warehouse()
        {

            return View(webStoreService.GetViewModel());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary(int amount, string unitname, string unitsize)
        {
            return View(webStoreService.GetSummary(amount, unitname, unitsize));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Itemlister([FromQuery] int price, string type)
        {
            //return Json();
            return Json(webStoreService.ListByPrice(price, type));
        }
        //public IActionResult Query(double price, string type)
        //{
        //    return Json(clothesService.SearchWithSize(price, type));
        //}


    }
}
