using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class DashBoardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            Context context = new Context();
            var username = User.Identity.Name;

            ViewBag.veri = username;
            var usermail = context.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerid = context.Writers.Where(x => x.WriterMail == usermail).Select
                (y => y.WriterID).FirstOrDefault();
            ViewBag.v1 = context.Blogs.Count().ToString();
            ViewBag.v2 = context.Blogs.Where(b => b.WriterID == writerid).Count().ToString();
            ViewBag.v3 = context.Categories.Count().ToString();
            return View();
        }


    }
}
