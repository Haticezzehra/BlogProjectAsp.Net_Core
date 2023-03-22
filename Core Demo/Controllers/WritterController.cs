using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{

    public class WritterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();

        }

    }
}
