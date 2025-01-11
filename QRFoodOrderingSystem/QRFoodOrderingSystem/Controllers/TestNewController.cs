using Microsoft.AspNetCore.Mvc;

namespace QRFoodOrderingSystem.Controllers
{
    public class TestNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
