using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
