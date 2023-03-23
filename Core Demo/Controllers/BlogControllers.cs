using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_Demo.Controllers
{
    [AllowAnonymous]
    public class BlogControllers : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = blogManager.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values = blogManager.GetListWithCategoryByWriterBm(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in categoryManager.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.cv = categories;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidator wv = new BlogValidator();
            ValidationResult result = wv.Validate(blog);
            List<SelectListItem> categories = (from x in categoryManager.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.cv = categories;

            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = 1;
                blogManager.Add(blog);
                return RedirectToAction("BlogListByWriter", "BlogControllers");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        public IActionResult DeleteBlog(int id)
        {
            var value = blogManager.GetById(id);
            blogManager.Delete(value);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]

        public IActionResult EditBlog(int id)
        {
            var value = blogManager.GetById(id);
            List<SelectListItem> categories = (from x in categoryManager.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.cv = categories;
            return View(value);
        }

        [HttpPost]

        public IActionResult EditBlog(Blog blog)
        {
            blog.WriterID = 1;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogStatus = true;
            blogManager.Update(blog);
            return RedirectToAction("BlogListByWriter");
        }
    }

}

