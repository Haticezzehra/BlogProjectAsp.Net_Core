using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager=new WriterManager(new EfWriterRepository());
        
        [HttpGet] //Sayfa yüklenince çalışıyo
        public IActionResult Index()
        {
            return View();
        }
        //Ekleme işlemi yapılırken httpget ve httppost attributerinin tanımlandığı metotların issimleri aynı olmak zorunda  
        [HttpPost] //Sayfada buton tetiklenince çalışıyo
        public IActionResult Index(Writer writer)
        {
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme";
            writerManager.WriterAdd(writer);
            return RedirectToAction("Index","BlogControllers");

        }
    }
}
//Mesela httpget atribute komutu  sayfada kategorize veya benzeri işlemler kulllanılırken sayfa yüklendiği anda 
//listelenmesini istenen niteliklerde kulllanılabilir.