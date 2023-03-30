using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Demo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = blogManager.GetAll().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            string api = "6012015772180dfc71484d07b51f46ca";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=antalya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //Descendants ile <> elementini seçtik elementat(0) seçtiğimiz elementin sıfırıncı elemanı
            //Attribute ise özellik demek value özelliğini viewbaga atadık.
            return View();
        }
    }
}
