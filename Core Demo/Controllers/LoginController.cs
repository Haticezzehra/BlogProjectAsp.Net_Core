using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer writer)
        {
            Context context = new Context();
            var dataValue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail
            && x.WriterPassword == writer.WriterPassword);
            if (dataValue != null)
            {
                HttpContext.Session.SetString("username", writer.WriterMail);
                return RedirectToAction( "Index", "Writer");
            }
            else
            {
                return View();
            }

        }
    }
}
