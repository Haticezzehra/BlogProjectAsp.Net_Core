using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class Register : Controller
    {
        WriterManager writerManager=new WriterManager(new EfWriterRepository());
        
        [HttpGet] //Sayfa yüklenince çalışıyo
        public IActionResult Index()
        {
            return View();
        }
        //Ekleme işlemi yapılırken httpget ve httppost attributerinin tanımlandığı metotların issimleri aynı olmak zorunda  
        //Sayfada buton tetiklenince çalışıyo
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult result= wv.Validate(writer);
            
            

            if(result.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Deneme";
                writerManager.Add(writer);
                return RedirectToAction("Index", "BlogControllers");

            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
//Mesela httpget atribute komutu  sayfada kategorize veya benzeri işlemler kulllanılırken sayfa yüklendiği anda 
//listelenmesini istenen niteliklerde kulllanılabilir.