using Microsoft.AspNetCore.Mvc;

namespace QRFoodOrderingSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
