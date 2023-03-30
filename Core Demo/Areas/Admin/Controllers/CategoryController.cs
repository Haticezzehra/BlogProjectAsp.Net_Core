using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata;
using X.PagedList;

namespace Core_Demo.Areas.Controllers
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

        [HttpGet]
        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator wv = new CategoryValidator();
            ValidationResult result = wv.Validate(category);
            Category category1 = new Category();
            // if (result.IsValid)
            // {
            category1.CategoryName = category.CategoryName;
            category1.CategoryDescription = category.CategoryDescription;
            category1.CategoryStatus = true;
            categoryManager.Add(category1);
            return RedirectToAction("Category", "Admin");

            //  }
            // else
            // {


            //  foreach (var item in result.Errors)
            // {
            //ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            // }
            //  }
            // return View();
        }
        public IActionResult CategoryDelete(int id)
        {
            var value = categoryManager.GetById(id);
            categoryManager.Delete(value);
            return RedirectToAction("Category", "Admin");
        }
    }
}
