using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();

        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 23;
            commentManager.Add(comment);
            return PartialView();

        }
        public PartialViewResult CommentListBlog(int id)
        {
            var values = commentManager.GetAll(id);
            return PartialView(values);
        }
    }
}
