using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents
{
    public class CommentsList:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
