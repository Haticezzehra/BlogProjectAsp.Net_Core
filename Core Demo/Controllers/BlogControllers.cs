using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class BlogControllers : Controller
    {
        BlogManager blogManager=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values=blogManager.GetAll();
            return View(values);
        }
    }
}
