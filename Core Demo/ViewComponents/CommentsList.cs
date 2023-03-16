using Presantation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents
{
    public class CommentsList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="Murat"
                },
                new UserComment
                {
                    ID = 2,
                    UserName="Mesut"
                },
                new UserComment
                {
                    ID = 3,
                    UserName="Serap"
                }
            };
            return View(commentvalues);
        }
    }
}
