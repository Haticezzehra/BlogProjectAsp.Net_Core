using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Core_Demo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = categoryManager.GetAll().ToPagedList(page, 3);
            return View(values);
        }
    }
}
