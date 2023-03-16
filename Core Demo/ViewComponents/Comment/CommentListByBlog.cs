using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            var values = commentManager.GetAll(8);
            return View(values);
        }
    }
}
