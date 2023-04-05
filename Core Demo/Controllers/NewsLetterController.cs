using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            newsLetterManager.Add(p);
        
            return PartialView();

        }
    }
}
/* NewsLetter newsLetter = new NewsLetter();
            newsLetter.MailStatus = true;
            newsLetter.Mail=p.Mail;
         
            newsLetterManager.AddNewsLetter(newsLetter);
            RedirectToAction("Default", "Index");
            Response.Redirect("/Blog/BlogReadAll/" + 1);
            return View();
*/