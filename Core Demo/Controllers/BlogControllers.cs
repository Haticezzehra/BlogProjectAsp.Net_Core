using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class BlogControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
