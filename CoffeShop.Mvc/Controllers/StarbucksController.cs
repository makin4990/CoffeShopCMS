using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Mvc.Controllers
{
    public class StarbucksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
