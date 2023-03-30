using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace Core_Demo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Name);
            ViewBag.v2 = c.Admins.Where(x => x.AdminID == 1).Select(x => x.ImageURL);
            ViewBag.v3 = c.Admins.Where(X => X.AdminID == 1).Select(X => X.ShortDescription);
            
            return View();
        }
    }
}


