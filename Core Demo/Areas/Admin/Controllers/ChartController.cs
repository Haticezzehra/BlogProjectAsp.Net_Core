using Core_Demo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 6
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 9
            });
            return Json(new { jsonlist = list });

        }
    }
}
