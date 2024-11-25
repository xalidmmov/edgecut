using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class FurnitureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
