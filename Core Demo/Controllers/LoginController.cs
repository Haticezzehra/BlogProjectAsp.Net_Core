using Core_Demo.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Security.Claims;

namespace Core_Demo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //Identityden alınan identity üzerinden sign olma işlemi
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "DashBoard");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }



        //[HttpPost]

        //public async Task<IActionResult> Index(Writer writer)
        //{
        //    Context con = new Context();
        //    var dataValue = con.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail
        //    && x.WriterPassword == writer.WriterPassword);
        //    if (dataValue != null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,writer.WriterMail)
        //        };
        //        var useridentity = new ClaimsIdentity(claims, "a");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "DashBoard");


        //    }
        //    else
        //    {
        //        return View();
        //    }




        //}
    }
}

