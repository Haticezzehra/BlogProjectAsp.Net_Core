using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class DashBoardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
