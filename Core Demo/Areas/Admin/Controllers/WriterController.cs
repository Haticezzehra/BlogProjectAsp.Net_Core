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
        public IActionResult GetWriterById(int writerid)
        {
            var findWriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriter);
        }
        [HttpPost]
        public IActionResult AddWriter(WritterClass writer)
        {
            writers.Add(writer);
            var jsonWriters = JsonConvert.SerializeObject(writer);
            return Json(jsonWriters);
        }
        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(writer);
            return Json(writer);
        }
        public IActionResult UpdateWriter(WritterClass w)
        {
            var writer = writers.FirstOrDefault(x => x.Id == w.Id);
            writer.Name = w.Name;
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
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
