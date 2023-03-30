using Core_Demo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Demo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var JsonWriter = JsonConvert.SerializeObject(writers);
            return Json(JsonWriter);

        }
        public static List<WritterClass> writers = new List<WritterClass>
        {
            new WritterClass
            {
                Id=1,
                Name="Ayşe"
            },
             new WritterClass
            {
                Id=2,
                Name="Ahmet"
            },
              new WritterClass
            {
                Id=3,
                Name="Buse"
            },

        };
    }
}
