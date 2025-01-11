using Microsoft.AspNetCore.Mvc;

namespace QRFoodOrderingSystem.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
