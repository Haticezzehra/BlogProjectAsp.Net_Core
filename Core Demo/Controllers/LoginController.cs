using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
