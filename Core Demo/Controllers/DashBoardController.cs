using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class DashBoardController : Controller
    {
      
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.v1 = context.Blogs.Count().ToString();
            ViewBag.v2 = context.Blogs.Where(b => b.WriterID == 1).Count().ToString();
            ViewBag.v3 = context.Categories.Count().ToString();
            return View();
        }


    }
}
