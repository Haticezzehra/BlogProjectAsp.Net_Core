using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
