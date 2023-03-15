using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class CategoryController1 : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values= cm.GetAll();
            return View(values);
        }
    }
}
